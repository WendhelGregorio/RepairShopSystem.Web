#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcb2ca68d9dd65b0527e02dba6980c7fb1dbf373"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chats_ChatShop), @"mvc.1.0.view", @"/Views/Chats/ChatShop.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chats/ChatShop.cshtml", typeof(AspNetCore.Views_Chats_ChatShop))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcb2ca68d9dd65b0527e02dba6980c7fb1dbf373", @"/Views/Chats/ChatShop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Chats_ChatShop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.chat.ChatsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/style/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
  
    ViewData["Title"] = "ChatShop";

#line default
#line hidden
            BeginContext(102, 37, true);
            WriteLiteral("\r\n<h2>ChatShop</h2>\r\n\r\n<br /><br />\r\n");
            EndContext();
            BeginContext(139, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6e4ecc441ff34e2bb7ba32330b9dc0d8", async() => {
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
            BeginContext(186, 912, true);
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
                </div>  <button class=""btn-primary"" id=""refrestBtn""><i class=""fas fa-redo-alt""></i></button>
");
            EndContext();
#line 28 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                 if (Model.Chat.Messages != null)
                {
                    if (Model.Chat.Messages.Count > 0)
                    {


#line default
#line hidden
            BeginContext(1249, 67, true);
            WriteLiteral("                        <div class=\"inbox_chat\" id=\"historyChat\">\r\n");
            EndContext();
#line 34 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                             foreach (var message in Model.Chat.Messages)
                            {

#line default
#line hidden
            BeginContext(1422, 195, true);
            WriteLiteral("                                <div class=\"chat_list active_chat\">\r\n                                    <div class=\"chat_people\">\r\n                                        <div class=\"chat_img\"> ");
            EndContext();
            BeginContext(1617, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9036713d8d0a491c807b39debb7ce71d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1627, "~/userprofile/users/", 1627, 20, true);
#line 38 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
AddHtmlAttributeValue("", 1647, message.UserId, 1647, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1662, "/thumbnail.png", 1662, 14, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
AddHtmlAttributeValue("", 1683, message.Name, 1683, 13, false);

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
            BeginContext(1698, 120, true);
            WriteLiteral(" </div>\r\n                                        <div class=\"chat_ib\">\r\n                                            <h5>");
            EndContext();
            BeginContext(1819, 12, false);
#line 40 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                                           Write(message.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1831, 25, true);
            WriteLiteral(" <span class=\"chat_date\">");
            EndContext();
            BeginContext(1857, 17, false);
#line 40 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                                                                                 Write(message.Timestamp);

#line default
#line hidden
            EndContext();
            BeginContext(1874, 111, true);
            WriteLiteral("</span></h5>\r\n                                            <p>\r\n                                                ");
            EndContext();
            BeginContext(1986, 12, false);
#line 42 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                                           Write(message.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1998, 184, true);
            WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
            EndContext();
#line 47 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                            }

#line default
#line hidden
            BeginContext(2213, 61, true);
            WriteLiteral("\r\n                         \r\n                        </div>\r\n");
            EndContext();
#line 51 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                    }

                }

#line default
#line hidden
            BeginContext(2318, 1142, true);
            WriteLiteral(@"                <!--Recent-->
                <!--End Recent-->
            </div>
            <div class=""mesgs"">
                <div class=""msg_history"">
                    <div class=""incoming_msg""  >
                        <div class=""incoming_msg_img""> <img src=""https://ptetutorials.com/images/user-profile.png"" alt=""sunil""> </div>
                        <label id=""userName""></label>
                        <div class=""received_msg"" id=""messagesList"">
                            <p>hi</p>
                        </div>
                    </div>

                    <div class=""outgoing_msg"">
                        <div class=""sent_msg"" id=""messagesListTwo"">
                            <p>
                                hello
                            </p>
                            <span class=""time_date""> 11:01 AM    |    June 9</span>
                        </div>

                    </div>
                   
                <div class=""type_msg"">
                   ");
            WriteLiteral(" \r\n                    <div class=\"input_msg_write\">\r\n                        <label class=\"form-label\" id=\"userName\">");
            EndContext();
            BeginContext(3461, 15, false);
#line 80 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
                                                           Write(Model.Chat.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3476, 101, true);
            WriteLiteral("</label>\r\n                        <br />\r\n                        <input type=\"hidden\" id=\"userInput\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3577, "\"", 3601, 1);
#line 82 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
WriteAttributeValue("", 3585, Model.Chat.Name, 3585, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3602, 61, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" id=\"userId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3663, "\"", 3685, 1);
#line 83 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
WriteAttributeValue("", 3671, WebIDS.UserId, 3671, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3686, 61, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" id=\"chatId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3747, "\"", 3769, 1);
#line 84 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
WriteAttributeValue("", 3755, Model.Chat.Id, 3755, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3770, 64, true);
            WriteLiteral(" />\r\n                        <input type=\"hidden\" id=\"timestamp\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3834, "\"", 3858, 1);
#line 85 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Chats\ChatShop.cshtml"
WriteAttributeValue("", 3842, DateTime.UtcNow, 3842, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3859, 401, true);
            WriteLiteral(@" />
                        <label class=""form-label"">Message</label>
                        <input type=""text"" id=""messageInput"" />
                        <button class=""msg_send_btn"" id=""sendButton"" type=""button""><i class=""fa fa-paper-plane"" aria-hidden=""true""></i></button>
                    </div>
                </div>
            </div>
        </div>



    </div>
</div>


");
            EndContext();
            BeginContext(4260, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f859b185094f4e4793be3b543448e643", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4321, 4360, true);
            WriteLiteral(@"

<script>
    ""use strict"";

    var connection = new signalR.HubConnectionBuilder().withUrl(""/signalHub"").build();

    //Disable send button until connection is established
    document.getElementById(""sendButton"").disabled = true;
    var u1 = ""user1""
    var u2 = document.getElementById(""userInput"").value;
    connection.on(""ReceiveMessage"", function (user, message) {
        if (user == u1) {
            var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
            var encodedMsg = msg;
            var p = document.createElement(""p"");
            p.textContent = encodedMsg;
            document.getElementById(""messagesList"").appendChild(p);
            
        }
        if (user == u2) {
            var msg = message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
            var encodedMsg = msg;
            var p = document.createElement(""p"");
            p.textContent = encodedMsg;
            document.getElementById(""m");
            WriteLiteral(@"essagesListTwo"").appendChild(p);
        }
      
       
    });


    connection.on(""RecieveChatMessage"", function (RoomId, UserId, Message, Name, Timestamp) {
        console.log(RoomId, UserId, Message, Name, Timestamp);

        var msg = Message.replace(/&/g, ""&amp;"").replace(/</g, ""&lt;"").replace(/>/g, ""&gt;"");
        var encodedMsg = msg;
        var p = document.createElement(""p"");
        p.textContent = encodedMsg;
        document.getElementById(""messagesListTwo"").appendChild(p);

        var chatlist = document.createElement(""div"");
        chatlist.classList('chat_list active_chat');

        var chatPeople = document.createElement(""div"");
        chatPeople.classList('chat_people');

        var chatImg = document.createElement(""div"");
        chatImg.classList('chat_img');

        var Img = document.createElement(""img"");
        Img.src('~/userprofile/users/' + UserId + '/thumbnail.png');

        var chatIb = document.createElement(""div"");
        chatIb.classLi");
            WriteLiteral(@"st('chat_ib');

        var headerF = document.createElement(""h5"");
        headerF.appendChild(document.createTextNode(Name));

        var chatDate = document.createElement(""span"");
        chatDate.classList('chat_date');
        chatDate.appendChild(document.createTextNode(Timestamp));

        var p = document.createElement(""p"");
        p.appendChild(document.createTextNode(Message));



        chatlist.appendChild(chatPeople);
        chatlist.appendChild(chatImg);
        chatlist.appendChild(Img);
        chatlist.appendChild(chatIb);
        chatlist.appendChild(headerF);
        chatlist.appendChild(chatDate);
        chatlist.appendChild(p);

        document.querySelector('inbox_chat').append(chatlist);

    });


    connection.start().then(function () {
        document.getElementById(""sendButton"").disabled = false;
    }).catch(function (err) {
        return console.error(err.toString());
    });

    document.getElementById(""sendButton"").addEventListener(""cl");
            WriteLiteral(@"ick"", function (event) {
        var user = document.getElementById(""userInput"").value;
        var message = document.getElementById(""messageInput"").value;
        var userID = document.getElementById(""userId"").value;
        var roomID = document.getElementById(""chatId"").value;
        var timestamp = document.getElementById(""timestamp"").value;

        var obj = {
            Name: user,
            ChatId: roomID,
            UserId: userID,
            Message: message,
        }
        SendValueToCreateMessage(obj);

        connection.invoke(""ChatTo"", roomID, userID, message, user, timestamp).catch(function (err) {
            return console.error(err.toString());
        });
        connection.invoke(""SendMessageTo"", user, message).catch(function (err) {
            return console.error(err.toString());
        });
        event.preventDefault();
    });

    
    function SendValueToCreateMessage(obj) {
        var route = ""/chats/messages"";
        $.ajax({
            u");
            WriteLiteral(@"rl: route,
            method: ""POST"",
            data: obj,
            success: function (data) {
                
            },
            error: function (err) {
                $(""#ErrorList"").html(err);
            }
        });
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.chat.ChatsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
