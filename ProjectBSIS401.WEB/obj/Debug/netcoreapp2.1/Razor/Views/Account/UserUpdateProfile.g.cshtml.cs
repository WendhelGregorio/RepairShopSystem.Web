#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7eaa42ff6f4aa173739e3c85be51e0e41414a627"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_UserUpdateProfile), @"mvc.1.0.view", @"/Views/Account/UserUpdateProfile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/UserUpdateProfile.cshtml", typeof(AspNetCore.Views_Account_UserUpdateProfile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7eaa42ff6f4aa173739e3c85be51e0e41414a627", @"/Views/Account/UserUpdateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_UserUpdateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.account.UpdateProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/account/update-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-lg btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/account/update-profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registrationForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/account/update-profile-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
  
    ViewData["Title"] = "UserUpdateProfile";

#line default
#line hidden
            BeginContext(122, 222, true);
            WriteLiteral("\r\n\r\n<br /><br /><br /><br />\r\n<hr>\r\n<div class=\"container bootstrap snippet\">\r\n    <div class=\"row\">\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <!--left col-->\r\n\r\n\r\n\r\n\r\n\r\n            ");
            EndContext();
            BeginContext(344, 874, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d154bea827a44a9bbf7e07c3c120b9c", async() => {
                BeginContext(430, 98, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 528, "\"", 549, 1);
#line 23 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
WriteAttributeValue("", 536, Model.UserId, 536, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(550, 94, true);
                WriteLiteral(" />\r\n                    <label for=\"Thumbnail\">Thumbnail:</label><br />\r\n                    ");
                EndContext();
                BeginContext(644, 138, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73c2d9dccc3342a3b5d1f0f2eade43f6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 654, "~/userprofile/users/", 654, 20, true);
#line 25 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
AddHtmlAttributeValue("", 674, WebUser.UserId, 674, 15, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 689, "/thumbnail.png", 689, 14, true);
                AddHtmlAttributeValue(" ", 703, "", 704, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
                BeginContext(782, 161, true);
                WriteLiteral("\r\n                    <input type=\"file\" class=\"form-control\" name=\"thumbnail\" />\r\n                    <h6>Upload a different photo...</h6>\r\n                    ");
                EndContext();
                BeginContext(944, 24, false);
#line 28 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(968, 243, true);
                WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    <div class=\"col-md-10\">\r\n                        <input type=\"submit\" value=\"Upload\" />\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1218, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(1573, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1847, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2521, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2950, 207, true);
            WriteLiteral("\r\n        </div><!--/col-3-->\r\n        <div class=\"col-sm-9\">\r\n\r\n            <div class=\"tab-content\">\r\n                <div class=\"tab-pane active\" id=\"home\">\r\n                    <hr>\r\n                    ");
            EndContext();
            BeginContext(3157, 3664, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "014320dbc7dc4efea09428ecde26c7e1", async() => {
                BeginContext(3246, 80, true);
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            ");
                EndContext();
                BeginContext(3327, 23, false);
#line 76 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3350, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3381, 24, false);
#line 77 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(3405, 92, true);
                WriteLiteral("\r\n                        </div>\r\n                        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3497, "\"", 3518, 1);
#line 79 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
WriteAttributeValue("", 3505, Model.UserId, 3505, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3519, 286, true);
                WriteLiteral(@" />

                        <div class=""form-group"">

                            <div class=""col-xs-6"">

                                <label for=""first_name""><h4>First name</h4></label>
                                <input type=""text"" class=""form-control"" name=""FirstName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3805, "\"", 3829, 1);
#line 86 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
WriteAttributeValue("", 3813, Model.FirstName, 3813, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3830, 424, true);
                WriteLiteral(@" id=""first_name"" placeholder=""first name"" title=""enter your first name if any."">
                            </div>
                        </div>
                        <div class=""form-group"">

                            <div class=""col-xs-6"">
                                <label for=""last_name""><h4>Last name</h4></label>
                                <input type=""text"" class=""form-control"" name=""LastName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4254, "\"", 4277, 1);
#line 93 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
WriteAttributeValue("", 4262, Model.LastName, 4262, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4278, 418, true);
                WriteLiteral(@" id=""last_name"" placeholder=""last name"" title=""enter your last name if any."">
                            </div>
                        </div>

                        <div class=""form-group"">

                            <div class=""col-xs-6"">
                                <label for=""phone""><h4>Phone</h4></label>
                                <input type=""text"" class=""form-control"" name=""PhoneNumber""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4696, "\"", 4722, 1);
#line 101 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
WriteAttributeValue("", 4704, Model.PhoneNumber, 4704, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4723, 428, true);
                WriteLiteral(@" id=""phone"" placeholder=""enter phone"" title=""enter your phone number if any."">
                            </div>
                        </div>

                        <div class=""form-group"">

                            <div class=""col-xs-6"">
                                <label for=""phone""><h4>Gender</h4></label>
                                <select class=""form-control col-xs-6"" id=""gender"" name=""Gender"">
");
                EndContext();
#line 110 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                      
                                        var genderOptions = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.Gender)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.Gender>();

                                        foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.Gender genderOption in genderOptions)
                                        {
                                            if (Model.Gender == genderOption)
                                            {

#line default
#line hidden
                BeginContext(5702, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(5750, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702f54f4991d479d85ac5360d9e9d92b", async() => {
                    BeginContext(5790, 23, false);
#line 117 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                                                                  Write(genderOption.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 117 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                                   WriteLiteral(genderOption);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5822, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 118 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
                BeginContext(5968, 48, true);
                WriteLiteral("                                                ");
                EndContext();
                BeginContext(6016, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1c8a624bbac47dbb8010e5b951c5848", async() => {
                    BeginContext(6047, 23, false);
#line 121 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                                                         Write(genderOption.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 121 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                                   WriteLiteral(genderOption);

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
                BeginContext(6079, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 122 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
                                            }
                                        }
                                    

#line default
#line hidden
                BeginContext(6210, 432, true);
                WriteLiteral(@"                                </select>
                            </div>
                        </div>


                        <div class=""form-group"">
                            <div class=""col-xs-12"">
                                <br>
                                <button class=""btn btn-lg btn-success"" type=""submit""><i class=""glyphicon glyphicon-ok-sign""></i> Save</button>
                                ");
                EndContext();
                BeginContext(6642, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "beee1ad87c764586b3b2f0ea218a799b", async() => {
                    BeginContext(6716, 4, true);
                    WriteLiteral("Back");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 6651, "~/account/profile/", 6651, 18, true);
#line 134 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
AddHtmlAttributeValue("", 6669, WebUser.UserId, 6669, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6724, 90, true);
                WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6821, 674, true);
            WriteLiteral(@"

                    <hr>

                </div>

            </div><!--/tab-pane-->
        </div><!--/tab-content-->
    </div><!--/col-9-->
</div><!--/row-->
<!--MODAL-->
<div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-update-profile-image"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Update Profile Image</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            ");
            EndContext();
            BeginContext(7495, 561, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aba0f689c9684a8f919d807ac47cf6e5", async() => {
                BeginContext(7585, 145, true);
                WriteLiteral("\r\n                <div class=\"modal-body\">\r\n                    <input type=\"file\" class=\"form-control\" name=\"ImageFile\" />\r\n                    ");
                EndContext();
                BeginContext(7731, 24, false);
#line 160 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Views\Account\UserUpdateProfile.cshtml"
               Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(7755, 294, true);
                WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-success"">Update</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8056, 164, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script>\r\n    function updateProfileImage() {\r\n        $(\"#modal-update-profile-image\").modal(\"show\");\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.account.UpdateProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
