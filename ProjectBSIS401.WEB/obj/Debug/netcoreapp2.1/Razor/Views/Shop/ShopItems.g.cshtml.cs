#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87ea80b081444aa9981c2161511be0c5cb7afd7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_ShopItems), @"mvc.1.0.view", @"/Views/Shop/ShopItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/ShopItems.cshtml", typeof(AspNetCore.Views_Shop_ShopItems))]
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87ea80b081444aa9981c2161511be0c5cb7afd7a", @"/Views/Shop/ShopItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShopItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.ShopItemsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px; height:75px;border-radius: 50%; border: 1px solid #9fc0d8;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/feedback/shop-feedbacks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:820px;height:260px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
  
    ViewData["Title"] = "ShopItems";

#line default
#line hidden
            BeginContext(164, 94, true);
            WriteLiteral(">\r\n\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
             if (Model.Shop.BusinessName.Length <= 30)
            {

#line default
#line hidden
            BeginContext(329, 56, true);
            WriteLiteral("                <h6 class=\"logo me-auto float-lg-start\">");
            EndContext();
            BeginContext(385, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4f9ddaa7f18b45659592dd242aecf363", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 395, "~/image/shops/logo/", 395, 19, true);
#line 14 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 414, Model.Shop.Id, 414, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 428, "/logo.png", 428, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 23, false);
#line 14 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                                                                                                                                          Write(Model.Shop.BusinessName);

#line default
#line hidden
            EndContext();
            BeginContext(544, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(599, 89, true);
            WriteLiteral("                <h6><strong>Shop name is less than equal to 20 characters</strong></h6>\r\n");
            EndContext();
#line 19 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
            }

#line default
#line hidden
            BeginContext(703, 48, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-3\">\r\n");
            EndContext();
#line 22 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
             if (!WebUser.IsUserLogggedIn() == true)
            {

#line default
#line hidden
            BeginContext(820, 42, true);
            WriteLiteral("                <div class=\"list-group\">\r\n");
            EndContext();
            BeginContext(1343, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 29 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1417, 42, true);
            WriteLiteral("                <div class=\"list-group\">\r\n");
            EndContext();
            BeginContext(1594, 403, true);
            WriteLiteral(@"                    <ol class=""list-group list-group-numbered"">
                        <li class=""list-group-item d-flex justify-content-between align-items-start"">
                            <div class=""ms-2 me-auto"">
                                <div class=""fw-bold"">Comments</div>

                            </div>
                            <span class=""badge bg-primary rounded-pill"">");
            EndContext();
            BeginContext(1998, 19, false);
#line 41 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                   Write(Model.Shop.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(2017, 375, true);
            WriteLiteral(@"</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-start"">
                            <div class=""ms-2 me-auto"">
                                <div class=""fw-bold"">Likes</div>

                            </div>
                            <span class=""badge bg-primary rounded-pill"">");
            EndContext();
            BeginContext(2393, 16, false);
#line 48 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                   Write(Model.Shop.Likes);

#line default
#line hidden
            EndContext();
            BeginContext(2409, 376, true);
            WriteLiteral(@"</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between align-items-start"">
                            <div class=""ms-2 me-auto"">
                                <div class=""fw-bold"">Rating</div>

                            </div>
                            <span class=""badge bg-primary rounded-pill"">");
            EndContext();
            BeginContext(2786, 31, false);
#line 55 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                   Write(Model.Shop.Rating.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(2817, 254, true);
            WriteLiteral("</span>\r\n                        </li>\r\n\r\n                        <li class=\"list-group-item d-flex justify-content-between align-items-start\">\r\n                            <div class=\"ms-2 me-auto\">\r\n                                <div class=\"fw-bold\">");
            EndContext();
            BeginContext(3071, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a911fcfb0705474db943a3b233f5adce", async() => {
                BeginContext(3128, 7, true);
                WriteLiteral("Chat Us");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3080, "~/chats/create-private-room/", 3080, 28, true);
#line 60 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 3108, Model.Shop.UserId, 3108, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3139, 384, true);
            WriteLiteral(@"</div>

                            </div>
                        </li>
                    </ol>
                    <a href=""#collapseExample"" data-bs-toggle=""collapse"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"" class=""list-group-item active-list"">Feedback</a>
                    <div class=""collapse"" id=""collapseExample"">
                        ");
            EndContext();
            BeginContext(3523, 2631, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1f6d36b061e484889cb41b9628977d4", async() => {
                BeginContext(3578, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3609, 23, false);
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3632, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3663, 24, false);
#line 69 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(3687, 122, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3809, "\"", 3840, 1);
#line 71 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
WriteAttributeValue("", 3817, WebIDS.GetPublicUserId, 3817, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3841, 71, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"ShopId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3912, "\"", 3933, 1);
#line 72 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
WriteAttributeValue("", 3920, Model.ShopId, 3920, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3934, 1276, true);
                WriteLiteral(@" />
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"" for=""FullName"">Fullname</label>
                                <input class=""form-control"" type=""text"" name=""FullName"" size=""28"" placeholder=""Your fullname"" />
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"" for=""Email"">Email-address</label>
                                <input class=""form-control"" type=""email"" name=""Email"" size=""28"" placeholder=""Your email-address"" />
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"" for=""Comment"">Comment</label>
                                <textarea class=""form-control"" type=""text"" name=""Comment"" placeholder=""Your comment"" rows=""10"" cols=""29""></textarea>
                            </div>

                         ");
                WriteLiteral("   <div class=\"form-check-inline  col-lg-12\">\r\n                                <label for=\"businessType\" class=\"control-label ml-5 mr-4 mb-1\">Rating-Star</label>\r\n                                <select class=\"form-control\" id=\"rating\" name=\"Rating\">\r\n");
                EndContext();
#line 90 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                      
                                        var options = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber>();

                                        foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber option in options)
                                        {

#line default
#line hidden
                BeginContext(5635, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(5679, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9db8933118bc445aaab576e43c72be70", async() => {
                    BeginContext(5704, 17, false);
#line 95 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                               Write(option.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 95 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
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
                BeginContext(5730, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                        }
                                    

#line default
#line hidden
                BeginContext(5814, 333, true);
                WriteLiteral(@"                                </select>
                            </div>

                            <div class=""form-group mt-2"">
                                <button type=""submit"" class=""btn btn-success"">Send</button>

                            </div>
                            <hr />

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6154, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
            BeginContext(6272, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
#line 111 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
          
            }

#line default
#line hidden
            BeginContext(6323, 104, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <!-- /.col-lg-3 -->\r\n     \r\n\r\n\r\n        <div class=\"col-lg-9\">\r\n            ");
            EndContext();
            BeginContext(6427, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3572cd77f4144a53ae9bb52664ef8028", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6463, "~/image/shops/banner/", 6463, 21, true);
#line 121 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 6484, Model.ShopId, 6484, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 6497, "/banner.png", 6497, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6562, 53, true);
            WriteLiteral("\r\n            <br />\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 124 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                 foreach (ShopService shopService in Model.ShopServices)
                {

#line default
#line hidden
            BeginContext(6708, 108, true);
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                        <div class=\"card h-100\">\r\n");
            EndContext();
            BeginContext(6928, 180, true);
            WriteLiteral("                            <div class=\"card-body\">\r\n                                \r\n                                <h4 class=\"card-title\">\r\n                                    ");
            EndContext();
            BeginContext(7108, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca954e9ea121415d9d4980c66a116c26", async() => {
                BeginContext(7179, 19, false);
#line 132 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                                                     Write(shopService.Service);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7117, "~/shop/shop-public-items-info/", 7117, 30, true);
#line 132 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 7147, shopService.Id, 7147, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 7162, "/", 7162, 1, true);
#line 132 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 7163, Model.ShopId, 7163, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7202, 79, true);
            WriteLiteral("\r\n\r\n                                </h4>\r\n                                <h5>");
            EndContext();
            BeginContext(7282, 31, false);
#line 135 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                               Write(shopService.Price.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(7313, 60, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
            EndContext();
            BeginContext(7374, 23, false);
#line 136 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                Write(shopService.Description);

#line default
#line hidden
            EndContext();
            BeginContext(7397, 182, true);
            WriteLiteral("</p>\r\n                                <div>\r\n\r\n                                </div>\r\n\r\n                            </div>  \r\n                            <div class=\"card-footer\">\r\n");
            EndContext();
#line 143 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                 if (!WebUser.IsUserLogggedIn() == true)
                                {

#line default
#line hidden
            BeginContext(7688, 48, true);
            WriteLiteral("                                    <p>...</p>\r\n");
            EndContext();
#line 146 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(7844, 43, true);
            WriteLiteral("                                    <span> ");
            EndContext();
            BeginContext(7887, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983d12eaafa64090b6e40fb4d37912fe", async() => {
                BeginContext(7976, 47, true);
                WriteLiteral("Book-Services &nbsp;<i class=\"fas fa-plus\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7896, "~/booking/book-costumer/", 7896, 24, true);
#line 149 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 7920, Model.Shop.Id, 7920, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 7934, "/", 7934, 1, true);
#line 149 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 7935, WebIDS.GetPublicUserId, 7935, 23, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 7958, "/", 7958, 1, true);
#line 149 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 7959, shopService.Id, 7959, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8027, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 150 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                }

#line default
#line hidden
            BeginContext(8071, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 155 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                }

#line default
#line hidden
            BeginContext(8188, 145, true);
            WriteLiteral("\r\n            </div>\r\n            <!-- /.row -->\r\n\r\n        </div>\r\n        <!-- /.col-lg-9 -->\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(9978, 152, true);
            WriteLiteral("<script>\r\n    $(\"#booking\").click(function () {\r\n        alert(\"Login your account to activate booking.\");\r\n\r\n    });\r\n</script>\r\n<style>\r\n   \r\n</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.shop.ShopItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
