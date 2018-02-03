using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsFormsApplication4.Class;
using WindowsFormsApplication4.html;

namespace WindowsFormsApplication4
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        public string html;
        public rows XMLCarDone;
        public List<CallTrackingCSV> CallTrackingCSVs = new List<CallTrackingCSV>();
        public  List<Report> OrderReport = new List<Report>(); 

        private void cardoneXML_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                cardoneXML_textbox.Text = openFileDialog1.FileName;
            }
        }

        private void CallTrackingCSV_btn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CallTrackingCSV_textbox.Text = openFileDialog1.FileName;
            }
        }

        private void OK_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string path = cardoneXML_textbox.Text;
                if (File.Exists(path))
                {
                    var ser = new XmlSerializer(typeof(rows));
                    TextReader reader = new StreamReader(path);
                    XMLCarDone = ser.Deserialize(reader) as rows;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Во время обработки XML-файла CarDone.by произошла ошибка");
            }

            try
            {
                string[] values = File.ReadAllLines(CallTrackingCSV_textbox.Text, Encoding.Default);

                for (int i = 1; i < values.Length; i++)
                {
                    CallTrackingCSVs.Add(new CallTrackingCSV
                    {
                        CallTime = Convert.ToDateTime(values[i].Split(';')[0]),
                        CallSource = values[i].Split(';')[1],
                        CallNumber= values[i].Split(';')[2],
                        CallOperator = values[i].Split(';')[3],
                        CallType = values[i].Split(';')[4],
                        CallStatus = values[i].Split(';')[5],
                        CallEstimate = values[i].Split(';')[6]
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("");
            }

            for (int i = 0; i < XMLCarDone.order.Length; i++)
            {
                for (int j = 0; j < CallTrackingCSVs.Count; j++)
                {
                    if (XMLCarDone.order[i].clientPrimaryPhone.Replace("(", "").Replace(")", "").Replace(" ", "")== CallTrackingCSVs[j].CallNumber)
                    {
                        OrderReport.Add( new Report
                        {
                            PhoneNumber = CallTrackingCSVs[j].CallNumber,
                            OrderDate = XMLCarDone.order[i].orderDate,
                            OrderNumber = XMLCarDone.order[i].orderNo.ToString(),
                            OrderSumm = XMLCarDone.order[i].grandTotalCostIncVat,
                        });
                    }
                }
            }


            string tab = "";

            foreach (var report in OrderReport)
            {
                tab = tab +
                    table.table_html.Replace("$$$Calltracking_Phone$$$", report.PhoneNumber)
                        .Replace("$$$CallTracking_STATUS$$$", "")
                        .Replace("$$$CarDone_OrderNumber$$$", report.OrderNumber)
                        .Replace("$$$CarDone_OrderDate$$$", report.OrderDate.ToString())
                        .Replace("$$$CarDone_OrderTotalCost$$$", report.OrderSumm.ToString());
            }

           var resourceName = Assembly.GetExecutingAssembly().GetManifestResourceNames().FirstOrDefault(q => q.Contains("report.html"));

            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    html =
                        reader.ReadToEnd()
                            .Replace("$$$Order_SUM$$$", XMLCarDone.order.Length.ToString())
                            .Replace("$$$Phones_SUMM$$$", XMLCarDone.order.Length.ToString())
                            .Replace("$$$CALLTRACKING_PHONE_SUMM$$$", CallTrackingCSVs.Count.ToString()).Replace("$$$table$$$", tab);
                }
            }
            webBrowser1.DocumentText = html;

        }
    }
}
