#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee1f807198ae2335ec7ce1fa871a669fdd82272a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ShopUpdateProfile), @"mvc.1.0.view", @"/Views/Shop/ShopUpdateProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/ShopUpdateProfile.cshtml", typeof(AspNetCore.Views_Shop_ShopUpdateProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee1f807198ae2335ec7ce1fa871a669fdd82272a", @"/Views/Shop/ShopUpdateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShopUpdateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.ShopUpdateProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/shop/my-dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/shop/shop-update-profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
  
    Layout = null;
    Layout = "~/Views/Shared/_ShopPartialNav.cshtml";

#line default
#line hidden
            BeginContext(152, 129, true);
            WriteLiteral("\r\n\r\n<br /><br /><br />\r\n<div class=\"section-title\">\r\n    <h2>Update Shop</h2>\r\n    <p></p>\r\n</div>\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(281, 3927, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a45b4c7ab89e43dc81d3d4f03b68ee2a", async() => {
                BeginContext(337, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(348, 23, false);
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(371, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(382, 24, false);
#line 16 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(406, 96, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <input type=\"hidden\" id=\"ShopId\" name=\"ShopId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 502, "\"", 523, 1);
#line 19 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 510, Model.ShopId, 510, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(524, 98, true);
                WriteLiteral(" />\r\n\r\n            <label for=\"ownershop\" class=\"form-control mb-1\"><strong>Owner Shop</strong> : ");
                EndContext();
                BeginContext(623, 15, false);
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                                                                                      Write(Model.OwnerShop);

#line default
#line hidden
                EndContext();
                BeginContext(638, 311, true);
                WriteLiteral(@"</label>
        </div>
        <hr />
        <div class=""form-group"">
            <label for=""phonenumber"" class=""control-label ml-5 mr-3 mb-1""><strong>Shop Name</strong></label>
            <input type=""text"" class=""form-control"" id=""businessName"" name=""BusinessName"" aria-describedby=""businessNameHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 949, "\"", 976, 1);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 957, Model.BusinessName, 957, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(977, 326, true);
                WriteLiteral(@" placeholder=""Enter shop name"">

        </div>

        <div class=""form-group"">
            <label for=""phonenumber"" class=""control-label ml-5 mr-3 mb-1""><strong>Phone Number</strong></label>
            <input type=""text"" class=""form-control"" id=""phoneNumber"" name=""BusinessContact"" aria-describedby=""phoneNumberHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1333, 1);
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 1311, Model.BusinessContact, 1311, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1334, 367, true);
                WriteLiteral(@" placeholder=""Enter shop phone Number"">
        </div>

        <div class=""form-group"">
            <label for=""businessEmailAddress"" class=""control-label ml-5 mr-3  mb-1""><strong>Email Address</strong></label>
            <input type=""email"" class=""form-control"" id=""businessEmailAddress"" name=""BusinessEmailAddress"" aria-describedby=""businessEmailAddressHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1701, "\"", 1736, 1);
#line 37 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 1709, Model.BusinessEmailAddress, 1709, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1737, 348, true);
                WriteLiteral(@" placeholder=""Enter shop email address"">
        </div>
        <div class=""form-group"">
            <label for=""businessLocation"" class=""control-label ml-5 mr-3 mb-1""><strong>Shop Location</strong></label>
            <input type=""text"" class=""form-control"" id=""businessLocation"" name=""BusinessLocation"" aria-describedby=""businessLocationHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2085, "\"", 2116, 1);
#line 41 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 2093, Model.BusinessLocation, 2093, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2117, 308, true);
                WriteLiteral(@" placeholder=""Enter shop location"">
        </div>

        <div class=""form-group"">
            <label for=""openAt"" class=""control-label ml-5 mr-3  mb-1""><strong>Open Time</strong></label>
            <input type=""text"" class=""form-control"" id=""openAt"" name=""OpenAt"" aria-describedby=""emailAddressHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2425, "\"", 2446, 1);
#line 46 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 2433, Model.OpenAt, 2433, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2447, 306, true);
                WriteLiteral(@" placeholder=""Enter open time"">
        </div>

        <div class=""form-group"">
            <label for=""closeAt"" class=""control-label ml-5 mr-3 mb-1""><strong>Close Time</strong></label>
            <input type=""text"" class=""form-control"" id=""closeAt"" name=""CloseAt"" aria-describedby=""phoneNumberHelp""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2753, "\"", 2775, 1);
#line 51 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
WriteAttributeValue("", 2761, Model.CloseAt, 2761, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2776, 409, true);
                WriteLiteral(@" placeholder=""Enter close time"">
        </div>
        <hr />

        <div class=""form-group"">
            <label for=""businessDescription"" class=""control-label ml-5 mr-3  mb-1""><strong>Description</strong></label>
            <textarea type=""text"" class=""form-control"" id=""businessDescription"" name=""BusinessDescription"" aria-describedby=""businessDescriptionHelp"" placeholder=""Enter shop desciption"">");
                EndContext();
                BeginContext(3186, 25, false);
#line 57 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                                                                                                                                                                                     Write(Model.BusinessDescription);

#line default
#line hidden
                EndContext();
                BeginContext(3211, 258, true);
                WriteLiteral(@"</textarea>
        </div>
        <hr />
        <div class=""form-group"">
            <label for=""businessType"" class=""control-label ml-5 mr-4 mb-1""><strong>Type</strong></label>
            <select class=""form-control"" id=""role"" name=""BusinessType"">
");
                EndContext();
#line 63 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                  
                    var options = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType>();

                    foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType option in options)
                    {

#line default
#line hidden
                BeginContext(3814, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3838, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94d83be08e9c4328af7c78b996997a59", async() => {
                    BeginContext(3863, 17, false);
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                                           Write(option.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                           WriteLiteral(option);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3889, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 69 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopUpdateProfile.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(3933, 179, true);
                WriteLiteral("            </select>\r\n        </div>\r\n\r\n\r\n        <hr />\r\n        <div class=\"ml-5 mr-3\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(4112, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7d070fc908d437abb406ffce292b260", async() => {
                    BeginContext(4165, 6, true);
                    WriteLiteral("Cancel");
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
                BeginContext(4175, 26, true);
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4208, 14, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.shop.ShopUpdateProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
