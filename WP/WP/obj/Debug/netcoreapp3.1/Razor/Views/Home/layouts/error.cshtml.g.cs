#pragma checksum "C:\Users\julyan97\source\repos\FormCreator\Form-Creation-and-Submition\WP\WP\Views\Home\layouts\error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "094f9cb76290c2865b2e0053925fe7336a17bcc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_layouts_error), @"mvc.1.0.view", @"/Views/Home/layouts/error.cshtml")]
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
#line 1 "C:\Users\julyan97\source\repos\FormCreator\Form-Creation-and-Submition\WP\WP\Views\_ViewImports.cshtml"
using WP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julyan97\source\repos\FormCreator\Form-Creation-and-Submition\WP\WP\Views\_ViewImports.cshtml"
using WP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"094f9cb76290c2865b2e0053925fe7336a17bcc7", @"/Views/Home/layouts/error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9597895a032905b3b0726a7c75cc932843c0578e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_layouts_error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("extends layout\n\nblock content\n  h1= message\n  h2= error.status\n  pre #{error.stack}\n");
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