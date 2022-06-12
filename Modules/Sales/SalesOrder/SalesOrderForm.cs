﻿using System.Net.Mime;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace InvoiceKu.Sales.Forms
{
    [FormScript("Sales.SalesOrder")]
    [BasedOnRow(typeof(SalesOrderRow), CheckNames = true)]
    public class SalesOrderForm
    {
        [Tab("General")]
        [Category("Sales Order")]
        [HalfWidth]
        public string Number { get; set; }
        [HalfWidth]
        [DefaultValue("now")]
        public DateTime OrderDate { get; set; }
        [HalfWidth]
        [TextAreaEditor(Rows = 3)]
        public string Description { get; set; }
        [HalfWidth]
        [DisplayName("Customer")]
        public int CustomerId { get; set; }

        [Category("Channel")]
        [DisplayName("Sales Channel")]
        public int SalesChannelId { get; set; }

        [Category("Detail")]
        [DisplayName("Items")]
        [SalesOrderDetailEditor]
        public List<SalesOrderDetailRow> ItemList { get; set; }

        
        [Category("Currency")]
        public string CurrencyName { get; set; }

        [Category("Summary")]
        public Double SubTotal { get; set; }
        public Double Discount { get; set; }
        public Double BeforeTax { get; set; }
        public Double TaxAmount { get; set; }
        public Double OtherCharge { get; set; }
        public Double Total { get; set; }
    }
}