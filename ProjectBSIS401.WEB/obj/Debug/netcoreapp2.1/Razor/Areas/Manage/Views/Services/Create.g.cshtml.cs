#pragma checksum "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865f1d2ab625390a85f36344a60d8c649427078c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Services_Create), @"mvc.1.0.view", @"/Areas/Manage/Views/Services/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Services/Create.cshtml", typeof(AspNetCore.Areas_Manage_Views_Services_Create))]
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
#line 2 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Enums;

#line default
#line hidden
#line 3 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
using ProjectBSIS401.WEB.Infrastructures.Domain.Helper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865f1d2ab625390a85f36344a60d8c649427078c", @"/Areas/Manage/Views/Services/Create.cshtml")]
    public class Areas_Manage_Views_Services_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Areas.Manage.ViewModels.services.CreateViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/service/index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(255, 933, true);
            WriteLiteral(@"<div class=""section-title"">
    <h2>Create Services</h2>
    <p></p>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <form method=""post"" action=""/manage/service/create"">
                <div class=""form-group"">
                    <label class=""control-label"">Name</label>
                    <input class=""form-control"" name=""Name"" placeholder=""Enter a name"" />
                </div>
                <div class=""form-group"">
                    <label class=""control-label"">Description</label>
                    <input class=""form-control"" name=""Description"" placeholder=""Enter a description"" />
                </div>
                <div class=""form-group"">
                    <label for=""servicetype"" class=""control-label mb-1"">Services</label>
                    <select class=""js-example-basic-multiple-limit form-control"" id=""servicetype"" name=""ServiceType"">
");
            EndContext();
#line 26 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
                          
                            var options2 = Enum.GetValues(typeof(ProjectBSIS401.WEB.Infrastructures.Domain.Enums.ServiceType)).Cast<ProjectBSIS401.WEB.Infrastructures.Domain.Enums.ServiceType>();

                            foreach (ProjectBSIS401.WEB.Infrastructures.Domain.Enums.ServiceType option in options2)
                            {

#line default
#line hidden
            BeginContext(1564, 39, true);
            WriteLiteral("                                <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1603, "\"", 1618, 1);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
WriteAttributeValue("", 1611, option, 1611, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1619, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1621, 17, false);
#line 31 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
                                                   Write(option.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1638, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 32 "C:\Users\VGD 14\Pictures\GithubRepositorySeedData\GitHubRepairSystem\ProjectBSIS401.WEB\Areas\Manage\Views\Services\Create.cshtml"
                            }
                        

#line default
#line hidden
            BeginContext(1707, 200, true);
            WriteLiteral("                    </select>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-primary\">Create</button>\r\n                    ");
            EndContext();
            BeginContext(1907, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "076d6302767f410ba86d07694d8ce73f", async() => {
                BeginContext(1963, 4, true);
                WriteLiteral("Back");
                EndContext();
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
            BeginContext(1971, 103, true);
            WriteLiteral("\r\n                </div>\r\n                \r\n            </form>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2146, 768, true);
            WriteLiteral(@"<script type=""text/javascript"">
    function Tests() {
        var select = $(""#dropdownlist"").val();
        console.log(select);
        var data = {
            test: {
                ServiceType: select
            }
        };
        console.log(data);
        $.ajax({
            type: ""POST"",
            url: ""/manage/service-create"",
            data: data,
            success: function () {
                alert(""ok"");
            }
        });
    }



    // In your Javascript (external .js resource or <script> tag)

        $(document).ready(function () {
        $('.js-example-basic-single').select2();
    });

    $("".js-example-basic-multiple-limit"").select2({
        maximumSelectionLength: 2
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Areas.Manage.ViewModels.services.CreateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
