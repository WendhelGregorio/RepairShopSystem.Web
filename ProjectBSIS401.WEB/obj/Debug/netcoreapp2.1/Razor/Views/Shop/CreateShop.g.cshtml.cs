#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bbc8ab3c7fc1510c287d3ddf558f0fed88f9070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_CreateShop), @"mvc.1.0.view", @"/Views/Shop/CreateShop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/CreateShop.cshtml", typeof(AspNetCore.Views_Shop_CreateShop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bbc8ab3c7fc1510c287d3ddf558f0fed88f9070", @"/Views/Shop/CreateShop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_CreateShop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.CreateShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg  btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/shop/shop-create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery-3.5.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
  
    Layout = "~/views/shared/_secondaryLayout.cshtml";

#line default
#line hidden
            BeginContext(126, 103, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"section-title mt-5\">\r\n    <h2>Create Shop</h2>\r\n</div>\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(229, 4266, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cdad6ff9ba647318c78994740b87de8", async() => {
                BeginContext(277, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(288, 23, false);
#line 13 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(311, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(321, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5e0c9da4dbe5437ea7d914b1a2a016d9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 14 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(381, 72, true);
                WriteLiteral("\r\n        <div class=\"alert-danger\">\r\n            <h4>\r\n                ");
                EndContext();
                BeginContext(454, 13, false);
#line 17 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
           Write(ViewBag.Error);

#line default
#line hidden
                EndContext();
                BeginContext(467, 129, true);
                WriteLiteral("\r\n            </h4>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <input type=\"hidden\" id=\"UserId\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 596, "\"", 617, 1);
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
WriteAttributeValue("", 604, Model.UserId, 604, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(618, 147, true);
                WriteLiteral(" />\r\n            <span class=\"ml-5 text-success\">Owner:</span>\r\n            <input type=\"text\" class=\"form-control\" id=\"ownerShop\" name=\"OwnerShop\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 765, "\"", 789, 1);
#line 23 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
WriteAttributeValue("", 773, Model.OwnerShop, 773, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(790, 2327, true);
                WriteLiteral(@"/>
        </div>
        <div class=""row"">
            <div class=""col-6"">
                <label for=""businessName"" class=""control-label ml-5 mr-3  mb-1"" id="""">Shop Name</label>
                <input type=""text"" class=""form-control"" id=""businessName"" name=""BusinessName"" aria-describedby=""businessNameHelp"" placeholder=""Enter shop name"">
            </div>

            <div class=""col-6"">
                <label for=""phonenumber"" class=""control-label ml-5 mr-3 mb-1"">Phone Number</label>
                <input type=""text"" class=""form-control"" id=""phoneNumber"" name=""BusinessContact"" aria-describedby=""phoneNumberHelp"" placeholder=""Enter shop phone Number"">

            </div>

        </div>

        <div class=""row"">
            <div class=""col"">
                <label for=""businessEmailAddress"" class=""control-label ml-5 mr-3  mb-1"">Email Address</label>
                <input type=""email"" class=""form-control"" id=""businessEmailAddress"" name=""BusinessEmailAddress"" aria-describedby=""businessEma");
                WriteLiteral(@"ilAddressHelp"" placeholder=""Enter shop email address"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <label for=""businessLocation"" class=""control-label ml-5 mr-3 mb-1"">Shop Location</label>
                <input type=""text"" class=""form-control"" id=""businessLocation"" name=""BusinessLocation"" aria-describedby=""businessLocationHelp"" placeholder=""Enter shop location"">

            </div>
        </div>

        <div class=""row"">
            <div class=""col-4"">
                <label for=""openAt"" class=""control-label ml-5 mr-3  mb-1"">Open Time</label>
                <input type=""text"" class=""form-control"" id=""openAt"" name=""OpenAt"" aria-describedby=""emailAddressHelp"" placeholder=""Enter open time"">

            </div>
            <div class=""col-4"">
                <label for=""closeAt"" class=""control-label ml-5 mr-3 mb-1"">Close Time</label>
                <input type=""text"" class=""form-control"" id=""closeAt"" name=""CloseAt"" aria-described");
                WriteLiteral(@"by=""phoneNumberHelp"" placeholder=""Enter close time"">

            </div>
            <div class=""col-4"">
                <label for=""businessType"" class=""control-label ml-5 mr-4 mb-1"">Type</label>
                <select class=""form-control"" id=""role"" name=""BusinessType"">
");
                EndContext();
#line 67 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                      
                        var options = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType>();

                        foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType option in options)
                        {

#line default
#line hidden
                BeginContext(3478, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(3506, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04cc1690d4ee4a89ae72c796ef8fe297", async() => {
                    BeginContext(3531, 17, false);
#line 72 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                                               Write(option.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 72 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
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
                BeginContext(3557, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                        }
                    

#line default
#line hidden
                BeginContext(3609, 716, true);
                WriteLiteral(@"                </select>
            </div>
        </div>
        <hr />
        <div class=""row"">
            <div class=""col"">
                <label for=""businessDescription"" class=""control-label ml-5 mr-3  mb-1"">Description</label>
                <textarea type=""text"" class=""form-control"" id=""businessDescription"" name=""BusinessDescription"" aria-describedby=""businessDescriptionHelp"" placeholder=""Enter shop desciption""></textarea>

            </div>
        </div>
        <br />
        <div class=""row"">
            <div class=""col-4""> </div>
            <div class=""col-4"">
                <button type=""submit"" id=""submit"" class=""btn btn-lg btn-primary"">Submit</button>
                ");
                EndContext();
                BeginContext(4325, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15dba8c93e674681ba4bb7031484d4d0", async() => {
                    BeginContext(4379, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4389, 99, true);
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-4\">\r\n\r\n            </div>\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4495, 16, true);
            WriteLiteral("\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(4511, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15c2c66af49d4d538155a96de037c973", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4570, 1434, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#submit"").attr('disabled', 'disabled');

        $(""form"").keyup(function () {
            // To Disable Submit Button
            $(""#submit"").attr('disabled', 'disabled');
            // Validating Fields
            var businessName = $(""#businessName"").val();
            var phoneNumber = $(""#phoneNumber"").val();
            var businessEmailAddress = $(""#businessEmailAddress"").val();
            var businessLocation = $(""#businessLocation"").val();
            var openAt = $(""#openAt"").val();
            var closeAt = $(""#closeAt"").val();
            var businessDescription = $(""#businessDescription"").val();
          
            if (!(businessName == """" || phoneNumber == """" || businessEmailAddress == """" || businessLocation == """" || openAt == """" || closeAt == """" || businessDescription == """")) {

                // To Enable Submit Button
                $(""#submit"").removeAttr('disabled');
               ");
            WriteLiteral(@" $(""#submit"").css({
                    ""cursor"": ""pointer"",
                    ""box-shadow"": ""1px 0px 6px #333""
                });

            }
        });
        // On Click Of Submit Button
        $(""#submit"").click(function () {
            $(""#submit"").css({
                ""cursor"": ""default"",
                ""box-shadow"": ""none""
            });

        });
    });


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.shop.CreateShopViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
