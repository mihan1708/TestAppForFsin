#pragma checksum "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Car\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d50d91550b36adea2a8c0157b98369f8a1fa09e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_Report), @"mvc.1.0.view", @"/Views/Car/Report.cshtml")]
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
#line 1 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\_ViewImports.cshtml"
using TestApplicationForFSIN;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\_ViewImports.cshtml"
using TestApplicationForFSIN.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d50d91550b36adea2a8c0157b98369f8a1fa09e", @"/Views/Car/Report.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c959e1f8dd50f1f9062e29611fe92de4700a21", @"/Views/_ViewImports.cshtml")]
    public class Views_Car_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestApplicationForFSIN.ViewModels.ReportViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Car\Report.cshtml"
  
    ViewData["Title"] = "Report";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>Всего автомобилей: ");
#nullable restore
#line 6 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Car\Report.cshtml"
                 Write(Model.count_Car);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Из них старше 3 лет: ");
#nullable restore
#line 7 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Car\Report.cshtml"
                   Write(Model.over_three_years_old);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Новее 3 лет: ");
#nullable restore
#line 8 "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Car\Report.cshtml"
           Write(Model.more_than_three_years_old);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestApplicationForFSIN.ViewModels.ReportViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
