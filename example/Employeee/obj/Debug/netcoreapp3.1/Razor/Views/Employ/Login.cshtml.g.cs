#pragma checksum "E:\susmitha\Employeee\Views\Employ\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ede284924a24b270ff8f6dc2e3adfab81ce28618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employ_Login), @"mvc.1.0.view", @"/Views/Employ/Login.cshtml")]
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
#line 1 "E:\susmitha\Employeee\Views\_ViewImports.cshtml"
using Employeee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\susmitha\Employeee\Views\_ViewImports.cshtml"
using Employeee.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ede284924a24b270ff8f6dc2e3adfab81ce28618", @"/Views/Employ/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"351dd9b63ccd7724065218979665ae2921484a6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employ_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login</h1>\r\n");
#nullable restore
#line 8 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tr>\r\n            <td>eid</td>\r\n            <td>");
#nullable restore
#line 13 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
           Write(Html.TextBox("eid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>password</td>\r\n            <td>");
#nullable restore
#line 17 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
           Write(Html.TextBox("password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <input type=\"submit\" value=\"Login\" class=\"btn btn-primary\" />\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                <span class=\"text-danger\">");
#nullable restore
#line 26 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
                                     Write(ViewData["err"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </td>\r\n        </tr>\r\n\r\n    </table>\r\n");
#nullable restore
#line 31 "E:\susmitha\Employeee\Views\Employ\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
