#pragma checksum "E:\susmitha\emas\Views\Employ\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b81c44e490775fc859eab5e1758c95b9b1f7c21b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employ_Search), @"mvc.1.0.view", @"/Views/Employ/Search.cshtml")]
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
#line 1 "E:\susmitha\emas\Views\_ViewImports.cshtml"
using emas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\susmitha\emas\Views\_ViewImports.cshtml"
using emas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b81c44e490775fc859eab5e1758c95b9b1f7c21b", @"/Views/Employ/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e11028e54129a4c4e16e59aaf1dc25e92196a88a", @"/Views/_ViewImports.cshtml")]
    public class Views_Employ_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<emas.Models.Employ>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\susmitha\emas\Views\Employ\Search.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b81c44e490775fc859eab5e1758c95b9b1f7c21b3328", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Search</title>\r\n");
#nullable restore
#line 13 "E:\susmitha\emas\Views\Employ\Search.cshtml"
       
        Layout = null;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b81c44e490775fc859eab5e1758c95b9b1f7c21b4591", async() => {
                WriteLiteral("\r\n    \r\n    \r\n");
#nullable restore
#line 21 "E:\susmitha\emas\Views\Employ\Search.cshtml"
      var emp1=@ViewData["Employ"] as emas.Models.Employ;
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <h1>Employ</h1>\r\n    <table border=\"1\">\r\n        <tr>\r\n            <td> Id</td>\r\n            <td>name</td>\r\n            <td>email</td>\r\n            <td>dept</td>\r\n\r\n\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 34 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(emp1.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(emp1.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(emp1.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(emp1.dept);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(ViewBag.Employ.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(ViewBag.Employ.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(ViewBag.Employ.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(ViewBag.Employ.dept);

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n            </td>\r\n        </tr>\r\n\r\n        <tr>\r\n            <td>");
#nullable restore
#line 55 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "E:\susmitha\emas\Views\Employ\Search.cshtml"
           Write(Model.dept);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<emas.Models.Employ> Html { get; private set; }
    }
}
#pragma warning restore 1591
