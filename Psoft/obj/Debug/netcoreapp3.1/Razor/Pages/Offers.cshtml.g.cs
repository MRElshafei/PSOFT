#pragma checksum "E:\PSOFT FINAL\PSOFT\Psoft\Pages\Offers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3479530de6a1f6d30717dd6b233df216c9184e41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_Offers), @"mvc.1.0.razor-page", @"/Pages/Offers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3479530de6a1f6d30717dd6b233df216c9184e41", @"/Pages/Offers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Offers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<table class=""table table-striped projects"">
	<thead>
		<tr>
			<th style=""width: 1%"">
				#
			</th>
			<th style=""width: 20%"">
				Company
			</th>
			<th style=""width: 30%"">
				Team 
			</th>
			<th>
				submit progress
			</th>
			<th style=""width: 8%"" class=""text-center"">
				Status
			</th>
			<th style=""width: 20%"">
			</th>
		</tr>
	</thead>
	<tbody>
		<tr>
			<td>
				01
			</td>
			<td>
				<a>
					CEI
				</a>
				<br />
				<small>
					Created 22.06.2021
				</small>
			</td>
			<td>
                <a>
                Contractor
                </a>
			</td>
			<td class=""project_progress"">
				<div class=""progress progress-sm"">
					<div class=""progress-bar bg-green"" role=""progressbar"" aria-valuenow=""57"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 57%"">
					</div>
				</div>
				<small>
					57% Complete
				</small>
			</td>
			<td class=""project-state"">
				<span class=""badge badge-success"">Success</span>
			</td>
			<td class=""p");
            WriteLiteral(@"roject-actions text-right"">
				<a class=""btn btn-primary btn-sm"" href=""#"">
					<i class=""fas fa-folder"">
					</i>
					View
				</a>
				
				<a class=""btn btn-danger btn-sm"" href=""#"">
					<i class=""fas fa-trash"">
					</i>
					Decline
				</a>
			</td>
		</tr>
		<tr>
</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.OffersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.OffersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.OffersModel>)PageContext?.ViewData;
        public Psoft.Pages.OffersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
