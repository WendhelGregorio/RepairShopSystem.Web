#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3973a6bc70293225c1027bf9adf4eaab648a8e9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Users_Profile), @"mvc.1.0.view", @"/Areas/Manage/Views/Users/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Users/Profile.cshtml", typeof(AspNetCore.Areas_Manage_Views_Users_Profile))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3973a6bc70293225c1027bf9adf4eaab648a8e9c", @"/Areas/Manage/Views/Users/Profile.cshtml")]
    public class Areas_Manage_Views_Users_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Areas.Manage.ViewModels.user.ProfileViewModel>
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(139, 48, true);
            WriteLiteral("\r\n<h2>Profile</h2>\r\n\r\n<br /><br /><br /><br />\r\n");
            EndContext();
            BeginContext(188, 23, false);
#line 9 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(214, 24, false);
#line 10 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(238, 365, true);
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
            BeginContext(603, 270, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15b7b27eff5c4b7bb77937111ed41c7c", async() => {
                BeginContext(660, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(698, 137, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0be2e9c856064987979bf553e6d4f7cf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 708, "~/userprofile/users/", 708, 20, true);
#line 21 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
AddHtmlAttributeValue("", 728, Model.User.Id, 728, 14, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 742, "/thumbnail.png", 742, 14, true);
                AddHtmlAttributeValue(" ", 756, "", 757, 1, true);
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
                BeginContext(835, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 612, "~/manage/users/update-thumbnail/", 612, 32, true);
#line 20 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
AddHtmlAttributeValue("", 644, Model.User.Id, 644, 14, false);

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
            BeginContext(873, 127, true);
            WriteLiteral("\r\n                               \r\n                                <div class=\"middle\">\r\n\r\n                                    ");
            EndContext();
            BeginContext(1000, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69fb136119b34a09a20ff49321f54c8f", async() => {
                BeginContext(1079, 14, true);
                WriteLiteral("Update-profile");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1009, "~/manage/users/update-profile/", 1009, 30, true);
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
AddHtmlAttributeValue("", 1039, Model.User.Id, 1039, 14, false);

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
            BeginContext(1097, 679, true);
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
");
            EndContext();
            BeginContext(2220, 638, true);
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
            BeginContext(2859, 20, false);
#line 51 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2879, 494, true);
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
            BeginContext(3374, 19, false);
#line 60 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3393, 498, true);
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
            BeginContext(3892, 19, false);
#line 71 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3911, 491, true);
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
            BeginContext(4403, 17, false);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(4420, 502, true);
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
            BeginContext(4923, 23, false);
#line 91 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.EmailAddress);

#line default
#line hidden
            EndContext();
            BeginContext(4946, 494, true);
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
            BeginContext(5441, 14, false);
#line 103 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Users\Profile.cshtml"
                                   Write(Model.User.Age);

#line default
#line hidden
            EndContext();
            BeginContext(5455, 319, true);
            WriteLiteral(@"
                                    </div>
                                </div>




                            </div>
                            <div class=""tab-pane fade"" id=""nav-book"" role=""tabpanel"" aria-labelledby=""nav-book-tab"">
                               

                            </div>
");
            EndContext();
            BeginContext(5912, 156, true);
            WriteLiteral("                        </div>\r\n\r\n\r\n\r\n                    </div>\r\n\r\n\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Areas.Manage.ViewModels.user.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
