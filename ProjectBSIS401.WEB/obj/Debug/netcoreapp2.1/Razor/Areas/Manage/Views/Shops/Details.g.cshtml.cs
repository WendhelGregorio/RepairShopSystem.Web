#pragma checksum "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778fc443026f1341025f35dd91139589958bc6c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Shops_Details), @"mvc.1.0.view", @"/Areas/Manage/Views/Shops/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Manage/Views/Shops/Details.cshtml", typeof(AspNetCore.Areas_Manage_Views_Shops_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778fc443026f1341025f35dd91139589958bc6c9", @"/Areas/Manage/Views/Shops/Details.cshtml")]
    public class Areas_Manage_Views_Shops_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Shop>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/manage/shops"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
  
    Layout = "~/areas/manage/views/shared/_forms.cshtml";

#line default
#line hidden
            BeginContext(128, 177, true);
            WriteLiteral("<div class=\"section-title\">\r\n    <h2>Details</h2>\r\n    <p></p>\r\n</div>\r\n\r\n<div>\r\n    <h4>Shop</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(306, 45, false);
#line 15 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OwnerShop));

#line default
#line hidden
            EndContext();
            BeginContext(351, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(413, 41, false);
#line 18 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.OwnerShop));

#line default
#line hidden
            EndContext();
            BeginContext(454, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(517, 48, false);
#line 22 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessName));

#line default
#line hidden
            EndContext();
            BeginContext(565, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(627, 44, false);
#line 25 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessName));

#line default
#line hidden
            EndContext();
            BeginContext(671, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(732, 52, false);
#line 28 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessLocation));

#line default
#line hidden
            EndContext();
            BeginContext(784, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(846, 48, false);
#line 31 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessLocation));

#line default
#line hidden
            EndContext();
            BeginContext(894, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(955, 56, false);
#line 34 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1073, 52, false);
#line 37 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessEmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1186, 51, false);
#line 40 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessContact));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1299, 47, false);
#line 43 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessContact));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1407, 42, false);
#line 46 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1511, 38, false);
#line 49 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1549, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1610, 42, false);
#line 52 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OpenAt));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1714, 38, false);
#line 55 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.OpenAt));

#line default
#line hidden
            EndContext();
            BeginContext(1752, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1813, 43, false);
#line 58 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CloseAt));

#line default
#line hidden
            EndContext();
            BeginContext(1856, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1918, 39, false);
#line 61 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.CloseAt));

#line default
#line hidden
            EndContext();
            BeginContext(1957, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2018, 48, false);
#line 64 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessType));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2128, 44, false);
#line 67 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
       Write(Html.DisplayFor(model => model.BusinessType));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2219, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e414be8d8ef44f0db8f05544f007d486", async() => {
                BeginContext(2307, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2228, "~/manage/shop/edit/", 2228, 19, true);
#line 72 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
AddHtmlAttributeValue("", 2247, Model.Id, 2247, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-route-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 72 "C:\Users\VGD 14\Desktop\2ndsem\myproject\ProjectBSIS401.WEB\Areas\Manage\Views\Shops\Details.cshtml"
AddHtmlAttributeValue("", 2296, Model.Id, 2296, 9, false);

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
            BeginContext(2315, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2323, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338f095e196743f8a62c5fd684d3c569", async() => {
                BeginContext(2371, 12, true);
                WriteLiteral("Back to List");
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
            BeginContext(2387, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectBSIS401.WEB.Infrastructures.Domain.Models.Shop> Html { get; private set; }
    }
}
#pragma warning restore 1591
