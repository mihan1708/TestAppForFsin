#pragma checksum "C:\Users\Михаил\source\repos\TestApplicationForFSIN\TestApplicationForFSIN\Views\Shared\_dateTimePicker.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c483e34dff1a5e3fedb93690d37ad0c756ef95e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__dateTimePicker), @"mvc.1.0.view", @"/Views/Shared/_dateTimePicker.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c483e34dff1a5e3fedb93690d37ad0c756ef95e", @"/Views/Shared/_dateTimePicker.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c959e1f8dd50f1f9062e29611fe92de4700a21", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__dateTimePicker : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""form-group"">
    <div class=""input-group"" id=""datetimepicker"">
        <input type=""text"" class=""form-control"" />
        <span class=""input-group-addon"">
            <span class=""glyphicon glyphicon-calendar""></span>
        </span>
    </div>
    <script type=""text/javascript"">
        $(function () {
            $('#datetimepicker').datetimepicker();
        });
    </script>
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
