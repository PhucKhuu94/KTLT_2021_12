#pragma checksum "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MyPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db55ae72f93b02d0e66ec264e6ebfb50545253dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Demo_KTLT_2021_12.Pages.Pages_MyPage), @"mvc.1.0.razor-page", @"/Pages/MyPage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db55ae72f93b02d0e66ec264e6ebfb50545253dc", @"/Pages/MyPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3968632be816a61715e649cad246a7d9cef82849", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 3 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MyPage.cshtml"
  
    /*
    int a;
    int b;

    a = 10;
    b = 300;

    if (Request.HasFormContentType)
    {
        a = int.Parse(Request.Form["bienA"]);
        b = int.Parse(Request.Form["bienB"]);
    }

    int s = a + b;
    string chuoi = "Ket qua la " + s;
    string currentTime = $"Current time is {DateTime.Now}";
    */

    int tuSo1 = 1;
    int mauSo1 = 1;
    int tuSo2 = 1;
    int mauSo2 = 1;

    if (Request.HasFormContentType)
    {
        tuSo1 = int.Parse(Request.Form["tuSo1"]);
        mauSo1 = int.Parse(Request.Form["mauSo1"]);
        tuSo2 = int.Parse(Request.Form["tuSo2"]);
        mauSo2 = int.Parse(Request.Form["mauSo2"]);
    }

    int tuKQ = tuSo1 * mauSo2 + tuSo2 * mauSo1;
    int mauKQ = mauSo1 * mauSo2;
    string kq = $"Ket qua la {tuKQ}/{mauKQ}";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--
<form method=""POST"">
    <label for=""fname"">Nhap a:</label><br>
    <input type=""text"" id=""fname"" name=""bienA""><br>
    <label for=""lname"">Nhap b:</label><br>
    <input type=""text"" id=""lname"" name=""bienB""><br><br>
    <input type=""submit"" value=""Tinh"">
</form>
<br />
<p>chuoi</p>
<p>currentTime</p>
-->

<div>
    <h2>Tinh tong 2 phan so</h2>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db55ae72f93b02d0e66ec264e6ebfb50545253dc4702", async() => {
                WriteLiteral(@"
        <h4>Nhap phan so thu nhat</h4>
        <label for=""tuSo1"">Nhap tu so:</label><br />
        <input type=""text"" id=""tuSo1"" name=""tuSo1""><br />
        <label for=""mauSo1"">Nhap mau so:</label><br />
        <input type=""text"" id=""mauSo1"" name=""mauSo1""><br /><br />

        <h4>Nhap phan so thu hai</h4>
        <label for=""tuSo2"">Nhap tu so:</label><br />
        <input type=""text"" id=""tuSo2"" name=""tuSo2""><br />
        <label for=""mauSo2"">Nhap mau so:</label><br />
        <input type=""text"" id=""mauSo2"" name=""mauSo2""><br /><br />

        <input type=""submit"" value=""Tinh tong hai phan so"">
    ");
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
            WriteLiteral("\r\n</div>\r\n<br />\r\n<p>");
#nullable restore
#line 72 "C:\CODE\KTLT_2021_12\Demo_KTLT_2021_12\Demo_KTLT_2021_12\Pages\MyPage.cshtml"
Write(kq);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo_KTLT_2021_12.Pages.Index1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.Index1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Demo_KTLT_2021_12.Pages.Index1Model>)PageContext?.ViewData;
        public Demo_KTLT_2021_12.Pages.Index1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
