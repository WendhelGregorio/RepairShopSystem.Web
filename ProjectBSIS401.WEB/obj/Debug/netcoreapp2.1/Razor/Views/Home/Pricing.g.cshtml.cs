#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de4ff37cd424b3c57718665fd7d091e9c7b22bab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pricing), @"mvc.1.0.view", @"/Views/Home/Pricing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Pricing.cshtml", typeof(AspNetCore.Views_Home_Pricing))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de4ff37cd424b3c57718665fd7d091e9c7b22bab", @"/Views/Home/Pricing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pricing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.home.PricingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/contact"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-buy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
  
    ViewData["Title"] = "Pricing";

#line default
#line hidden
            BeginContext(103, 214, true);
            WriteLiteral("\r\n\r\n<!-- ======= Pricing Section ======= -->\r\n<section id=\"pricing\" class=\"pricing section-bg\">\r\n    <div class=\"container\" data-aos=\"fade-up\">\r\n\r\n        <div class=\"section-title\">\r\n            <h2>Pricing</h2>\r\n");
            EndContext();
            BeginContext(536, 45, true);
            WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 17 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
             foreach (var item in Model.Pricings)
            {

#line default
#line hidden
            BeginContext(647, 165, true);
            WriteLiteral("                <div class=\"col-lg-4 col-md-6\">\r\n                    <div class=\"box Box-Body\" data-aos=\"fade-up\" data-aos-delay=\"100\">\r\n                        <h3>");
            EndContext();
            BeginContext(813, 10, false);
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(823, 82, true);
            WriteLiteral("</h3>\r\n                        <h4>\r\n                            <sup>&#8369</sup>");
            EndContext();
            BeginContext(906, 24, false);
#line 23 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                                        Write(item.Price.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(930, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 24 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                             if (item.Month > 1)
                            {

#line default
#line hidden
            BeginContext(1013, 41, true);
            WriteLiteral("                                <span> / ");
            EndContext();
            BeginContext(1055, 10, false);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                                    Write(item.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1065, 16, true);
            WriteLiteral(" Months</span>\r\n");
            EndContext();
#line 27 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1177, 41, true);
            WriteLiteral("                                <span> / ");
            EndContext();
            BeginContext(1219, 10, false);
#line 30 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                                    Write(item.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 15, true);
            WriteLiteral(" Month</span>\r\n");
            EndContext();
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                            }

#line default
#line hidden
            BeginContext(1275, 31, true);
            WriteLiteral("                        </h4>\r\n");
            EndContext();
#line 33 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                         foreach (var content in item.PricingContents)
                        {

#line default
#line hidden
            BeginContext(1405, 70, true);
            WriteLiteral("                            <ul>\r\n                                <li>");
            EndContext();
            BeginContext(1476, 15, false);
#line 36 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                               Write(content.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 44, true);
            WriteLiteral("</li>\r\n\r\n                            </ul>\r\n");
            EndContext();
#line 39 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"
                        }

#line default
#line hidden
            BeginContext(1562, 78, true);
            WriteLiteral("\r\n                        <div class=\"btn-wrap\">\r\n                            ");
            EndContext();
            BeginContext(1640, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c3b6f85c56b4d0190f6376b42ea676a", async() => {
                BeginContext(1681, 10, true);
                WriteLiteral("Contact Us");
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
            BeginContext(1695, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Home\Pricing.cshtml"

            }

#line default
#line hidden
            BeginContext(1798, 163, true);
            WriteLiteral("\r\n\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Pricing Section -->\r\n\r\n\r\n\r\n<style>\r\n    .Box-Body:hover {\r\n        background-color: #8B0000;\r\n    }\r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.home.PricingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
