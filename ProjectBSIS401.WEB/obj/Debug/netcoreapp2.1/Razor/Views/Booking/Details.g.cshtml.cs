#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15ec0d00439e58d897e90b5f23a66f5a287e57fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Details), @"mvc.1.0.view", @"/Views/Booking/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Booking/Details.cshtml", typeof(AspNetCore.Views_Booking_Details))]
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
#line 1 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB;

#line default
#line hidden
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Models;

#line default
#line hidden
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

#line default
#line hidden
#line 4 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;

#line default
#line hidden
#line 5 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15ec0d00439e58d897e90b5f23a66f5a287e57fe", @"/Views/Booking/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/shop/my-dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(108, 202, true);
            WriteLiteral("\r\n<br /><br /><br />\r\n<div class=\"section-title\">\r\n    <h2>Details</h2>\r\n    <p></p>\r\n</div>\r\n\r\n<div>\r\n    <h4>Booking</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(311, 44, false);
#line 17 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(355, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(417, 40, false);
#line 20 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(457, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(520, 43, false);
#line 24 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(563, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(625, 39, false);
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(664, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(727, 49, false);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
            EndContext();
            BeginContext(776, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(838, 45, false);
#line 34 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.ContactNumber));

#line default
#line hidden
            EndContext();
            BeginContext(883, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(946, 57, false);
#line 38 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdditionalDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1065, 53, false);
#line 41 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdditionalDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 129, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            Time\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1248, 41, false);
#line 49 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Booking\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedAt));

#line default
#line hidden
            EndContext();
            BeginContext(1289, 53, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<div>\r\n        ");
            EndContext();
            BeginContext(1342, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4cd1ee0a74148318a161f513345ab43", async() => {
                BeginContext(1395, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1411, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
