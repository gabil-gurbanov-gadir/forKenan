#pragma checksum "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\Slider\SliderNotFound.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca9a5ca0a46468ae904d109153e537a230f8efb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Slider_SliderNotFound), @"mvc.1.0.view", @"/Areas/Manage/Views/Slider/SliderNotFound.cshtml")]
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
#nullable restore
#line 2 "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\_ViewImports.cshtml"
using Pustok.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bca9a5ca0a46468ae904d109153e537a230f8efb", @"/Areas/Manage/Views/Slider/SliderNotFound.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68f7dc22a1dfec5b537d86f4c6293049b66c135", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Slider_SliderNotFound : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "slider", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\Slider\SliderNotFound.cshtml"
  
    ViewData["Title"] = "404 error";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Begin Page Content -->
<div class=""container-fluid"">

    <!-- 404 Error Text -->
    <div class=""text-center"">
        <div class=""error mx-auto"" data-text=""404"">404</div>
        <p class=""lead text-gray-800 mb-5"">Page Not Found</p>
        <p class=""text-gray-500 mb-0"">Slider with ID = ");
#nullable restore
#line 14 "C:\Users\GabilGG\Documents\CodeWorks\02. HW_Code\ForPush\p220_be_12_22-07-2021-gabil-gurbanov-gadir\HW_210726\Pustok\Areas\Manage\Views\Slider\SliderNotFound.cshtml"
                                                  Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" can not be found</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca9a5ca0a46468ae904d109153e537a230f8efb5241", async() => {
                WriteLiteral("&larr; Click here to see the list of all sliders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
