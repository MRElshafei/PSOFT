#pragma checksum "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb56b6c993304bf0e86a392876fb12678b71f840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_EditPlanning), @"mvc.1.0.razor-page", @"/Pages/EditPlanning.cshtml")]
namespace Psoft.Pages
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
#line 1 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Psoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Psoft.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb56b6c993304bf0e86a392876fb12678b71f840", @"/Pages/EditPlanning.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EditPlanning : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Planning", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb56b6c993304bf0e86a392876fb12678b71f8404032", async() => {
                WriteLiteral("\r\n\r\n    <table>\r\n        <tr>\r\n            <td>Element Name</td>\r\n            <td>Start Date</td>\r\n            <td>End Date</td>\r\n            <td>Percentage Of Completion</td>\r\n        </tr>\r\n");
#nullable restore
#line 14 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
         foreach (var Col in Model.ListOfColumns)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("<tr><td>");
#nullable restore
#line 16 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
                 Write(Col.ColumName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <td><input type=\"date\" /></td> <td><input type=\"date\" /></td> <td><input type=\"number\"></td></tr>\r\n");
#nullable restore
#line 17 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 19 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
         foreach (var Beam in Model.ListOfBeams)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("<tr><td>");
#nullable restore
#line 21 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
                 Write(Beam.BeamName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <td><input type=\"date\" /></td> <td><input type=\"date\" /></td> <td><input type=\"number\"></td></tr>\r\n");
#nullable restore
#line 22 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 24 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
         foreach (var Slab in Model.ListOfSlabs)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("<tr><td>");
#nullable restore
#line 26 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
                 Write(Slab.SlabName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <td><input type=\"date\" /></td> <td><input type=\"date\" /></td> <td><input type=\"number\"></td></tr>\r\n");
#nullable restore
#line 27 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 29 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
         foreach (var wall in Model.ListOfColumns)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                WriteLiteral("<tr><td>");
#nullable restore
#line 31 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
                 Write(wall.ColumName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td> <td><input type=\"date\" /></td> <td><input type=\"date\" /></td> <td><input type=\"number\"></td></tr>\r\n");
#nullable restore
#line 32 "E:\PSOFT FINAL\PSOFT\Psoft\Pages\EditPlanning.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <button>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb56b6c993304bf0e86a392876fb12678b71f8407676", async() => {
                    WriteLiteral("Confirm");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</button>\r\n    </table>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.EditPlanningModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.EditPlanningModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.EditPlanningModel>)PageContext?.ViewData;
        public Psoft.Pages.EditPlanningModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
