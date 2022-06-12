﻿using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Data;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InvoiceKu.Merchandise.UomRow>;
using MyRow = InvoiceKu.Merchandise.UomRow;

namespace InvoiceKu.Merchandise
{
    public interface IUomRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

    public class UomRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUomRetrieveHandler
    {
        public UomRetrieveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}