#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c94fa7c69cc0ac375eca829d5fa8c045d5205a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_UserRoles_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/UserRoles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/UserRoles/Index.cshtml", typeof(AspNetCore.Areas_Manage_Views_UserRoles_Index))]
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
#line 1 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c94fa7c69cc0ac375eca829d5fa8c045d5205a", @"/Areas/Manage/Views/UserRoles/Index.cshtml")]
    public class Areas_Manage_Views_UserRoles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Areas.Manage.ViewModels.userRole.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-roles/add-role-to-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-roles/remove-role-from-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(198, 98, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"lg-5 mt-5 ml-3 mb-3\">\r\n            <h3><strong>");
            EndContext();
            BeginContext(297, 14, false);
#line 12 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(311, 323, true);
            WriteLiteral(@"</strong> has the roles below.</h3>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-9"">
            <div class=""input-group mb-3"">
                <input type=""text"" id=""searchKeyword"" placeholder=""search roles"" class=""form-control"" aria-label=""search roles"" aria-describedby=""basic-addon2""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 634, "\"", 662, 1);
#line 18 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 642, Model.Roles.Keyword, 642, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(663, 582, true);
            WriteLiteral(@">
                <div class=""input-role-append"">
                    <span class=""input-group-text""id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search"" aria-hidden=""true""></i></a></span>
                </div>
            </div>
        </div>

        <div class=""col-lg-3"">
            <div class=""table-responsive table--no-card m-b-30"">
                <a href=""#"" class=""btn btn-lg-3 btn-info btn-block"" onclick=""showAdd()"" id=""add-role-to-user"">
                    <i class=""fa fa-plus""></i>&nbsp;
                    <span>Add role to ");
            EndContext();
            BeginContext(1246, 14, false);
#line 29 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                 Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1260, 83, true);
            WriteLiteral("</span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 36 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
 if (Model.Roles.Items.Count > 0)
{

#line default
#line hidden
            BeginContext(1381, 236, true);
            WriteLiteral("    <table class=\"table table-borderless table-striped table-hover\">\r\n        <thead>\r\n            <tr class=\"table-info\">\r\n                <th>Name</th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
              
                foreach (Role role in Model.Roles.Items)
                {

#line default
#line hidden
            BeginContext(1710, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1765, 15, false);
#line 50 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                       Write(role.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1780, 76, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1856, "\"", 1896, 4);
            WriteAttributeValue("", 1864, "Remove", 1864, 6, true);
            WriteAttributeValue(" ", 1870, "role", 1871, 5, true);
            WriteAttributeValue(" ", 1875, "from", 1876, 5, true);
#line 52 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue(" ", 1880, Model.UserName, 1881, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1897, "\"", 1952, 5);
            WriteAttributeValue("", 1907, "confirmRemoveRole(\'", 1907, 19, true);
#line 52 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 1926, role, 1926, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1931, "\',\'", 1931, 3, true);
#line 52 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 1934, role.ToString(), 1934, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 1950, "\')", 1950, 2, true);
            EndWriteAttribute();
            BeginContext(1953, 136, true);
            WriteLiteral("><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 55 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2123, 393, true);
            WriteLiteral(@"        </tbody>
        <tfoot>
            <tr>
                <td colspan=""4"">
                    <nav aria-label=""Page navigation example"">
                        <ul class=""pagination"">
                            <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                            <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2516, "\"", 2546, 1);
#line 64 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 2524, Model.Roles.PageIndex, 2524, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2547, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 2588, "\"", 2838, 18);
            WriteAttributeValue("", 2600, "javascript:", 2600, 11, true);
            WriteAttributeValue(" ", 2611, "if(event.keyCode", 2612, 17, true);
            WriteAttributeValue(" ", 2628, "==", 2629, 3, true);
            WriteAttributeValue(" ", 2631, "13", 2632, 3, true);
            WriteAttributeValue(" ", 2634, "&&", 2635, 3, true);
            WriteAttributeValue(" ", 2637, "isNaN(parseInt($(this).val()))==false)", 2638, 39, true);
            WriteAttributeValue(" ", 2676, "window.location=\'/manage/user-roles/", 2677, 37, true);
#line 64 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 2713, Model.UserId, 2713, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 2726, "?pageIndex=\'", 2726, 12, true);
            WriteAttributeValue(" ", 2738, "+", 2739, 2, true);
            WriteAttributeValue(" ", 2740, "(isNaN(parseInt($(this).val()))", 2741, 32, true);
            WriteAttributeValue(" ", 2772, "?", 2773, 2, true);
            WriteAttributeValue(" ", 2774, "1", 2775, 2, true);
            WriteAttributeValue(" ", 2776, ":", 2777, 2, true);
            WriteAttributeValue(" ", 2778, "parseInt($(this).val()))", 2779, 25, true);
            WriteAttributeValue(" ", 2803, "+", 2804, 2, true);
            WriteAttributeValue(" ", 2805, "\'&keyword=", 2806, 11, true);
#line 64 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 2816, Model.Roles.Keyword, 2816, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2839, 118, true);
            WriteLiteral(" /></li>\r\n                            <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(2958, 21, false);
#line 65 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                                                       Write(Model.Roles.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(2979, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 66 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                              
                                var prev = Model.Roles.PageIndex - 1;
                                if (prev > 0)
                                {

#line default
#line hidden
            BeginContext(3196, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3254, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb2a5d0652de404dbe55c48be041cc10", async() => {
                BeginContext(3392, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3281, "~/manage/user-roles/", 3281, 20, true);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3301, Model.UserId, 3301, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3314, "?keyword=", 3314, 9, true);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3323, Model.Roles.Keyword, 3323, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3343, "&pageSize=", 3343, 10, true);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3353, Model.Roles.PageSize, 3353, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3374, "&pageIndex=", 3374, 11, true);
#line 70 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3385, prev, 3385, 5, false);

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
            BeginContext(3435, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 71 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(3508, 80, true);
            WriteLiteral("                            <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(3590, 21, false);
#line 73 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                            Write(Model.Roles.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(3612, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 74 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                              
                                var next = Model.Roles.PageIndex + 1;
                                if (next <= Model.Roles.PageCount)
                                {

#line default
#line hidden
            BeginContext(3829, 58, true);
            WriteLiteral("                                    <li class=\"page-item\">");
            EndContext();
            BeginContext(3887, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba42be78c8bc4ad2a226a8bc2431780a", async() => {
                BeginContext(4025, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3914, "~/manage/user-roles/", 3914, 20, true);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3934, Model.UserId, 3934, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3947, "?keyword=", 3947, 9, true);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3956, Model.Roles.Keyword, 3956, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3976, "&pageSize=", 3976, 10, true);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 3986, Model.Roles.PageSize, 3986, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4007, "&pageIndex=", 4007, 11, true);
#line 78 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
AddHtmlAttributeValue("", 4018, next, 4018, 5, false);

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
            BeginContext(4068, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 79 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                }
                            

#line default
#line hidden
            BeginContext(4141, 133, true);
            WriteLiteral("                        </ul>\r\n                    </nav>\r\n                </td>\r\n            </tr>\r\n        </tfoot>\r\n    </table>\r\n");
            EndContext();
#line 87 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(4286, 30, true);
            WriteLiteral("    <p>0 search results.</p>\r\n");
            EndContext();
#line 91 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4319, 265, true);
            WriteLiteral(@"

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-add"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add Role to ");
            EndContext();
            BeginContext(4585, 14, false);
#line 98 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4599, 241, true);
            WriteLiteral("</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(4840, 1279, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b9cee81886d41cf9598b85169cfa8ac", async() => {
                BeginContext(4906, 92, true);
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4998, "\"", 5019, 1);
#line 105 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 5006, Model.UserId, 5006, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5020, 92, true);
                WriteLiteral(" name=\"UserId\" />\r\n                        <select id=\"modal-add-select-role\" name=\"Role\">\r\n");
                EndContext();
#line 107 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                              
                                foreach (Role role in Model.roleles)
                                {
                                    if (Model.Roleles == role)
                                    {

#line default
#line hidden
                BeginContext(5352, 47, true);
                WriteLiteral("                                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5399, "\"", 5412, 1);
#line 112 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 5407, role, 5407, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5413, 10, true);
                WriteLiteral(" selected>");
                EndContext();
                BeginContext(5424, 15, false);
#line 112 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                  Write(role.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(5439, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 113 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(5570, 47, true);
                WriteLiteral("                                        <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5617, "\"", 5630, 1);
#line 116 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 5625, role, 5625, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5631, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5633, 15, false);
#line 116 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                         Write(role.ToString());

#line default
#line hidden
                EndContext();
                BeginContext(5648, 11, true);
                WriteLiteral("</option>\r\n");
                EndContext();
#line 117 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
                BeginContext(5764, 348, true);
                WriteLiteral(@"                        </select>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-success"">Add</button>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                ");
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
            BeginContext(6119, 385, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-remove-from-role"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Remove role <span class=""modal-remove-from-role-roleName""></span> from ");
            EndContext();
            BeginContext(6505, 14, false);
#line 135 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                                                              Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6519, 241, true);
            WriteLiteral("</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(6760, 874, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d6ac89ce445d450da72fd155c83c967b", async() => {
                BeginContext(6831, 106, true);
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6937, "\"", 6958, 1);
#line 142 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 6945, Model.UserId, 6945, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6959, 154, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"Role\" value=\"\" id=\"modal-remove-from-role-roleId\" />\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7113, "\"", 7145, 2);
                WriteAttributeValue("", 7121, "user-roles/", 7121, 11, true);
#line 144 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
WriteAttributeValue("", 7132, Model.UserId, 7132, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7146, 144, true);
                WriteLiteral(" name=\"Redirect\" />\r\n                        <p>Are you sure you want to remove role <span class=\"modal-remove-from-role-roleName\"></span> from ");
                EndContext();
                BeginContext(7291, 14, false);
#line 145 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                                                                      Write(Model.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(7305, 322, true);
                WriteLiteral(@"?</p>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""submit"" class=""btn btn-danger"">Remove</button>
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7634, 989, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>



    <script type=""text/javascript"">
        $(function () {
            initSelect();
        });

        function destroySelect() {
            try {
                var selectAddRole, $selectAddRole;
                $selectAddRole = $('#modal-add-select-role').selectize();
                selectAddRole = $selectAddRole[0];
                selectAddRole.selectize.destroy();
            }
            catch (err) {
                console.log(err);
            }
        }

        function initSelect() {
            destroySelect();
            var selectAddRole, $selectAddRole;

            $selectAddRole = $('#modal-add-select-role').selectize({
                maxItems: 1,
                preload: true,
                load: function (query, callback) {
                    $.ajax({
                        url: '/roles/add-role-to-user-look-up?keyword=' + encodeURIComponent(query) + ""&userId=");
            EndContext();
            BeginContext(8624, 12, false);
#line 184 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                                                                                          Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(8636, 1138, true);
            WriteLiteral(@""",
                        success: function (response) {
                            if (response.length < 1) {
                                $(""#add-role-to-user-button"").hide();
                            } else {
                                $(""#add-role-to-user-button"").show();
                            }

                            callback(response.slice(0, 10));
                        }
                    });
                }
            });

            selectAddRole = $selectAddRole.selectize;
        }

        function showAdd() {
            $(""#modal-add"").modal(""show"");
        }


        function confirmRemoveRole(roleId, roleName) {
            $("".modal-remove-from-role-roleName"").html(roleName);
            $(""#modal-remove-from-role-roleId"").val(roleId);
            $(""#modal-remove-from-role"").modal(""show"");
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                searchTrigger();
  ");
            WriteLiteral("          }\r\n        });\r\n\r\n        function searchTrigger() {\r\n            window.location = \"/manage/user-roles/");
            EndContext();
            BeginContext(9775, 12, false);
#line 219 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\UserRoles\Index.cshtml"
                                             Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(9787, 81, true);
            WriteLiteral("?pageIndex=1&keyword=\" + $(\"#searchKeyword\").val();\r\n        }\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Areas.Manage.ViewModels.userRole.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
