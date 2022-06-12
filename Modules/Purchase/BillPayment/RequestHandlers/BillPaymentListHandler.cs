﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InvoiceKu.Purchase.BillPaymentRow>;
using MyRow = InvoiceKu.Purchase.BillPaymentRow;

namespace InvoiceKu.Purchase
{
    public interface IBillPaymentListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

    public class BillPaymentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBillPaymentListHandler
    {
        public BillPaymentListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}