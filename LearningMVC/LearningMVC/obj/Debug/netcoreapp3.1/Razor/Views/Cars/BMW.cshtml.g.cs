#pragma checksum "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\Cars\BMW.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7977ca8d3089705d9f81e7490376cd4362c72ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_BMW), @"mvc.1.0.view", @"/Views/Cars/BMW.cshtml")]
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
#line 1 "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\_ViewImports.cshtml"
using LearningMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\_ViewImports.cshtml"
using LearningMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7977ca8d3089705d9f81e7490376cd4362c72ba", @"/Views/Cars/BMW.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f47c274be69b8773dfa5a01a5c6de8ac648238", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_BMW : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>This is BMW </h4>\r\n\r\n\r\n");
#nullable restore
#line 6 "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\Cars\BMW.cshtml"
 foreach (string item in Model)
{
    //<div>@item</div>
    //<p>@item</p>
    //<href>@item</href>

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5>");
#nullable restore
#line 11 "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\Cars\BMW.cshtml"
   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 12 "C:\Users\WindowsPC\source\repos\LearningMVC\LearningMVC\Views\Cars\BMW.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
