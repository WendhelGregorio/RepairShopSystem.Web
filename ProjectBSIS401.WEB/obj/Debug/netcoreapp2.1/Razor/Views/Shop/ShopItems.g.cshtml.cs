#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a599e2b5fdf11ebbcf6c2419738c39dbfe5aed1a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a599e2b5fdf11ebbcf6c2419738c39dbfe5aed1a", @"/Views/Shop/ShopItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_ShopItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.ShopIdViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:75px; height:75px;border-radius: 50%; border: 1px solid #9fc0d8;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item active-list"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/feedback/shop-feedbacks"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:820px;height:260px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(161, 94, true);
            WriteLiteral(">\r\n\r\n<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 12 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
             if (Model.Shop.BusinessName.Length <= 20)
            {

#line default
#line hidden
            BeginContext(326, 56, true);
            WriteLiteral("                <h6 class=\"logo me-auto float-lg-start\">");
            EndContext();
            BeginContext(382, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2570adbf21fb4e6aa65fa31963cf7e7a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 392, "~/image/shops/logo/", 392, 19, true);
#line 14 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 411, Model.Shop.Id, 411, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 425, "/logo.png", 425, 9, true);
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
            BeginContext(518, 23, false);
#line 14 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                                                                                                                                          Write(Model.Shop.BusinessName);

#line default
#line hidden
            EndContext();
            BeginContext(541, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(596, 89, true);
            WriteLiteral("                <h6><strong>Shop name is less than equal to 20 characters</strong></h6>\r\n");
            EndContext();
#line 19 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
            }

#line default
#line hidden
            BeginContext(700, 48, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-lg-3\">\r\n");
            EndContext();
#line 22 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
             if (!WebUser.IsUserLogggedIn() == true)
            {

#line default
#line hidden
            BeginContext(817, 539, true);
            WriteLiteral(@"                <div class=""list-group"">
                    <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Login to activate booking"" class=""list-group-item"">Booking</a>
                    <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Login to activate feedback"" class=""list-group-item "">Feedback</a>
                    <a href=""#"" data-bs-toggle=""tooltip"" data-bs-placement=""left"" title=""Login to activate and message us"" class=""list-group-item "">Message-Us</a>
                </div>
");
            EndContext();
#line 29 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"

            }
            else
            {

#line default
#line hidden
            BeginContext(1406, 62, true);
            WriteLiteral("                <div class=\"list-group\">\r\n                    ");
            EndContext();
            BeginContext(1468, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b52b7c9cef8456dadc5894292c1d174", async() => {
                BeginContext(1566, 7, true);
                WriteLiteral("Booking");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1477, "~/booking/book-costumer/", 1477, 24, true);
#line 34 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 1501, Model.ShopId, 1501, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1514, "/", 1514, 1, true);
#line 34 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 1515, Model.UserId, 1515, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1577, 282, true);
            WriteLiteral(@"
                    <a href=""#collapseExample"" data-bs-toggle=""collapse"" role=""button"" aria-expanded=""false"" aria-controls=""collapseExample"" class=""list-group-item active-list"">Feedback</a>
                    <div class=""collapse"" id=""collapseExample"">
                        ");
            EndContext();
            BeginContext(1859, 2621, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b393e9f9f9e64206a439b8b9f82eb5ca", async() => {
                BeginContext(1914, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1945, 23, false);
#line 38 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(1968, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1999, 24, false);
#line 39 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                       Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(2023, 122, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2145, "\"", 2166, 1);
#line 41 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
WriteAttributeValue("", 2153, Model.UserId, 2153, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2167, 71, true);
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"ShopId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2238, "\"", 2259, 1);
#line 42 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
WriteAttributeValue("", 2246, Model.ShopId, 2246, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2260, 1276, true);
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
#line 60 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                      
                                        var options = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber>();

                                        foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.RatingNumber option in options)
                                        {

#line default
#line hidden
                BeginContext(3961, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(4005, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac24c1e0892a4f5ead7cef6b5657bb2b", async() => {
                    BeginContext(4030, 17, false);
#line 65 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                               Write(option.ToString());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 65 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
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
                BeginContext(4056, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 66 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                        }
                                    

#line default
#line hidden
                BeginContext(4140, 333, true);
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
            BeginContext(4480, 138, true);
            WriteLiteral("\r\n                    </div>\r\n                    <a href=\"#\" class=\"list-group-item active-list\">Category 3</a>\r\n                </div>\r\n");
            EndContext();
#line 81 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
          
            }

#line default
#line hidden
            BeginContext(4645, 104, true);
            WriteLiteral("\r\n\r\n        </div>\r\n        <!-- /.col-lg-3 -->\r\n     \r\n\r\n\r\n        <div class=\"col-lg-9\">\r\n            ");
            EndContext();
            BeginContext(4749, 135, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ebbe0d703de349cab834093e0eb99d8f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4785, "~/image/shops/banner/", 4785, 21, true);
#line 91 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 4806, Model.ShopId, 4806, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4819, "/banner.png", 4819, 11, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4884, 53, true);
            WriteLiteral("\r\n            <br />\r\n            <div class=\"row\">\r\n");
            EndContext();
#line 94 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                 foreach (ShopService shopService in Model.ShopServices)
                {

#line default
#line hidden
            BeginContext(5030, 108, true);
            WriteLiteral("                    <div class=\"col-lg-4 col-md-6 mb-4\">\r\n                        <div class=\"card h-100\">\r\n");
            EndContext();
            BeginContext(5250, 146, true);
            WriteLiteral("                            <div class=\"card-body\">\r\n                                <h4 class=\"card-title\">\r\n                                    ");
            EndContext();
            BeginContext(5396, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acff49eb076f477ebd39c689f1665c6a", async() => {
                BeginContext(5460, 19, false);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                                                              Write(shopService.Service);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5405, "~/shop/shop-items-info/", 5405, 23, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 5428, shopService.Id, 5428, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 5443, "/", 5443, 1, true);
#line 101 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
AddHtmlAttributeValue("", 5444, Model.ShopId, 5444, 13, false);

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
            BeginContext(5483, 77, true);
            WriteLiteral("\r\n                                </h4>\r\n                                <h5>");
            EndContext();
            BeginContext(5561, 31, false);
#line 103 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                               Write(shopService.Price.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(5592, 60, true);
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
            EndContext();
            BeginContext(5653, 23, false);
#line 104 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                                                Write(shopService.Description);

#line default
#line hidden
            EndContext();
            BeginContext(5676, 314, true);
            WriteLiteral(@"</p>

                            </div>
                            <div class=""card-footer"">
                                <small class=""text-muted"">★ ★ ★ ★ ☆</small><span> <a href="""">Book-Services</a></span>
                            </div>
                        </div>
                    </div>
");
            EndContext();
#line 112 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\ShopItems.cshtml"
                }

#line default
#line hidden
            BeginContext(6009, 145, true);
            WriteLiteral("\r\n            </div>\r\n            <!-- /.row -->\r\n\r\n        </div>\r\n        <!-- /.col-lg-9 -->\r\n\r\n    </div>\r\n    <!-- /.row -->\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(7799, 152, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.shop.ShopIdViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
