#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d70d42a1f192fba401440b6de63ea2951a9f9f89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_MyChat), @"mvc.1.0.view", @"/Views/Shop/MyChat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/MyChat.cshtml", typeof(AspNetCore.Views_Shop_MyChat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70d42a1f192fba401440b6de63ea2951a9f9f89", @"/Views/Shop/MyChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3102e0e7ef42de99f612908151b0124f827dcd2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_MyChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.ViewModels.shop.MyChatViewModel>
    {
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
  
    Layout = null;
    Layout = "~/views/shared/_ShopPartialNav.cshtml";

#line default
#line hidden
            BeginContext(141, 62, true);
            WriteLiteral("\r\n<br /><br />\r\n<h2 class=\"mt-5 text-center\">MyChat</h2>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
   
    var userId = WebIDS.GetShopAdminId;

#line default
#line hidden
            BeginContext(252, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
 if (Model.Chats != null)
{
    if (Model.Chats.Count > 0)
    {
        

#line default
#line hidden
#line 19 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
         foreach (var c in Model.Chats)
        {


#line default
#line hidden
            BeginContext(377, 60, true);
            WriteLiteral("            <ul>\r\n                <li>\r\n                    ");
            EndContext();
            BeginContext(437, 145, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bb5e9b51b74c99862773454de63a9e", async() => {
                BeginContext(470, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(497, 57, false);
#line 25 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
                   Write(c.Users.FirstOrDefault(x => x.UserId == userId).Chat.Name);

#line default
#line hidden
                EndContext();
                BeginContext(554, 24, true);
                WriteLiteral("\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 446, "~/chats/new-chat/", 446, 17, true);
#line 24 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
AddHtmlAttributeValue("", 463, c.Id, 463, 5, false);

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
            BeginContext(582, 44, true);
            WriteLiteral("\r\n                </li>\r\n            </ul>\r\n");
            EndContext();
#line 30 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"



        }

#line default
#line hidden
#line 33 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Views\Shop\MyChat.cshtml"
         
    }
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.ViewModels.shop.MyChatViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
