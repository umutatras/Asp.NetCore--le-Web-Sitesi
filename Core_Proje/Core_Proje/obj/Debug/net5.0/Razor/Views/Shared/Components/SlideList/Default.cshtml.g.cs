#pragma checksum "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89e51a8a61f1f76c59bc6b927358fa5398c5f792"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SlideList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SlideList/Default.cshtml")]
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
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89e51a8a61f1f76c59bc6b927358fa5398c5f792", @"/Views/Shared/Components/SlideList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SlideList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Portfolio>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""col-md-6 col-xl-4 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Proje Resimleri</h4>
            <div class=""owl-carousel owl-theme full-width owl-carousel-dash portfolio-carousel"" id=""owl-carousel-basic"">
");
#nullable restore
#line 10 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
                 foreach(var item in Model) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"item\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 459, "\"", 479, 1);
#nullable restore
#line 12 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
WriteAttributeValue("", 465, item.ImageUrl, 465, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 480, "\"", 486, 0);
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\">\r\n                </div>\r\n");
#nullable restore
#line 14 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\Shared\Components\SlideList\Default.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n         \r\n    </div>\r\n</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Portfolio>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
