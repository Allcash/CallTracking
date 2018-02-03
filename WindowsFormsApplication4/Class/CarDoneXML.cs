
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class rows
{

    private rowsOrder[] orderField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("order")]
    public rowsOrder[] order
    {
        get
        {
            return this.orderField;
        }
        set
        {
            this.orderField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rowsOrder
{

    private uint idField;

    private byte orderNoField;

    private byte actNoField;

    private bool actNoFieldSpecified;

    private byte statusField;

    private string statusAliasField;

    private byte isTrainingField;

    private System.DateTime orderDateField;

    private System.DateTime estimateDateField;

    private double workTotalCostField;

    private double spareTotalCostField;

    private double grandTotalCostField;

    private byte vatRateField;

    private float vatCostField;

    private double grandTotalCostIncVatField;

    private byte cashPaymentField;

    private System.DateTime paymentDateField;

    private bool paymentDateFieldSpecified;

    private System.DateTime paymentDueDateField;

    private bool paymentDueDateFieldSpecified;

    private string recommendationField;

    private uint mileageField;

    private string annotationField;

    private string customerWorkField;

    private object proxyNumberField;

    private string notesField;

    private string currencyField;

    private float contractorTotalCostField;

    private float contractorVatCostField;

    private System.DateTime createdField;

    private System.DateTime modifiedField;

    private ushort employeeIdField;

    private string employeeFullNameField;

    private uint ownerIdField;

    private string ownerFullNameField;

    private uint clientIdField;

    private string clientFullNameField;

    private string clientPrimaryPhoneField;

    private uint vehicalIdField;

    private string vehicalRegNoField;

    private string vehicalBodyNoField;

    private rowsOrderClientSpare[] clientSparesField;

    private rowsOrderStationSpare[] stationSparesField;

    private rowsOrderWork[] worksField;

    /// <remarks/>
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public byte orderNo
    {
        get
        {
            return this.orderNoField;
        }
        set
        {
            this.orderNoField = value;
        }
    }

    /// <remarks/>
    public byte actNo
    {
        get
        {
            return this.actNoField;
        }
        set
        {
            this.actNoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool actNoSpecified
    {
        get
        {
            return this.actNoFieldSpecified;
        }
        set
        {
            this.actNoFieldSpecified = value;
        }
    }

    /// <remarks/>
    public byte status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }

    /// <remarks/>
    public string statusAlias
    {
        get
        {
            return this.statusAliasField;
        }
        set
        {
            this.statusAliasField = value;
        }
    }

    /// <remarks/>
    public byte isTraining
    {
        get
        {
            return this.isTrainingField;
        }
        set
        {
            this.isTrainingField = value;
        }
    }

    /// <remarks/>
    public System.DateTime orderDate
    {
        get
        {
            return this.orderDateField;
        }
        set
        {
            this.orderDateField = value;
        }
    }

    /// <remarks/>
    public System.DateTime estimateDate
    {
        get
        {
            return this.estimateDateField;
        }
        set
        {
            this.estimateDateField = value;
        }
    }

    /// <remarks/>
    public double workTotalCost
    {
        get
        {
            return this.workTotalCostField;
        }
        set
        {
            this.workTotalCostField = value;
        }
    }

    /// <remarks/>
    public double spareTotalCost
    {
        get
        {
            return this.spareTotalCostField;
        }
        set
        {
            this.spareTotalCostField = value;
        }
    }

    /// <remarks/>
    public double grandTotalCost
    {
        get
        {
            return this.grandTotalCostField;
        }
        set
        {
            this.grandTotalCostField = value;
        }
    }

    /// <remarks/>
    public byte vatRate
    {
        get
        {
            return this.vatRateField;
        }
        set
        {
            this.vatRateField = value;
        }
    }

    /// <remarks/>
    public float vatCost
    {
        get
        {
            return this.vatCostField;
        }
        set
        {
            this.vatCostField = value;
        }
    }

    /// <remarks/>
    public double grandTotalCostIncVat
    {
        get
        {
            return this.grandTotalCostIncVatField;
        }
        set
        {
            this.grandTotalCostIncVatField = value;
        }
    }

    /// <remarks/>
    public byte cashPayment
    {
        get
        {
            return this.cashPaymentField;
        }
        set
        {
            this.cashPaymentField = value;
        }
    }

    /// <remarks/>
    public System.DateTime paymentDate
    {
        get
        {
            return this.paymentDateField;
        }
        set
        {
            this.paymentDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool paymentDateSpecified
    {
        get
        {
            return this.paymentDateFieldSpecified;
        }
        set
        {
            this.paymentDateFieldSpecified = value;
        }
    }

    /// <remarks/>
    public System.DateTime paymentDueDate
    {
        get
        {
            return this.paymentDueDateField;
        }
        set
        {
            this.paymentDueDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool paymentDueDateSpecified
    {
        get
        {
            return this.paymentDueDateFieldSpecified;
        }
        set
        {
            this.paymentDueDateFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string recommendation
    {
        get
        {
            return this.recommendationField;
        }
        set
        {
            this.recommendationField = value;
        }
    }

    /// <remarks/>
    public uint mileage
    {
        get
        {
            return this.mileageField;
        }
        set
        {
            this.mileageField = value;
        }
    }

    /// <remarks/>
    public string annotation
    {
        get
        {
            return this.annotationField;
        }
        set
        {
            this.annotationField = value;
        }
    }

    /// <remarks/>
    public string customerWork
    {
        get
        {
            return this.customerWorkField;
        }
        set
        {
            this.customerWorkField = value;
        }
    }

    /// <remarks/>
    public object proxyNumber
    {
        get
        {
            return this.proxyNumberField;
        }
        set
        {
            this.proxyNumberField = value;
        }
    }

    /// <remarks/>
    public string notes
    {
        get
        {
            return this.notesField;
        }
        set
        {
            this.notesField = value;
        }
    }

    /// <remarks/>
    public string currency
    {
        get
        {
            return this.currencyField;
        }
        set
        {
            this.currencyField = value;
        }
    }

    /// <remarks/>
    public float contractorTotalCost
    {
        get
        {
            return this.contractorTotalCostField;
        }
        set
        {
            this.contractorTotalCostField = value;
        }
    }

    /// <remarks/>
    public float contractorVatCost
    {
        get
        {
            return this.contractorVatCostField;
        }
        set
        {
            this.contractorVatCostField = value;
        }
    }

    /// <remarks/>
    public System.DateTime created
    {
        get
        {
            return this.createdField;
        }
        set
        {
            this.createdField = value;
        }
    }

    /// <remarks/>
    public System.DateTime modified
    {
        get
        {
            return this.modifiedField;
        }
        set
        {
            this.modifiedField = value;
        }
    }

    /// <remarks/>
    public ushort employeeId
    {
        get
        {
            return this.employeeIdField;
        }
        set
        {
            this.employeeIdField = value;
        }
    }

    /// <remarks/>
    public string employeeFullName
    {
        get
        {
            return this.employeeFullNameField;
        }
        set
        {
            this.employeeFullNameField = value;
        }
    }

    /// <remarks/>
    public uint ownerId
    {
        get
        {
            return this.ownerIdField;
        }
        set
        {
            this.ownerIdField = value;
        }
    }

    /// <remarks/>
    public string ownerFullName
    {
        get
        {
            return this.ownerFullNameField;
        }
        set
        {
            this.ownerFullNameField = value;
        }
    }

    /// <remarks/>
    public uint clientId
    {
        get
        {
            return this.clientIdField;
        }
        set
        {
            this.clientIdField = value;
        }
    }

    /// <remarks/>
    public string clientFullName
    {
        get
        {
            return this.clientFullNameField;
        }
        set
        {
            this.clientFullNameField = value;
        }
    }

    /// <remarks/>
    public string clientPrimaryPhone
    {
        get
        {
            return this.clientPrimaryPhoneField;
        }
        set
        {
            this.clientPrimaryPhoneField = value;
        }
    }

    /// <remarks/>
    public uint vehicalId
    {
        get
        {
            return this.vehicalIdField;
        }
        set
        {
            this.vehicalIdField = value;
        }
    }

    /// <remarks/>
    public string vehicalRegNo
    {
        get
        {
            return this.vehicalRegNoField;
        }
        set
        {
            this.vehicalRegNoField = value;
        }
    }

    /// <remarks/>
    public string vehicalBodyNo
    {
        get
        {
            return this.vehicalBodyNoField;
        }
        set
        {
            this.vehicalBodyNoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("clientSpare", IsNullable = false)]
    public rowsOrderClientSpare[] clientSpares
    {
        get
        {
            return this.clientSparesField;
        }
        set
        {
            this.clientSparesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("stationSpare", IsNullable = false)]
    public rowsOrderStationSpare[] stationSpares
    {
        get
        {
            return this.stationSparesField;
        }
        set
        {
            this.stationSparesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("work", IsNullable = false)]
    public rowsOrderWork[] works
    {
        get
        {
            return this.worksField;
        }
        set
        {
            this.worksField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rowsOrderClientSpare
{

    private uint idField;

    private uint orderIdField;

    private string spareNameField;

    private string measureField;

    private float countField;

    private byte usedField;

    private float estimatedPriceField;

    /// <remarks/>
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public uint orderId
    {
        get
        {
            return this.orderIdField;
        }
        set
        {
            this.orderIdField = value;
        }
    }

    /// <remarks/>
    public string spareName
    {
        get
        {
            return this.spareNameField;
        }
        set
        {
            this.spareNameField = value;
        }
    }

    /// <remarks/>
    public string measure
    {
        get
        {
            return this.measureField;
        }
        set
        {
            this.measureField = value;
        }
    }

    /// <remarks/>
    public float count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }

    /// <remarks/>
    public byte used
    {
        get
        {
            return this.usedField;
        }
        set
        {
            this.usedField = value;
        }
    }

    /// <remarks/>
    public float estimatedPrice
    {
        get
        {
            return this.estimatedPriceField;
        }
        set
        {
            this.estimatedPriceField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rowsOrderStationSpare
{

    private uint idField;

    private uint orderIdField;

    private string spareNameField;

    private string measureField;

    private float countField;

    private float costField;

    private double totalCostField;

    private string catalogNumberField;

    private byte vatField;

    /// <remarks/>
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public uint orderId
    {
        get
        {
            return this.orderIdField;
        }
        set
        {
            this.orderIdField = value;
        }
    }

    /// <remarks/>
    public string spareName
    {
        get
        {
            return this.spareNameField;
        }
        set
        {
            this.spareNameField = value;
        }
    }

    /// <remarks/>
    public string measure
    {
        get
        {
            return this.measureField;
        }
        set
        {
            this.measureField = value;
        }
    }

    /// <remarks/>
    public float count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }

    /// <remarks/>
    public float cost
    {
        get
        {
            return this.costField;
        }
        set
        {
            this.costField = value;
        }
    }

    /// <remarks/>
    public double totalCost
    {
        get
        {
            return this.totalCostField;
        }
        set
        {
            this.totalCostField = value;
        }
    }

    /// <remarks/>
    public string catalogNumber
    {
        get
        {
            return this.catalogNumberField;
        }
        set
        {
            this.catalogNumberField = value;
        }
    }

    /// <remarks/>
    public byte vat
    {
        get
        {
            return this.vatField;
        }
        set
        {
            this.vatField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rowsOrderWork
{

    private uint idField;

    private uint orderIdField;

    private uint workIdField;

    private bool workIdFieldSpecified;

    private byte workCodeField;

    private string workDescField;

    private double countField;

    private double normTimeField;

    private float workRateField;

    private double workCostField;

    private byte discountField;

    private string workSourceField;

    private ushort responsibleIdField;

    private byte positionField;

    private byte ignoreWorkOnCalcField;

    private rowsOrderWorkWorkEmployee[] workEmployeesField;

    /// <remarks/>
    public uint id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }

    /// <remarks/>
    public uint orderId
    {
        get
        {
            return this.orderIdField;
        }
        set
        {
            this.orderIdField = value;
        }
    }

    /// <remarks/>
    public uint workId
    {
        get
        {
            return this.workIdField;
        }
        set
        {
            this.workIdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool workIdSpecified
    {
        get
        {
            return this.workIdFieldSpecified;
        }
        set
        {
            this.workIdFieldSpecified = value;
        }
    }

    /// <remarks/>
    public byte workCode
    {
        get
        {
            return this.workCodeField;
        }
        set
        {
            this.workCodeField = value;
        }
    }

    /// <remarks/>
    public string workDesc
    {
        get
        {
            return this.workDescField;
        }
        set
        {
            this.workDescField = value;
        }
    }

    /// <remarks/>
    public double count
    {
        get
        {
            return this.countField;
        }
        set
        {
            this.countField = value;
        }
    }

    /// <remarks/>
    public double normTime
    {
        get
        {
            return this.normTimeField;
        }
        set
        {
            this.normTimeField = value;
        }
    }

    /// <remarks/>
    public float workRate
    {
        get
        {
            return this.workRateField;
        }
        set
        {
            this.workRateField = value;
        }
    }

    /// <remarks/>
    public double workCost
    {
        get
        {
            return this.workCostField;
        }
        set
        {
            this.workCostField = value;
        }
    }

    /// <remarks/>
    public byte discount
    {
        get
        {
            return this.discountField;
        }
        set
        {
            this.discountField = value;
        }
    }

    /// <remarks/>
    public string workSource
    {
        get
        {
            return this.workSourceField;
        }
        set
        {
            this.workSourceField = value;
        }
    }

    /// <remarks/>
    public ushort responsibleId
    {
        get
        {
            return this.responsibleIdField;
        }
        set
        {
            this.responsibleIdField = value;
        }
    }

    /// <remarks/>
    public byte position
    {
        get
        {
            return this.positionField;
        }
        set
        {
            this.positionField = value;
        }
    }

    /// <remarks/>
    public byte ignoreWorkOnCalc
    {
        get
        {
            return this.ignoreWorkOnCalcField;
        }
        set
        {
            this.ignoreWorkOnCalcField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("workEmployee", IsNullable = false)]
    public rowsOrderWorkWorkEmployee[] workEmployees
    {
        get
        {
            return this.workEmployeesField;
        }
        set
        {
            this.workEmployeesField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rowsOrderWorkWorkEmployee
{

    private uint workIdField;

    private ushort employeeIdField;

    private byte percentageField;

    private int amountField;

    private double normTimeField;

    private string fullNameField;

    /// <remarks/>
    public uint workId
    {
        get
        {
            return this.workIdField;
        }
        set
        {
            this.workIdField = value;
        }
    }

    /// <remarks/>
    public ushort employeeId
    {
        get
        {
            return this.employeeIdField;
        }
        set
        {
            this.employeeIdField = value;
        }
    }

    /// <remarks/>
    public byte percentage
    {
        get
        {
            return this.percentageField;
        }
        set
        {
            this.percentageField = value;
        }
    }

    /// <remarks/>
    public int amount
    {
        get
        {
            return this.amountField;
        }
        set
        {
            this.amountField = value;
        }
    }

    /// <remarks/>
    public double normTime
    {
        get
        {
            return this.normTimeField;
        }
        set
        {
            this.normTimeField = value;
        }
    }

    /// <remarks/>
    public string fullName
    {
        get
        {
            return this.fullNameField;
        }
        set
        {
            this.fullNameField = value;
        }
    }
}

