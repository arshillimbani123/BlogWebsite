#pragma checksum "C:\Users\rahulmondal\Desktop\BologWebsite2\BologWebsite2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c0cb90adb6b03f960a2a6d408d27a61226abb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\rahulmondal\Desktop\BologWebsite2\BologWebsite2\Views\_ViewImports.cshtml"
using BologWebsite2;

#line default
#line hidden
#line 2 "C:\Users\rahulmondal\Desktop\BologWebsite2\BologWebsite2\Views\_ViewImports.cshtml"
using BologWebsite2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c0cb90adb6b03f960a2a6d408d27a61226abb2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e1f16af496bcb48e5202d6fe2c240354356b19", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\rahulmondal\Desktop\BologWebsite2\BologWebsite2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 679, true);
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <app-root>
            <div e2e=""progress-loader"" class=""loader-container main-loader"">
                <div class=""loader-block"">
                    <div class=""spinner""></div>
                    <p class=""font-semibold mt10"">Loading... App</p>
                </div>

            </div>
        </app-root>
        <script src=""dist/app/runtime.js""></script>
        <script src=""dist/app/polyfills.js""></script>
        <script src=""dist/app/styles.js""></script>
        <script src=""dist/app/vendor.js""></script>
        <script src=""dist/app/main.js""></script>
    </div>
");
            EndContext();
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
