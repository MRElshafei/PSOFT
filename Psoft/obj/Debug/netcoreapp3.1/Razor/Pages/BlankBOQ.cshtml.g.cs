#pragma checksum "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\BlankBOQ.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2dea2a1bdea45533654b7118f9a6aa9ddee2db1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_BlankBOQ), @"mvc.1.0.razor-page", @"/Pages/BlankBOQ.cshtml")]
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
#line 1 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Psoft;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\_ViewImports.cshtml"
using Psoft.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2dea2a1bdea45533654b7118f9a6aa9ddee2db1", @"/Pages/BlankBOQ.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BlankBOQ : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Pdfpage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<!DOCTYPE html>

<html lang=""en"">


<script src=""//code.jquery.com/jquery-1.10.2.js""></script>
<script src=""//code.jquery.com/ui/1.11.2/jquery-ui.js""></script>


<script>
	tr { display: block; float: left; }
	th, td { display: block; }</script>
<!-- Editable table -->
<div class=""card"">


	<h3 class=""card-header text-center font-weight-bold text-uppercase py-4"">
		<i class=""fas fa-file-alt""></i> Bill of Quantity
	</h3>

	<h6 style=""color:steelblue"" class=""card-header text-center font-weight-bold text-uppercase py-4"">
		");
#nullable restore
#line 26 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\BlankBOQ.cshtml"
   Write(Model.ProjectName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
	</h6>
	<div class=""card-body"">
		<div class=""table-editable"">
			<span class=""table-add float-right mb-3 mr-2"">
				<a href=""#!"" class=""text-success""><i class=""fas fa-plus fa-2x"" aria-hidden=""true""></i></a>
			</span>
			<table class=""table table-bordered table-responsive-md table-striped text-center"" id=""table"">


				<thead>
					<a id=""b1"" class=""btn btn-outline-primary"">Calculate Total Cost</a>
					<a class=""btn btn-outline-primary"" onclick=""export2csv()"">Export to Excel</a>

					");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2dea2a1bdea45533654b7118f9a6aa9ddee2db15210", async() => {
                WriteLiteral("Print/Pdf");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"






					<tr>
						<th class=""text-center"">Item Description</th>
						<th class=""text-center"">Unit</th>
						<th class=""text-center"">Unit Cost</th>
						<th class=""text-center"">Quantity</th>
						<th class=""text-center"">Total Cost</th>
						<th class=""text-center"">Sort</th>
						<th class=""text-center"">Remove</th>
					</tr>
				</thead>
				<tbody>




					<tr>

						<th class=""pt-3-half"" contenteditable=""true""></th>

						<th class=""text-center"" contenteditable=""true""></th>
						<th class=""text-center value2"" style=""white-space: nowrap;"" contenteditable=""true""> </th>
						<th class=""text-center value1"" contenteditable=""true""></th>
						<td class=""fullresult""></td>

						<td class=""pt-3-half"">
							<span class=""table-up"">
								<a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-up"" aria-hidden=""true""></i></a>
							</span>
							<span class=""table-down"">
								<a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-down"" aria");
            WriteLiteral(@"-hidden=""true""></i></a>
							</span>
						</td>
						<td>
							<span class=""table-remove"">
								<button type=""button"" class=""btn btn-danger btn-rounded btn-sm my-0"">
									Remove
								</button>
							</span>
						</td>
					</tr>
					<!-- This is our clonable table line -->



				</tbody>

				<tfoot>

					<tr>

						<th class=""text-center"" colspan=""5"">Total Cost</th>
						<th class=""text-center"" colspan=""2"" id=""totalcost""></th>
					</tr>


				</tfoot>
			</table>
		</div>



	</div>


	<script>


		$(function () {

			$('#b1').click(function () {
				var Totalslab = 0;
				var Totalbeam = 0;
				var Totalwall = 0;
				var Totalcol = 0;
				var Totalcost = 0;
				$('#table tr').each(function (i) {
					var sum = parseFloat($(this).find('.value2').text()) * parseFloat($(this).find('.value1').text());
					$(this).find('.fullresult').text(sum.toFixed(2));


					Totalcost += (+$(this).find('.fullresult').text());
					$('#table tr ').fi");
            WriteLiteral(@"nd('#totalcost').text(Totalcost.toFixed(2));

				});

			})
		});







	</script>

	<script>
		const $tableID = $('#table'); const $BTN = $('#export-btn'); const $EXPORT = $('#export');
		const newTr = `
<tr class=""hide"">



									<th class=""pt-3-half"" contenteditable=""true""></th>

									<th class=""text-center"" contenteditable=""true""></th>
									<th class=""text-center value2"" style=""white-space: nowrap;""  contenteditable=""true""> </th>
									<th class=""text-center value1"" contenteditable=""true""></th>
									<td class=""fullresult""></td>

									<td class=""pt-3-half"">
										<span class=""table-up"">
											<a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-up"" aria-hidden=""true""></i></a>
										</span>
										<span class=""table-down"">
											<a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-down"" aria-hidden=""true""></i></a>
										</span>
									</td>
									<td>
										<span class=""table-remove"">
			");
            WriteLiteral(@"								<button type=""button"" class=""btn btn-danger btn-rounded btn-sm my-0"">
												Remove
											</button>
										</span>
									</td>

`;

		$('.table-add').on('click', 'i', () => {
			const $clone = $tableID.find('tbodytr').last().clone(true).removeClass('hide table-line'); if ($tableID.find('tbody tr').length >= 0) {
				$('tbody').append(newTr); $tableID.find('table').append($clone);
			}
		});
		$tableID.on('click', '.table-remove', function () { $(this).parents('tr').detach(); });
		$tableID.on('click', '.table-up', function () { const $row = $(this).parents('tr'); if ($row.index() === 0) { return; } $row.prev().before($row.get(0)); });
		$tableID.on('click', '.table-down', function () { const $row = $(this).parents('tr'); $row.next().after($row.get(0)); }); // A few jQuery helpers for exporting only jQuery.fn.pop = [].pop;
		jQuery.fn.shift = [].shift;
		$BTN.on('click', () => {
			const $rows = $tableID.find('tr:not(:hidden)'); const headers = []; const data = []; // ");
            WriteLiteral(@"Get the headers(add special header logic here)
			$($rows.shift()).find('th:not(:empty)').each(function () { headers.push($(this).text().toLowerCase()); }); // Turn all existing rows into a loopablearray
			$rows.each(function () {
				const $td = $(this).find('td'); const h = {}; // Use the headers from earlier to name our hash keys headers.
				forEach((header, i) => {
					h[header] = $td.eq(i).text();
				});
				data.push(h);
			}); // Output the result
			$EXPORT.text(JSON.stringify(data));
		});
	</script>



	<script>
		function createPDF() {
			var sTable = document.getElementById('table').innerHTML;

			var style = ""<style>"";
			style = style + ""table {width: 100%;font: 17px Calibri;}"";
			style = style + ""table, th, td {border: solid 1px #DDD; border-collapse: collapse;"";
			style = style + ""padding: 2px 3px;text-align: center;}"";
			style = style + ""</style>"";

			// CREATE A WINDOW OBJECT.
			var win = window.open('', '', 'height=700,width=700');

			win.document.write");
            WriteLiteral(@"('<html><head>');
			win.document.write('<title>Profile</title>');   // <title> FOR PDF HEADER.
			win.document.write(style);          // ADD STYLE INSIDE THE HEAD TAG.
			win.document.write('</head>');
			win.document.write('<body>');
			win.document.write(sTable);         // THE TABLE CONTENTS INSIDE THE BODY TAG.
			win.document.write('</body></html>');

			win.document.close(); 	// CLOSE THE CURRENT WINDOW.

			win.print();    // PRINT THE CONTENTS.
		}
	</script>






</html>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.BlankBOQModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.BlankBOQModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.BlankBOQModel>)PageContext?.ViewData;
        public Psoft.Pages.BlankBOQModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591