#pragma checksum "C:\JYStudy\DevCore\DotNetNote\Views\FormValidationDemo\HtmlProcess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f4ad6558098788805725226aef5f34d63d9d0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FormValidationDemo_HtmlProcess), @"mvc.1.0.view", @"/Views/FormValidationDemo/HtmlProcess.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FormValidationDemo/HtmlProcess.cshtml", typeof(AspNetCore.Views_FormValidationDemo_HtmlProcess))]
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
#line 1 "C:\JYStudy\DevCore\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote;

#line default
#line hidden
#line 2 "C:\JYStudy\DevCore\DotNetNote\Views\_ViewImports.cshtml"
using DotNetNote.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f4ad6558098788805725226aef5f34d63d9d0d", @"/Views/FormValidationDemo/HtmlProcess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0daafac8a85ee43e3c34bc74f0c87c74269b2818", @"/Views/_ViewImports.cshtml")]
    public class Views_FormValidationDemo_HtmlProcess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\JYStudy\DevCore\DotNetNote\Views\FormValidationDemo\HtmlProcess.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(150, 12, true);
            WriteLiteral("\r\n전달된 데이터 : ");
            EndContext();
            BeginContext(163, 20, false);
#line 8 "C:\JYStudy\DevCore\DotNetNote\Views\FormValidationDemo\HtmlProcess.cshtml"
     Write(ViewBag.resultString);

#line default
#line hidden
            EndContext();
            BeginContext(183, 2, true);
            WriteLiteral("\r\n");
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
