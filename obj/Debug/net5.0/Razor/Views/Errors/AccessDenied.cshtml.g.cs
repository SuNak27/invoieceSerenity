#pragma checksum "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e821ee7135dfdc012d7857829cfccd92a4bdc5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Errors_AccessDenied), @"mvc.1.0.view", @"/Views/Errors/AccessDenied.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using InvoiceKu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e821ee7135dfdc012d7857829cfccd92a4bdc5c", @"/Views/Errors/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc171bdc1e720eb898b9f86ce94c1dde67bcbc76", @"/Views/_ViewImports.cshtml")]
    public class Views_Errors_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
  
    ViewData["Title"] = Texts.Site.AccessDenied.PageTitle.ToString(Localizer);
    ViewData["PageId"] = "AccessDenied";
    Layout = User.IsLoggedIn() ?
        "~/Views/Shared/_Layout.cshtml" :
        "~/Views/Shared/_LayoutNoNavigation.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-content"">
    <div class=""message"">
        <table>
            <tr>
                <td style=""width: 200px;"">
                    <i class=""fa fa-times-circle text-red"" style=""font-size: 180px;""></i>
                </td>
                <td>
                    <h1>");
#nullable restore
#line 19 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                   Write(Texts.Site.AccessDenied.PageTitle.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <h3>");
#nullable restore
#line 20 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                    Write(User.IsLoggedIn() ? Texts.Site.AccessDenied.LackPermissions.ToString(Localizer) : Texts.Site.AccessDenied.NotLoggedIn.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 21 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"redirect\"");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 982, 2);
            WriteAttributeValue("", 951, "/Account/Login?returnURL=", 951, 25, true);
#nullable restore
#line 23 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
WriteAttributeValue("", 976, Model, 976, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                                                                               Write(User.IsLoggedIn() ? 
                            Texts.Site.AccessDenied.ClickToChangeUser.ToString(Localizer) : Texts.Site.AccessDenied.ClickToLogin.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 25 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"redirect\" href=\"/Account/Login\">");
#nullable restore
#line 28 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                                                             Write(Texts.Site.AccessDenied.ClickToLogin.ToString(Localizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 29 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"date-time\">\r\n                        ");
#nullable restore
#line 31 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                    Write(!User.IsLoggedIn() ? "" : (User?.Identity?.Name + " - "));

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Alfad\OneDrive\Documents\KaryawanInvoice\project\InvoiceKu\InvoiceKu.Web\Views\Errors\AccessDenied.cshtml"
                                                                              Write(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"clear\"></div>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        \r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITextLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
