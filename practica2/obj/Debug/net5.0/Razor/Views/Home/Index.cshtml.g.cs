#pragma checksum "C:\Users\ELIAS\Desktop\practica02\practica02\practica2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d9d2016f3a4244878fb2000bcf2bc5ce4a5274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\ELIAS\Desktop\practica02\practica02\practica2\Views\_ViewImports.cshtml"
using practica2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ELIAS\Desktop\practica02\practica02\practica2\Views\_ViewImports.cshtml"
using practica2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d9d2016f3a4244878fb2000bcf2bc5ce4a5274", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17453e5600901448e5946bc6076b8b87a023150d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ELIAS\Desktop\practica02\practica02\practica2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
        <h1 class=""titulo"">
        <center>Carrusel </center>
        </h1>

    <div id=""carrusel"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
        <li data-slide-to=""0"" class=""active""></li>
        <li data-slide-to=""1""></li>
        <li data-slide-to=""2""></li>
        
        </ol>
        <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img class=""d-block w-100"" src=""img/img1.jpg"" alt=""First slide"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""img/img2.jpg"" alt=""Second slide"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""img/img3.jpg"" alt=""Third slide"">
        </div>
            </div>
        <a class=""carousel-control-prev"" href=""#carrusel"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden");
            WriteLiteral(@"=""true""></span>
        </a>
        <a class=""carousel-control-next"" href=""#carrusel"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        </a>
    </div>

    <div>
        <button class=""btn btn-primary"" id=""registro"">Registrarme</button>
    </div>
    
</div>
");
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
