#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1792440b9cb35e3cdfe83d4faf6996c7772c4b6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chats_Chat), @"mvc.1.0.view", @"/Views/Chats/Chat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chats/Chat.cshtml", typeof(AspNetCore.Views_Chats_Chat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1792440b9cb35e3cdfe83d4faf6996c7772c4b6e", @"/Views/Chats/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chats_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.chat.NewChatViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("send-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
  
    ViewData["Title"] = "Chat";

#line default
#line hidden
            BeginContext(100, 71, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"mt-5\">Chat</h2>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(395, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(399, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fcc7ac5d7de548aaaab1435d5a8b48ea", async() => {
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
            BeginContext(446, 868, true);
            WriteLiteral(@"
<div class=""container"">
    <h3 class="" text-center"">Messaging</h3>
    <div class=""messaging"">
        <div class=""inbox_msg"">
            <div class=""inbox_people"">
                <div class=""headind_srch"">
                    <div class=""recent_heading"">
                        <h4>Recent</h4>
                    </div>
                    <div class=""srch_bar"">
                        <div class=""stylish-input-group"">
                            <input type=""text"" class=""search-bar"" placeholder=""Search"">
                            <span class=""input-group-addon"">
                                <button type=""button""> <i class=""fa fa-search"" aria-hidden=""true""></i> </button>
                            </span>
                        </div>
                    </div>
                </div>
                <div class=""inbox_chat"">
");
            EndContext();
#line 39 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                         foreach (var message in Model.Chat.Messages.OrderBy(m => m.Timestamp))
                        {   

#line default
#line hidden
            BeginContext(1441, 170, true);
            WriteLiteral("                            <div class=\"chat_list\">\r\n                                <div class=\"chat_people\">\r\n                                    <div class=\"chat_img\">");
            EndContext();
            BeginContext(1611, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "37665cb2a28d42d9af2ff5c404fb6a79", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1621, "~/userprofile/users/", 1621, 20, true);
#line 43 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
AddHtmlAttributeValue("", 1641, message.UserId, 1641, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1656, "/thumbnail.png", 1656, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 43 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
AddHtmlAttributeValue("", 1677, message.Name, 1677, 13, false);

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
            BeginContext(1692, 112, true);
            WriteLiteral(" </div>\r\n                                    <div class=\"chat_ib\">\r\n                                        <h5>");
            EndContext();
            BeginContext(1805, 12, false);
#line 45 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                       Write(message.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1817, 25, true);
            WriteLiteral(" <span class=\"chat_date\">");
            EndContext();
            BeginContext(1843, 37, false);
#line 45 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                                             Write(message.Timestamp.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 102, true);
            WriteLiteral("</span></h5>\r\n                                        <p>\r\n                                           ");
            EndContext();
            BeginContext(1983, 12, false);
#line 47 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                      Write(message.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1995, 168, true);
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 52 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                        }

#line default
#line hidden
            BeginContext(2190, 139, true);
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"mesgs\">\r\n                <div class=\"msg_history\" id=\"messages-list\">\r\n");
            EndContext();
#line 57 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                     foreach (var item in Model.Chat.Messages.OrderBy(m => m.Timestamp))
                    {
                        if (item.UserId != Model.User.Id)
                        {

#line default
#line hidden
            BeginContext(2528, 156, true);
            WriteLiteral("                            <div class=\"incoming_msg\">\r\n                                <div class=\"incoming_msg_img\">\r\n                                    ");
            EndContext();
            BeginContext(2684, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be6ca4a69f864f41aca8c41efaf9d5f9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2708, "~/userprofile/users/", 2708, 20, true);
#line 63 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
AddHtmlAttributeValue("", 2728, item.UserId, 2728, 12, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 2740, "/thumbnail.png", 2740, 14, true);
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
            BeginContext(2764, 9, false);
#line 63 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2773, 261, true);
            WriteLiteral(@"
                                </div>
                                <div class=""received_msg"">
                                    <div class=""received_withd_msg"">
                                        <p>
                                            ");
            EndContext();
            BeginContext(3035, 9, false);
#line 68 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                       Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(3044, 112, true);
            WriteLiteral("\r\n                                        </p>\r\n                                        <span class=\"time_date\">");
            EndContext();
            BeginContext(3157, 35, false);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                           Write(item.Timestamp.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(3192, 10, true);
            WriteLiteral("    |     ");
            EndContext();
            BeginContext(3203, 34, false);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                                                                         Write(item.Timestamp.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(3237, 129, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 74 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3450, 151, true);
            WriteLiteral("                            <div class=\"outgoing_msg\">\r\n                                <div class=\"sent_msg\">\r\n                                    <p>");
            EndContext();
            BeginContext(3602, 9, false);
#line 79 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                  Write(item.Text);

#line default
#line hidden
            EndContext();
            BeginContext(3611, 66, true);
            WriteLiteral("</p>\r\n                                    <span class=\"time_date\">");
            EndContext();
            BeginContext(3678, 35, false);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                       Write(item.Timestamp.ToString("hh:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(3713, 10, true);
            WriteLiteral("    |     ");
            EndContext();
            BeginContext(3724, 34, false);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                                                                                                     Write(item.Timestamp.ToString("MMMM dd"));

#line default
#line hidden
            EndContext();
            BeginContext(3758, 85, true);
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 83 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(3893, 145, true);
            WriteLiteral("\r\n\r\n\r\n                </div>\r\n                <div class=\"type_msg\">\r\n                    <div class=\"input_msg_write\">\r\n                        ");
            EndContext();
            BeginContext(4038, 653, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3f1e3c2db44df4b4e4807bf670fad2", async() => {
                BeginContext(4070, 62, true);
                WriteLiteral("\r\n                            <input type=\"hidden\" id=\"chatId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4132, "\"", 4154, 1);
#line 92 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
WriteAttributeValue("", 4140, Model.Chat.Id, 4140, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4155, 73, true);
                WriteLiteral(" disabled/>\r\n                            <input type=\"hidden\" id=\"userId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4228, "\"", 4250, 1);
#line 93 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
WriteAttributeValue("", 4236, Model.User.Id, 4236, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4251, 76, true);
                WriteLiteral(" disabled />\r\n                            <input type=\"hidden\" id=\"userName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4327, "\"", 4355, 1);
#line 94 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\Chat.cshtml"
WriteAttributeValue("", 4335, Model.User.UserName, 4335, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4356, 328, true);
                WriteLiteral(@" disabled />
                            <input type=""text"" class=""write_msg"" placeholder=""Type a message"" id=""message-textbox"" disabled />
                            <button class=""msg_send_btn"" id=""send-button"" type=""submit"" disabled><i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>

                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(4691, 114, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.chat.NewChatViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
