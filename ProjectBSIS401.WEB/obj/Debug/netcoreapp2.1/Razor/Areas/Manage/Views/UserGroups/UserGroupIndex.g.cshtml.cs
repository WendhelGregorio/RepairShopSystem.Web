#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ffd4edda1273b37b84daf342cc836f2986d7e23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_UserGroups_UserGroupIndex), @"mvc.1.0.view", @"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml", typeof(AspNetCore.Areas_Manage_Views_UserGroups_UserGroupIndex))]
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
#line 1 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ffd4edda1273b37b84daf342cc836f2986d7e23", @"/Areas/Manage/Views/UserGroups/UserGroupIndex.cshtml")]
    public class Areas_Manage_Views_UserGroups_UserGroupIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Areas.Manage.ViewModels.userGroup.GroupIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-groups/add-user-to-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/user-groups/remove-user-from-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(205, 102, true);
            WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n            <div class=\"lg-5 mt-5 ml-3 mb-3\">\r\n                <h3><strong>");
            EndContext();
            BeginContext(308, 14, false);
#line 10 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                       Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(322, 342, true);
            WriteLiteral(@"</strong> is a member of the groups below.</h3>
             </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-9"">
            <div class=""input-group mb-3"">
                <input type=""text"" id=""searchKeyword"" placeholder=""search groups"" class=""form-control"" aria-label=""search groups"" aria-describedby=""basic-addon2""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 664, "\"", 693, 1);
#line 16 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 672, Model.Groups.Keyword, 672, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(694, 594, true);
            WriteLiteral(@">
                <div class=""input-group-append"">
                    <span class=""input-group-text"" id=""basic-addon2""><a href=""#"" onclick=""searchTrigger()""><i class=""fa fa-search fa-lg fa-fw"" aria-hidden=""true""></i></a></span>
                </div>
            </div>
        </div>
        <div class=""col-lg-3"">
            <div class=""table-responsive table--no-card m-b-30"">
                <a href=""#"" class=""btn btn-lg-3 btn-info btn-block"" onclick=""showAdd()"" id=""add-user-to-group-button"">
                    <i class=""fa fa-plus""></i>&nbsp;
                    <span>Add ");
            EndContext();
            BeginContext(1289, 14, false);
#line 26 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                         Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1303, 92, true);
            WriteLiteral(" to Group</span>\r\n                </a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
            EndContext();
#line 33 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
     if (Model.Groups.Items.Count > 0)
    {

#line default
#line hidden
            BeginContext(1442, 251, true);
            WriteLiteral("        <table class=\"table table-borderless table-striped table-earning\">\r\n            <thead>\r\n                <tr>\r\n                    <th>Name</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 43 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                  

                    foreach (Group group in Model.Groups.Items)
                    {

#line default
#line hidden
            BeginContext(1803, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(1866, 10, false);
#line 48 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                           Write(group.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 41, true);
            WriteLiteral("</td>\r\n                            <td>\r\n");
            EndContext();
#line 50 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                  
                                    if (group.Name.ToLower() != "public")
                                    {

#line default
#line hidden
            BeginContext(2067, 51, true);
            WriteLiteral("                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 2118, "\"", 2159, 4);
            WriteAttributeValue("", 2126, "Remove", 2126, 6, true);
#line 53 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue(" ", 2132, Model.UserName, 2133, 15, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2148, "from", 2149, 5, true);
            WriteAttributeValue(" ", 2153, "Group", 2154, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2160, "\"", 2219, 5);
            WriteAttributeValue("", 2170, "confirmRemoveFromGroup(\'", 2170, 24, true);
#line 53 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2194, group.Id, 2194, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2203, "\',\'", 2203, 3, true);
#line 53 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2206, group.Name, 2206, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2217, "\')", 2217, 2, true);
            EndWriteAttribute();
            BeginContext(2220, 78, true);
            WriteLiteral("><button type=\"button\" class=\"btn\"><i class=\"fas fa-times\"></i></button></a>\r\n");
            EndContext();
#line 54 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(2372, 66, true);
            WriteLiteral("                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 58 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                    }
                

#line default
#line hidden
            BeginContext(2480, 425, true);
            WriteLiteral(@"            </tbody>
            <tfoot>
                <tr>
                    <td colspan=""4"">
                        <nav aria-label=""Page navigation example"">
                            <ul class=""pagination"">
                                <li class=""page-item""><span class=""form-control-plaintext"">Page&nbsp;&nbsp;&nbsp;</span></li>
                                <li class=""page-item""><input type=""number""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2905, "\"", 2936, 1);
#line 67 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 2913, Model.Groups.PageIndex, 2913, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2937, 41, true);
            WriteLiteral(" class=\"form-control\" style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("onKeydown", " onKeydown=\"", 2978, "\"", 3230, 18);
            WriteAttributeValue("", 2990, "javascript:", 2990, 11, true);
            WriteAttributeValue(" ", 3001, "if(event.keyCode", 3002, 17, true);
            WriteAttributeValue(" ", 3018, "==", 3019, 3, true);
            WriteAttributeValue(" ", 3021, "13", 3022, 3, true);
            WriteAttributeValue(" ", 3024, "&&", 3025, 3, true);
            WriteAttributeValue(" ", 3027, "isNaN(parseInt($(this).val()))==false)", 3028, 39, true);
            WriteAttributeValue(" ", 3066, "window.location=\'/manage/user-groups/", 3067, 38, true);
#line 67 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 3104, Model.UserId, 3104, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 3117, "?pageIndex=\'", 3117, 12, true);
            WriteAttributeValue(" ", 3129, "+", 3130, 2, true);
            WriteAttributeValue(" ", 3131, "(isNaN(parseInt($(this).val()))", 3132, 32, true);
            WriteAttributeValue(" ", 3163, "?", 3164, 2, true);
            WriteAttributeValue(" ", 3165, "1", 3166, 2, true);
            WriteAttributeValue(" ", 3167, ":", 3168, 2, true);
            WriteAttributeValue(" ", 3169, "parseInt($(this).val()))", 3170, 25, true);
            WriteAttributeValue(" ", 3194, "+", 3195, 2, true);
            WriteAttributeValue(" ", 3196, "\'&keyword=", 3197, 11, true);
#line 67 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 3207, Model.Groups.Keyword, 3207, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3231, 122, true);
            WriteLiteral(" /></li>\r\n                                <li class=\"page-item\"><span class=\"form-control-plaintext\">&nbsp;&nbsp;&nbsp;of ");
            EndContext();
            BeginContext(3354, 22, false);
#line 68 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                                                           Write(Model.Groups.PageCount);

#line default
#line hidden
            EndContext();
            BeginContext(3376, 32, true);
            WriteLiteral("&nbsp;&nbsp;&nbsp;</span></li>\r\n");
            EndContext();
#line 69 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                  
                                    var prev = Model.Groups.PageIndex - 1;
                                    if (prev > 0)
                                    {

#line default
#line hidden
            BeginContext(3610, 62, true);
            WriteLiteral("                                        <li class=\"page-item\">");
            EndContext();
            BeginContext(3672, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfdb88eb3c914e4da5a6782a7ae4302a", async() => {
                BeginContext(3813, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&laquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3699, "~/manage/user-groups/", 3699, 21, true);
#line 73 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3720, Model.UserId, 3720, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3733, "?keyword=", 3733, 9, true);
#line 73 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3742, Model.Groups.Keyword, 3742, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3763, "&pageSize=", 3763, 10, true);
#line 73 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3773, Model.Groups.PageSize, 3773, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3795, "&pageIndex=", 3795, 11, true);
#line 73 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 3806, prev, 3806, 5, false);

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
            BeginContext(3856, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 74 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(3937, 84, true);
            WriteLiteral("                                <li class=\"page-item\"><a class=\"page-link\" href=\"#\">");
            EndContext();
            BeginContext(4023, 22, false);
#line 76 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                                Write(Model.Groups.PageIndex);

#line default
#line hidden
            EndContext();
            BeginContext(4046, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 77 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                  
                                    var next = Model.Groups.PageIndex + 1;
                                    if (next <= Model.Groups.PageCount)
                                    {

#line default
#line hidden
            BeginContext(4281, 62, true);
            WriteLiteral("                                        <li class=\"page-item\">");
            EndContext();
            BeginContext(4343, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "adba8fb5ec2b40a7bc12210a835f9bf4", async() => {
                BeginContext(4484, 39, true);
                WriteLiteral("<span aria-hidden=\"true\">&raquo;</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 8, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4370, "~/manage/user-groups/", 4370, 21, true);
#line 81 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4391, Model.UserId, 4391, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4404, "?keyword=", 4404, 9, true);
#line 81 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4413, Model.Groups.Keyword, 4413, 21, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4434, "&pageSize=", 4434, 10, true);
#line 81 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4444, Model.Groups.PageSize, 4444, 22, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 4466, "&pageIndex=", 4466, 11, true);
#line 81 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
AddHtmlAttributeValue("", 4477, next, 4477, 5, false);

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
            BeginContext(4527, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 82 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                    }
                                

#line default
#line hidden
            BeginContext(4608, 157, true);
            WriteLiteral("                            </ul>\r\n                        </nav>\r\n                    </td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n");
            EndContext();
#line 90 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(4789, 34, true);
            WriteLiteral("        <p>0 search results.</p>\r\n");
            EndContext();
#line 94 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
    }

#line default
#line hidden
            BeginContext(4830, 257, true);
            WriteLiteral(@"

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-add"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Add ");
            EndContext();
            BeginContext(5088, 14, false);
#line 101 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                           Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(5102, 250, true);
            WriteLiteral(" to Group</h5>\r\n                    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(5352, 706, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "021555d227e648e8a977905a588d0370", async() => {
                BeginContext(5420, 92, true);
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5512, "\"", 5533, 1);
#line 108 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 5520, Model.UserId, 5520, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5534, 63, true);
                WriteLiteral(" name=\"UserId\" />\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5597, "\"", 5630, 2);
                WriteAttributeValue("", 5605, "user-groups/", 5605, 12, true);
#line 109 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 5617, Model.UserId, 5617, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5631, 420, true);
                WriteLiteral(@" name=""Redirect"" />
                        <select id=""modal-add-select-group"" name=""GroupId""></select>
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
            BeginContext(6058, 322, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>

    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""modal-remove-from-group"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Remove ");
            EndContext();
            BeginContext(6381, 14, false);
#line 125 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                              Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(6395, 308, true);
            WriteLiteral(@" from Group <span class=""modal-remove-from-group-groupName""></span></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            EndContext();
            BeginContext(6703, 885, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8aa374356f0047738c9d8d47de4c2466", async() => {
                BeginContext(6776, 106, true);
                WriteLiteral("\r\n                    <div class=\"modal-body\">\r\n                        <input type=\"hidden\" name=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 6882, "\"", 6903, 1);
#line 132 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 6890, Model.UserId, 6890, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6904, 159, true);
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"GroupId\" value=\"\" id=\"modal-remove-from-group-groupId\" />\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 7063, "\"", 7096, 2);
                WriteAttributeValue("", 7071, "user-groups/", 7071, 12, true);
#line 134 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
WriteAttributeValue("", 7083, Model.UserId, 7083, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7097, 80, true);
                WriteLiteral(" name=\"Redirect\" />\r\n                        <p>Are you sure you want to remove ");
                EndContext();
                BeginContext(7178, 14, false);
#line 135 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                      Write(Model.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(7192, 389, true);
                WriteLiteral(@" from Group <span class=""modal-remove-from-group-groupName""></span>?</p>
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
            BeginContext(7588, 1000, true);
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
                var selectAddGroup, $selectAddGroup;
                $selectAddGroup = $('#modal-add-select-group').selectize();
                selectAddGroup = $selectAddGroup[0];
                selectAddGroup.selectize.destroy();
            }
            catch (err) {
                console.log(err);
            }
        }

        function initSelect() {
            destroySelect();
            var selectAddGroup, $selectAddGroup;

            $selectAddGroup = $('#modal-add-select-group').selectize({
                maxItems: 1,
                preload: true,
                load: function (query, callback) {
                    $.ajax({
                        url: '/groups/add-user-to-group-look-up?keyword=' + encodeURIComponent(query) + ""&userId=");
            EndContext();
            BeginContext(8589, 12, false);
#line 173 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                                                                                            Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(8601, 1157, true);
            WriteLiteral(@""",
                        success: function (response) {
                            if (response.length < 1) {
                                $(""#add-user-to-group-button"").hide();
                            } else {
                                $(""#add-user-to-group-button"").show();
                            }

                            callback(response.slice(0, 10));
                        }
                    });
                }
            });

            selectAddGroup = $selectAddGroup.selectize;
        }

        function showAdd() {
            $(""#modal-add"").modal(""show"");
        }


        function confirmRemoveFromGroup(groupId, groupName) {
            $("".modal-remove-from-group-groupName"").html(groupName);
            $(""#modal-remove-from-group-groupId"").val(groupId);
            $(""#modal-remove-from-group"").modal(""show"");
        }

        $(""#searchKeyword"").keyup(function (event) {
            if (event.keyCode === 13) {
                se");
            WriteLiteral("archTrigger();\r\n            }\r\n        });\r\n\r\n        function searchTrigger() {\r\n            window.location = \"/manage/user-groups/");
            EndContext();
            BeginContext(9759, 12, false);
#line 208 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\UserGroups\UserGroupIndex.cshtml"
                                              Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(9771, 79, true);
            WriteLiteral("?pageIndex=1&keyword=\" + $(\"#searchKeyword\").val();\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Areas.Manage.ViewModels.userGroup.GroupIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591