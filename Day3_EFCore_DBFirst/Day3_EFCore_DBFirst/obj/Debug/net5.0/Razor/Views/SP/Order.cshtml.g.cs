#pragma checksum "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\SP\Order.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab65021c566e277da521eac144e76514e51dd129"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SP_Order), @"mvc.1.0.view", @"/Views/SP/Order.cshtml")]
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
#line 1 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\_ViewImports.cshtml"
using Day3_EFCore_DBFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\_ViewImports.cshtml"
using Day3_EFCore_DBFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab65021c566e277da521eac144e76514e51dd129", @"/Views/SP/Order.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59a6e859f88d15d3146b1d4fcb57a8d09ddc258", @"/Views/_ViewImports.cshtml")]
    public class Views_SP_Order : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\SP\Order.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Order</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\SP\Order.cshtml"
 foreach(var i in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <ul>\r\n                    <li>");
#nullable restore
#line 11 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\SP\Order.cshtml"
                   Write(i.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                </ul>\r\n");
#nullable restore
#line 13 "C:\OnlineTraining\Spantech\Gitfolder\Day3_EFCore_DBFirst\Day3_EFCore_DBFirst\Views\SP\Order.cshtml"
            }

#line default
#line hidden
#nullable disable
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
