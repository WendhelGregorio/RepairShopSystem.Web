#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7353e7e10270e15577dc56c2ad60e8fd2d5cc567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Profile), @"mvc.1.0.view", @"/Views/Account/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Profile.cshtml", typeof(AspNetCore.Views_Account_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7353e7e10270e15577dc56c2ad60e8fd2d5cc567", @"/Views/Account/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.account.ProfileViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
            BeginContext(108, 26, true);
            WriteLiteral("<br /><br /><br /><br />\r\n");
            EndContext();
            BeginContext(135, 23, false);
#line 7 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(161, 24, false);
#line 8 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(185, 365, true);
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-body"">
                    <div class=""card-title mb-4"">
                        <div class=""d-flex justify-content-start"">

                            <div class=""image-container"">
                                ");
            EndContext();
            BeginContext(550, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6a8c436f9585454d89a77dee9ae25d3c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 560, "~/userprofile/users/", 560, 20, true);
#line 18 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
AddHtmlAttributeValue("", 580, Model.User.Id, 580, 14, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 594, "/thumbnail.png", 594, 14, true);
            AddHtmlAttributeValue(" ", 608, "", 609, 1, true);
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
            BeginContext(687, 94, true);
            WriteLiteral("\r\n                                <div class=\"middle\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(781, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a4d2d20a9174a7e834d166c7ecc7dc6", async() => {
                BeginContext(855, 14, true);
                WriteLiteral("Update-profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 790, "~/account/update-profile/", 790, 25, true);
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
AddHtmlAttributeValue("", 815, Model.User.Id, 815, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(873, 916, true);
            WriteLiteral(@"

                                </div>


                                <div class=""ml-auto"">
                                    <input type=""button"" class=""btn btn-primary d-none"" id=""btnDiscard"" value=""Discard Changes"" />
                                </div>
                            </div>
                        </div>
                       
                        <nav>
                            <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                                <button class=""nav-link active"" id=""nav-info-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-info"" type=""button"" role=""tab"" aria-controls=""nav-info"" aria-selected=""true"">My Info</button>
                                <button class=""nav-link"" id=""nav-book-tab"" data-bs-toggle=""tab"" data-bs-target=""#nav-book"" type=""button"" role=""tab"" aria-controls=""nav-book"" aria-selected=""false"">My Books</button>
");
            EndContext();
            BeginContext(2015, 638, true);
            WriteLiteral(@"                            </div>
                        </nav>
                        <div class=""tab-content"" id=""nav-tabContent"">
                            <div class=""tab-pane fade show active"" id=""nav-info"" role=""tabpanel"" aria-labelledby=""nav-info-tab"">
                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">First Name</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(2654, 20, false);
#line 46 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2674, 494, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">Last Name</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(3169, 19, false);
#line 55 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3188, 498, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />


                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">User Name</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(3687, 19, false);
#line 66 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3706, 491, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />
                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">Gender</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(4198, 17, false);
#line 75 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(4215, 502, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />


                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">Email-Address</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(4718, 23, false);
#line 86 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(4741, 494, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <hr />



                                <div class=""row"">
                                    <div class=""col-sm-3 col-md-2 col-5"">
                                        <label style=""font-weight:bold;"">Age</label>
                                    </div>
                                    <div class=""col-md-8 col-6"">
                                        ");
            EndContext();
            BeginContext(5236, 14, false);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   Write(Model.User.Age);

#line default
#line hidden
            EndContext();
            BeginContext(5250, 248, true);
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n\r\n\r\n\r\n                            </div>\r\n                            <div class=\"tab-pane fade\" id=\"nav-book\" role=\"tabpanel\" aria-labelledby=\"nav-book-tab\">\r\n");
            EndContext();
#line 107 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                   

                                    if(Model.Bookings != null)
                                    {
                                        if(Model.Bookings.Count > 0)
                                        {

#line default
#line hidden
            BeginContext(5753, 936, true);
            WriteLiteral(@"                                            <div>
                                                <table id=""MyBookList"" class=""table table-borderless table-striped table-hover"">
                                                    <thead>
                                                        <tr>
                                                            <th>#</th>
                                                            <th>Name</th>
                                                            <th>Price</th>
                                                            <th>status</th>
                                                            <th>Date</th>
                                                            <th></th>
                                                        </tr>
                                                    </thead>
                                                    <tbody>
");
            EndContext();
#line 126 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                          
                                                            int count = 0;
                                                            

#line default
#line hidden
#line 128 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                             foreach (var bookings in Model.Bookings)
                                                            {
                                                                count++;

#line default
#line hidden
            BeginContext(7065, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(7192, 5, false);
#line 132 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                           Write(count);

#line default
#line hidden
            EndContext();
            BeginContext(7197, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(7269, 24, false);
#line 133 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                           Write(bookings.ShopServiceName);

#line default
#line hidden
            EndContext();
            BeginContext(7293, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(7365, 39, false);
#line 134 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                           Write(bookings.ShopServicePrice.ToString("F"));

#line default
#line hidden
            EndContext();
            BeginContext(7404, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(7476, 22, false);
#line 135 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                           Write(bookings.ReserveStatus);

#line default
#line hidden
            EndContext();
            BeginContext(7498, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(7570, 41, false);
#line 136 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                           Write(bookings.UpdatedAt.ToString("MM/dd/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(7611, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 137 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                             if (bookings.ReserveStatus == ReserveStatus.Confirm || bookings.ReserveStatus == ReserveStatus.Completed)
                                                            {

#line default
#line hidden
            BeginContext(7849, 130, true);
            WriteLiteral("                                                            <td>\r\n                                                                ");
            EndContext();
            BeginContext(7979, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ab117fba26c4aa19bc4f1a943f27772", async() => {
                BeginContext(8014, 32, true);
                WriteLiteral("<i class=\"fas fa-comment-o\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7988, "~/shop/", 7988, 7, true);
#line 140 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
AddHtmlAttributeValue("", 7995, bookings.ShopId, 7995, 16, false);

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
            BeginContext(8050, 71, true);
            WriteLiteral("\r\n\r\n                                                            </td>\r\n");
            EndContext();
#line 143 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(8184, 65, true);
            WriteLiteral("\r\n                                                        </tr>\r\n");
            EndContext();
#line 146 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                                            }

#line default
#line hidden
            BeginContext(8371, 174, true);
            WriteLiteral("\r\n                                                    </tbody>\r\n                                                </table>\r\n                                            </div>\r\n");
            EndContext();
#line 152 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Account\Profile.cshtml"
                                        }
                                    }
                                

#line default
#line hidden
            BeginContext(8662, 126, true);
            WriteLiteral("                            \r\n                            \r\n                            \r\n                            </div>\r\n");
            EndContext();
            BeginContext(8926, 229, true);
            WriteLiteral("                        </div>\r\n                      \r\n\r\n                           \r\n                        </div>\r\n\r\n\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.account.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
