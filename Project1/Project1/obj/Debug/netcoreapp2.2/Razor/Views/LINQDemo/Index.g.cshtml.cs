#pragma checksum "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\LINQDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9402fc779043c3cc5c2e08d7a5b3cbda8a2ded1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LINQDemo_Index), @"mvc.1.0.view", @"/Views/LINQDemo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LINQDemo/Index.cshtml", typeof(AspNetCore.Views_LINQDemo_Index))]
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
#line 1 "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\_ViewImports.cshtml"
using Project1;

#line default
#line hidden
#line 2 "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\_ViewImports.cshtml"
using Project1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9402fc779043c3cc5c2e08d7a5b3cbda8a2ded1", @"/Views/LINQDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f8a1206ad760d99a32967ca6cf008da4df4ac8e", @"/Views/_ViewImports.cshtml")]
    public class Views_LINQDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 12, true);
            WriteLiteral("\r\n\r\n<ul>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\LINQDemo\Index.cshtml"
     foreach (var d in ViewBag.Data)
    {

#line default
#line hidden
            BeginContext(177, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(190, 1, false);
#line 9 "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\LINQDemo\Index.cshtml"
       Write(d);

#line default
#line hidden
            EndContext();
            BeginContext(191, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\Rahul Kumar\source\repos\ShiwangiProjects\Project1\Project1\Views\LINQDemo\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(205, 5, true);
            WriteLiteral("</ul>");
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
