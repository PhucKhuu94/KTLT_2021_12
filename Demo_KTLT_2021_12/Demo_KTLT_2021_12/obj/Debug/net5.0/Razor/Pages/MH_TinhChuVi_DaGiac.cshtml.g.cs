#pragma checksum "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b8df145ca2be5a2bed772e126799c9554352079"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Demo_KTLT_2021_12.Pages.Pages_MH_TinhChuVi_DaGiac), @"mvc.1.0.razor-page", @"/Pages/MH_TinhChuVi_DaGiac.cshtml")]
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
#nullable restore
#line 3 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
using Demo_KTLT_2021_12.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
using Demo_KTLT_2021_12.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b8df145ca2be5a2bed772e126799c9554352079", @"/Pages/MH_TinhChuVi_DaGiac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3968632be816a61715e649cad246a7d9cef82849", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MH_TinhChuVi_DaGiac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n    <h1>Tinh chu vi da giac </h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b8df145ca2be5a2bed772e126799c95543520793852", async() => {
                WriteLiteral("\r\n        <h4>Nhap toa do cac dinh</h4>\r\n        <label for=\"xA\">Toa do X</label>\r\n        <input type=\"text\" name=\"chuoiDinh\" id=\"xA\"");
                BeginWriteAttribute("value", " value=\"", 329, "\"", 353, 1);
#nullable restore
#line 10 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
WriteAttributeValue("", 337, Model.chuoiDinh, 337, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <br />\r\n\r\n        <input type=\"submit\" value=\"Tinh\" />\r\n    ");
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
            WriteLiteral("\r\n    \r\n    <table>\r\n        <tr>\r\n            <th>X</th>\r\n            <th>Y</th>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
         foreach (DIEM diem in Model.d.dsDinh)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
           Write(diem.X);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
           Write(diem.Y);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n");
            WriteLiteral("     <p>");
#nullable restore
#line 31 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MH_TinhChuVi_DaGiac.cshtml"
   Write(Model.Chuoi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_KTLT_2021_12.Pages.MH_TinhChuVi_DaGiacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.MH_TinhChuVi_DaGiacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.MH_TinhChuVi_DaGiacModel>)PageContext?.ViewData;
        public Demo_KTLT_2021_12.Pages.MH_TinhChuVi_DaGiacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591