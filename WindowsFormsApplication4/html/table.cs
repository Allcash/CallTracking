using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4.html
{
    public static class table
    {


        public static string table_html =
            "<table width=\"100%\" border=\"0\" cellspacing=\"0\" cellpadding=\"1\" style=\"border:1px solid #000000; \">" +
            "<tr>" + "<td>Телефон(CallTracking)</td>" + "<td>$$$Calltracking_Phone$$$</td>" + "</tr>" +
            "<tr>" + "<td>Статус(CallTrackung)</td>" + "<td>$$$CallTracking_STATUS$$$</td>" + "</tr>" + "<tr>" +
            "<td>Заказ</td>" + "<td>$$$CarDone_OrderNumber$$$</td>" + "</tr>" + "<tr>" + "<td>Дата</td>" +
            "<td>$$$CarDone_OrderDate$$$</td>" +
            "</tr>" + "<tr>" + "<td>Сумма заказа</td>" + "<td>$$$CarDone_OrderTotalCost$$$</td>" + "</tr>" + "</table>" + "<br>";
    }
}
