#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4c0df885870d8732b8d87dfd05d7effdad75fe"
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
#line 1 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB;

#line default
#line hidden
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Models;

#line default
#line hidden
#line 3 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

#line default
#line hidden
#line 4 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;

#line default
#line hidden
#line 5 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\_ViewImports.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd4c0df885870d8732b8d87dfd05d7effdad75fe", @"/Views/Shop/CreateShop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_CreateShop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.CreateShopViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/home/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/shop/shop-create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
  
    ViewData["Title"] = "CreateShop";

#line default
#line hidden
            BeginContext(109, 33, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(142, 3710, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa8b894f33b640ed9e669e2b7adb6440", async() => {
                BeginContext(190, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(201, 23, false);
#line 9 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(224, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(235, 24, false);
#line 10 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
   Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(259, 38, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n");
                EndContext();
                BeginContext(386, 149, true);
                WriteLiteral("            <span class=\"ml-5 text-success\">Owner:</span>\r\n            <label for=\"ownershop\" class=\"control-label ml-5 mr-3  mb-1\" name=\"OwnerShop\">");
                EndContext();
                BeginContext(536, 16, false);
#line 15 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                                                                                     Write(WebUser.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(552, 10, true);
                WriteLiteral("</label>\r\n");
                EndContext();
                BeginContext(678, 2442, true);
                WriteLiteral(@"        </div>
        <hr />
        <div class=""form-check-inline"">
            <label for=""businessName"" class=""control-label ml-5 mr-3  mb-1"" id="""">Shop Name</label>
            <input type=""text"" class=""form-control"" id=""businessName"" name=""BusinessName"" aria-describedby=""businessNameHelp"" placeholder=""Enter shop name"">

            <label for=""phonenumber"" class=""control-label ml-5 mr-3 mb-1"">Phone Number</label>
            <input type=""text"" class=""form-control"" id=""phoneNumber"" name=""BusinessContact"" aria-describedby=""phoneNumberHelp"" placeholder=""Enter shop phone Number"">

        </div>
        <hr />
        <div class=""form-check-inline"">
            <label for=""businessEmailAddress"" class=""control-label ml-5 mr-3  mb-1"">Email Address</label>
            <input type=""email"" class=""form-control"" id=""businessEmailAddress"" name=""BusinessEmailAddress"" aria-describedby=""businessEmailAddressHelp"" placeholder=""Enter shop email address"">

            <label for=""businessLocation"" class=""co");
                WriteLiteral(@"ntrol-label ml-5 mr-3 mb-1"">Shop Location</label>
            <input type=""text"" class=""form-control"" id=""businessLocation"" name=""BusinessLocation"" aria-describedby=""businessLocationHelp"" placeholder=""Enter shop location"">

        </div>
        <hr />
        <div class=""form-check-inline"">
            <label for=""openAt"" class=""control-label ml-5 mr-3  mb-1"">Open Time</label>
            <input type=""text"" class=""form-control"" id=""openAt"" name=""OpenAt"" aria-describedby=""emailAddressHelp"" placeholder=""Enter open time"">

            <label for=""closeAt"" class=""control-label ml-5 mr-3 mb-1"">Close Time</label>
            <input type=""text"" class=""form-control"" id=""closeAt"" name=""CloseAt"" aria-describedby=""phoneNumberHelp"" placeholder=""Enter close time"">

        </div>
        <hr />

        <div class=""form-check-inline col-lg-11"">
            <label for=""businessDescription"" class=""control-label ml-5 mr-3  mb-1"">Description</label>
            <textarea type=""text"" class=""form-control"" id=");
                WriteLiteral(@"""businessDescription"" name=""BusinessDescription"" aria-describedby=""businessDescriptionHelp"" placeholder=""Enter shop desciption""></textarea>

 

        </div>
        <hr />
        <div class=""form-check-inline  col-lg-11"">
            <label for=""businessType"" class=""control-label ml-5 mr-4 mb-1"">Type</label>
            <select class=""form-control"" id=""role"" name=""BusinessType"">
");
                EndContext();
#line 58 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                  
                    var options = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType>();

                    foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.BusinessType option in options)
                    {

#line default
#line hidden
                BeginContext(3465, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(3489, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8c30c206194963a87d855632d86c90", async() => {
                    BeginContext(3514, 17, false);
#line 63 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                                           Write(option.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 63 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
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
                BeginContext(3540, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 64 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Shop\CreateShop.cshtml"
                    }
                

#line default
#line hidden
                BeginContext(3584, 179, true);
                WriteLiteral("            </select>\r\n        </div>\r\n\r\n\r\n        <hr />\r\n        <div class=\"ml-5 mr-3\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n            ");
                EndContext();
                BeginContext(3763, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d0936a8ffdd469c9ee0e57c2a7bb83c", async() => {
                    BeginContext(3809, 6, true);
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
                BeginContext(3819, 26, true);
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
            BeginContext(3852, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
