#pragma checksum "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\Home\Eliminado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d483febe896a5ed923bae29854d480ede4ed21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Eliminado), @"mvc.1.0.view", @"/Views/Home/Eliminado.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\_ViewImports.cshtml"
using FrontendTasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\_ViewImports.cshtml"
using FrontendTasks.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\Home\Eliminado.cshtml"
using FrontendTasks.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d483febe896a5ed923bae29854d480ede4ed21a", @"/Views/Home/Eliminado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42b67032c47ea3a7eb33e5f0986780a163e68cc8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Eliminado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\Home\Eliminado.cshtml"
  
    if ( @ViewBag.result=="true")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">Eliminado Correctamente!</h1>\r\n        </div>\r\n");
#nullable restore
#line 8 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\Home\Eliminado.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">No pudo ser Eliminado!</h1>\r\n        </div>\r\n");
#nullable restore
#line 15 "C:\Users\Usuario\Desktop\TECNICA\FrontendTaskC-\Views\Home\Eliminado.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
