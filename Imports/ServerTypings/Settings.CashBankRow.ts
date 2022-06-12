﻿namespace InvoiceKu.Settings {
    export interface CashBankRow {
        Id?: number;
        Name?: string;
        Description?: string;
        AccountNumber?: string;
        Street?: string;
        City?: string;
        State?: string;
        ZipCode?: string;
        Phone?: string;
        Email?: string;
        InsertDate?: string;
        InsertUserId?: number;
        UpdateDate?: string;
        UpdateUserId?: number;
        TenantId?: number;
    }

    export namespace CashBankRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'Settings.CashBank';
        export const deletePermission = 'Settings:CashBank';
        export const insertPermission = 'Settings:CashBank';
        export const readPermission = 'Settings:CashBank';
        export const updatePermission = 'Settings:CashBank';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name",
            Description = "Description",
            AccountNumber = "AccountNumber",
            Street = "Street",
            City = "City",
            State = "State",
            ZipCode = "ZipCode",
            Phone = "Phone",
            Email = "Email",
            InsertDate = "InsertDate",
            InsertUserId = "InsertUserId",
            UpdateDate = "UpdateDate",
            UpdateUserId = "UpdateUserId",
            TenantId = "TenantId"
        }
    }
}
