#pragma checksum "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6db0bb23239be4b2af3709ad59d96b5cd539f544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6db0bb23239be4b2af3709ad59d96b5cd539f544", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.About>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <div class=\"card-header border-0\">\r\n              <h3 class=\"mb-0\">Hakkımda Güncelleme</h3>\r\n </div>     \r\n \r\n");
#nullable restore
#line 12 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
  using(Html.BeginForm("Index","About",FormMethod.Post))
 {
     

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.HiddenFor(x=>x.AboutID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br /> <br /> \r\n");
#nullable restore
#line 16 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.Label("Başlık Adı "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 17 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Title,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 20 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.Label("Açıklama  "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 21 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Description,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
 Write(Html.Label("Yaş Değeri "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 24 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Age,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
   Write(Html.Label("Mail Değeri "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 27 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Mail,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 29 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
   Write(Html.Label("Telefon Değeri "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 30 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Phone,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 32 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
   Write(Html.Label("Adres Değeri "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 33 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.Address,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
      Write(Html.Label("ImageUrl Değeri "));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />  <br />\r\n");
#nullable restore
#line 36 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Güncelle</button>\r\n");
#nullable restore
#line 39 "C:\Users\Umut\source\repos\Core_Proje\Core_Proje\Views\About\Index.cshtml"
  
 }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.About> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
