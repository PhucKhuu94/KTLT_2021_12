#pragma checksum "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da845be1c6e817dea00ded00b4723fa7e1edaf08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Demo_KTLT_2021_12.Pages.Pages_MH_SuaSanPham), @"mvc.1.0.razor-page", @"/Pages/MH_SuaSanPham.cshtml")]
namespace Demo_KTLT_2021_12.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\_ViewImports.cshtml"
using Demo_KTLT_2021_12;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da845be1c6e817dea00ded00b4723fa7e1edaf08", @"/Pages/MH_SuaSanPham.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3968632be816a61715e649cad246a7d9cef82849", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_SuaSanPham : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
 if (Model.coSanPham)
{

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da845be1c6e817dea00ded00b4723fa7e1edaf083561", async() => {
                WriteLiteral("\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 125, "\"", 131, 0);
                EndWriteAttribute();
                WriteLiteral(">Nhap Ten san pham: </label>\r\n    <br />\r\n    <input type=\"text\" name=\"TenSP\"");
                BeginWriteAttribute("id", "\r\n           id=\"", 209, "\"", 238, 1);
#nullable restore
#line 12 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 226, Model.TenSP, 226, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n           value=\"", 239, "\"", 284, 1);
#nullable restore
#line 13 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 259, Model.SanPham.TenSanPham, 259, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 312, "\"", 318, 0);
                EndWriteAttribute();
                WriteLiteral(">Nhap Gia san pham: </label>\r\n    <br />\r\n    <input type=\"text\" name=\"GiaSP\"");
                BeginWriteAttribute("id", "\r\n           id=\"", 396, "\"", 425, 1);
#nullable restore
#line 18 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 413, Model.GiaSP, 413, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n           value=\"", 426, "\"", 464, 1);
#nullable restore
#line 19 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
WriteAttributeValue("", 446, Model.SanPham.Gia, 446, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <br />\r\n    <br />\r\n    <div>\r\n        <button type=\"submit\" class=\"btn btn-success\">Xác nhận</button>\r\n        <a href=\"/MH_DanhSachSanPham\" class=\"btn btn-info\" style=\"text-decoration: none;\">Hủy</a>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 28 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_SuaSanPham.cshtml"
Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_KTLT_2021_12.Pages.MH_SuaSanPhamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.MH_SuaSanPhamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.MH_SuaSanPhamModel>)PageContext?.ViewData;
        public Demo_KTLT_2021_12.Pages.MH_SuaSanPhamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
