#pragma checksum "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f51b9847a96a292bfc56e9be7e164670db6b516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_Invoice), @"mvc.1.0.razor-page", @"/Pages/Invoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f51b9847a96a292bfc56e9be7e164670db6b516", @"/Pages/Invoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Invoice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f51b9847a96a292bfc56e9be7e164670db6b5163428", async() => {
                WriteLiteral("\r\n\r\n    <link rel=\"stylesheet\" href=\"https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css\" integrity=\"sha384-B0vP5xmATw1+K9KRQjQERJvTumQW0nPEzvF6L/Z6nronJ3oUOFUFpCjEUQouq2+l\" crossorigin=\"anonymous\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f51b9847a96a292bfc56e9be7e164670db6b5164624", async() => {
                WriteLiteral(@"

    <script src=""//code.jquery.com/jquery-1.10.2.js""></script>
    <script src=""//code.jquery.com/ui/1.11.2/jquery-ui.js""></script>
    <style>
        .pt-3-half {
            padding-top: 1.4rem;
        }
    </style>

    <!-- Editable table -->
    <div class=""card"">
        <h3 class=""card-header text-center font-weight-bold text-uppercase py-4"">
            Invoice
        </h3>
        <div class=""card-body"">
            <div id=""table"" class=""table-editable"">
                <span class=""table-add float-right mb-3 mr-2"">
                    <a href=""#!"" class=""text-success""><i class=""fas fa-plus fa-2x"" aria-hidden=""true""></i></a>
                </span>
                <table class=""table table-bordered table-responsive-md table-striped text-center invoice"" ");
                WriteLiteral(@">
                    <thead>

                        <tr>
                            <th class=""text-center"">Item Descreption</th>
                            <th class=""text-center"">Unit</th>
                            <th class=""text-center"" colspan=""3"">Quantity</th>
                            <th class=""text-center"">Unit Price</th>
                            <th class=""text-center"">Spending Ratio</th>
                            <th class=""text-center"">Total Cost</th>
                            <th class=""text-center"">Sort</th>
                            <th class=""text-center"">Remove</th>
                        </tr>
                        <tr>
                            <th class=""text-center"" colspan=""2""></th>
                            <th class=""text-center"">Precedent</th>
                            <th class=""text-center"">Current</th>
                            <th class=""text-center"">Total</th>
                            <th class=""text-center"" colspan=""5""></th>
   ");
                WriteLiteral("                     </tr>\r\n\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 57 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml"
                         foreach (var Item in Model.ItemsList.BOQs)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td class=\"pt-3-half\" contenteditable=\"true\">");
#nullable restore
#line 60 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml"
                                                                        Write(Item.Item_Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td class=\"pt-3-half\" contenteditable=\"true\">");
#nullable restore
#line 61 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml"
                                                                        Write(Item.Unit);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                <td class=""pt-3-half Precedent"" contenteditable=""true"" onblur=""calculatTotalCost()"">3</td>
                                <td class=""pt-3-half Current"" contenteditable=""true"" onblur=""calculatTotalCost()"">0</td>

                                <td class=""pt-3-half total"" contenteditable=""true"" ");
                WriteLiteral(">0</td>\r\n                                <td class=\"pt-3-half unitePrice\" contenteditable=\"true\" onblur=\"calculatTotalCost()\" ");
                WriteLiteral(">");
#nullable restore
#line 66 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml"
                                                                                                                                    Write(Item.Unit_Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                <td class=""pt-3-half"" contenteditable=""true"">100%</td>
                                <td class=""pt-3-half totalPrice"" contenteditable=""true"" id=""tPrice""></td>
                                <td class=""pt-3-half"">
                                    <span class=""table-up""><a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-up"" aria-hidden=""true""></i></a></span>
                                    <span class=""table-down""><a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-down"" aria-hidden=""true""></i></a></span>
                                </td>
                                <td>
                                    <span class=""table-remove"">
                                        <button type=""button""
                                                class=""btn btn-danger btn-rounded btn-sm my-0 waves-effect waves-light"" onblur=""calculatTotalCost()"">
                                            Remove
                          ");
                WriteLiteral("              </button>\r\n                                    </span>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 82 "F:\ITI\gradution project\Final submission\PSOFT\Psoft\Pages\Invoice.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>

                    <tfoot>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""2"">Total Cost Of Invoice</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""totalCost""></th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>

                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""2"">Discount Of Last Invoice</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""discount"" onblur=""calculatTotalCost()"">0</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>
                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""2"">Ne");
                WriteLiteral(@"t Cost Of Invoice</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""net""></th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>
                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">Business Insurance Discount</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">10%</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""bid"" onblur=""calculatTotalCost()"">0</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>

                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true""> Advanced Payment Discount</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">20%</th>
   ");
                WriteLiteral(@"                         <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""apd"" onblur=""calculatTotalCost()"">0</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>

                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""2"">Other Discounts</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""od"" onblur=""calculatTotalCost()"">0</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"">EGP</th>
                        </tr>
                        <tr>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""2"">Net Receivable</th>
                            <th class=""pt-3-half text-center"" contenteditable=""true"" colspan=""7"" id=""nr""></th>
                            <th class=""pt-3-half text-center"" contenteditable=""");
                WriteLiteral(@"true"">EGP</th>
                        </tr>
                        <a class=""btn btn-outline-primary calc"">Calculate Total Cost</a>

                    </tfoot>
                </table>
                <a class=""btn btn-outline-primary calc"">Calculate Total Cost</a>
            </div>
        </div>
    </div>
    <!-- Editable table -->

    <script>

        //You can make New row with all functions
        const $tableID = $('#table'); const $BTN = $('#export-btn'); const $EXPORT = $('#export');
        const newTr = `
<tr class=""hide"">
                                              <td class=""pt-3-half"" contenteditable=""true""></td>
                                              <td class=""pt-3-half"" contenteditable=""true""></td>
                                              <td class=""pt-3-half Precedent"" contenteditable=""true"" onblur=""calculatTotalCost()"">0</td>
                                              <td class=""pt-3-half Current"" contenteditable=""true"" onblur=""calculatTotalCos");
                WriteLiteral(@"t()"">0</td>
                                              <td class=""pt-3-half total"" contenteditable=""true"" onblur=""calculatTotalCost()"">0</td>
                                              <td class=""pt-3-half unitePrice"" contenteditable=""true"" onblur=""calculatTotalCost()"">0</td>
                                              <td class=""pt-3-half"" contenteditable=""true"">100%</td>
                                              <td class=""pt-3-half totalPrice"" contenteditable=""true"" id=""tPrice"">0</td>
                                              <td class=""pt-3-half"">
                                                <span class=""table-up""><a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-up"" aria-hidden=""true""></i></a></span>
                                                <span class=""table-down""><a href=""#!"" class=""indigo-text""><i class=""fas fa-long-arrow-alt-down"" aria-hidden=""true""></i></a></span>
                                              </td>
                                   ");
                WriteLiteral(@"           <td>
                                                <span class=""table-remove""><button
                                                    type=""button""
                                                    class=""btn btn-danger btn-rounded btn-sm my-0 waves-effect waves-light"" onblur=""calculatTotalCost()"">
                                                    Remove
                                                  </button></span>
                                              </td>
</tr>
`;

        $('.table-add').on('click', 'i', () => {
            const $clone = $tableID.find('tbodytr').last().clone(true).removeClass('hide table-line'); if ($tableID.find('tbody tr').length >= 0) {
                $('tbody').append(newTr); $tableID.find('table').append($clone);
            }
        });
        $tableID.on('click', '.table-remove', function () { $(this).parents('tr').detach(); });
        $tableID.on('click', '.table-up', function () { const $row = $(this).parents('tr'); if ($row.");
                WriteLiteral(@"index() === 0) { return; } $row.prev().before($row.get(0)); });
        $tableID.on('click', '.table-down', function () { const $row = $(this).parents('tr'); $row.next().after($row.get(0)); }); // A few jQuery helpers for exporting only jQuery.fn.pop = [].pop;
        jQuery.fn.shift = [].shift;
        $BTN.on('click', () => {
            const $rows = $tableID.find('tr:not(:hidden)'); const headers = []; const data = []; // Get the headers(add special header logic here)
            $($rows.shift()).find('th:not(:empty)').each(function () { headers.push($(this).text().toLowerCase()); }); // Turn all existing rows into a loopablearray
            $rows.each(function () {
                const $td = $(this).find('td'); const h = {}; // Use the headers from earlier to name our hash keys headers.
                forEach((header, i) => {
                    h[header] = $td.eq(i).text();
                });
                data.push(h);
            }); // Output the result
            $EXPORT.text(JSO");
                WriteLiteral(@"N.stringify(data));
        });





        //This function used to make Auto calculation for the whole Table with just move your mouse from the Table cell
        function calculatTotalCost() {
            $(function () {
                var Total= 0;
                var totalCost = 0;
                var discount = 0;
                var afterDiscounts = 0;
                $('.invoice tr').each(function (i) {
                    totalCost = parseFloat($(this).find('.Precedent').text()) + parseFloat($(this).find('.Current').text());
                    $(this).find('.total').text(totalCost);

                    var sum = parseFloat($(this).find('.total').text()) * parseFloat($(this).find('.unitePrice').text());
                    $(this).find('.totalPrice').text(sum);

                    Total += (+$(this).find('#tPrice').text());
                    $('.invoice tr ').find('#totalCost').text(Total);

                    discount = Total - parseFloat($('.invoice tr').find('#discoun");
                WriteLiteral(@"t').text());
                    $(this).find('#net').text(discount);

                    afterDiscounts = discount - (parseFloat($('.invoice tr').find('#bid').text()) + parseFloat($('.invoice tr').find('#apd').text()) + parseFloat($('.invoice tr').find('#od').text()));
                    $(this).find('#nr').text(afterDiscounts);
            });
        });
        }

        //This function used to make Auto calculation for the whole Table with just click on ""Calculate Total Cost"" button
         $('.calc').click(function () {
        var Total = 0;
        var discount = 0;
        var afterDiscounts = 0;
        var totalCost = 0;
             $('.invoice tr').each(function (i) {
                 totalCost = parseFloat($(this).find('.Precedent').text()) + parseFloat($(this).find('.Current').text());
                 $(this).find('.total').text(totalCost);

                 var sum = parseFloat($(this).find('.total').text()) * parseFloat($(this).find('.unitePrice').text());
           ");
                WriteLiteral(@"      $(this).find('.totalPrice').text(sum);

                 Total += (+$(this).find('#tPrice').text());
                 $('.invoice tr ').find('#totalCost').text(Total);

                 discount = Total - parseFloat($('.invoice tr').find('#discount').text());
                 $(this).find('#net').text(discount);

                 afterDiscounts = discount - (parseFloat($('.invoice tr').find('#bid').text()) + parseFloat($('.invoice tr').find('#apd').text()) + parseFloat($('.invoice tr').find('#od').text()));
                 $(this).find('#nr').text(afterDiscounts);
             });
        });


    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.InvoiceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.InvoiceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.InvoiceModel>)PageContext?.ViewData;
        public Psoft.Pages.InvoiceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
