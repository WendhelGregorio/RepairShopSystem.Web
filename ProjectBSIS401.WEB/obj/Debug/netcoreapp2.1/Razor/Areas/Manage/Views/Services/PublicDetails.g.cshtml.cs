#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77edc1ea693b15b2f0ac0e1eb5f3301df91e2b10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_PublicDetails), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/PublicDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Services/PublicDetails.cshtml", typeof(AspNetCore.Areas_Manage_Views_Services_PublicDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77edc1ea693b15b2f0ac0e1eb5f3301df91e2b10", @"/Areas/Manage/Views/Services/PublicDetails.cshtml")]
    public class Areas_Manage_Views_Services_PublicDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Service>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml"
  
    Layout = "~/views/shared/_layout.cshtml";

#line default
#line hidden
            BeginContext(119, 181, true);
            WriteLiteral("<div class=\"section-title\">\r\n    <h2>Details</h2>\r\n    <p></p>\r\n</div>\r\n\r\n<div>\r\n    <h4>Services</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(301, 40, false);
#line 15 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(341, 63, true);
            WriteLiteral(" :\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(405, 36, false);
#line 18 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(441, 69, true);
            WriteLiteral("\r\n        </dd>\r\n       \r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(511, 47, false);
#line 22 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(558, 62, true);
            WriteLiteral(":\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(621, 43, false);
#line 25 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Services\PublicDetails.cshtml"
       Write(Html.DisplayFor(model => model.ServiceType));

#line default
#line hidden
            EndContext();
            BeginContext(664, 45, true);
            WriteLiteral("\r\n        </dd>\r\n       \r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Service> Html { get; private set; }
    }
}
#pragma warning restore 1591