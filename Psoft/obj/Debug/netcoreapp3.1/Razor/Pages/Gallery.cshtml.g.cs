#pragma checksum "E:\PSOFT FINAL\PSOFT\Psoft\Pages\Gallery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6bd4ce9aa3625df4f76e8d59d880f15a68e0641"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_Gallery), @"mvc.1.0.razor-page", @"/Pages/Gallery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6bd4ce9aa3625df4f76e8d59d880f15a68e0641", @"/Pages/Gallery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Gallery : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sortData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bd4ce9aa3625df4f76e8d59d880f15a68e06414033", async() => {
                WriteLiteral("\r\n\t<title> PSoft | Gallery</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bd4ce9aa3625df4f76e8d59d880f15a68e06415040", async() => {
                WriteLiteral(@"


			<!-- Content Header (Page header) -->
			<section class=""content-header"">
				<div class=""container-fluid"">
					<div class=""row mb-2"">
						<div class=""col-sm-6"">
							<h1>Gallery</h1>
						</div>
						<div class=""col-sm-6"">
							<ol class=""breadcrumb float-sm-right"">
								<li class=""breadcrumb-item""><a href=""#"">Home</a></li>
								<li class=""breadcrumb-item active"">Gallery</li>
							</ol>
						</div>
					</div>
				</div><!-- /.container-fluid -->
			</section>

			<!-- Main content -->
			<section class=""content"">
				<div class=""container-fluid"">
					<div class=""row"">
						<div class=""col-12"">
							<div class=""card card-primary"">
								<div class=""card-header"">
									<h4 class=""card-title"">FilterizR Gallery with Ekko Lightbox</h4>
								</div>
								<div class=""card-body"">
									<div>
										<div class=""btn-group w-100 mb-2"">
											<a class=""btn btn-info active"" href=""javascript:void(0)"" data-filter=""all""> All items </a>
						");
                WriteLiteral(@"					<a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""1""> Category 1 (WHITE) </a>
											<a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""2""> Category 2 (BLACK) </a>
											<a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""3""> Category 3 (COLORED) </a>
											<a class=""btn btn-info"" href=""javascript:void(0)"" data-filter=""4""> Category 4 (COLORED, BLACK) </a>
										</div>
										<div class=""mb-2"">
											<a class=""btn btn-secondary"" href=""javascript:void(0)"" data-shuffle> Shuffle items </a>
											<div class=""float-right"">
												<select class=""custom-select"" style=""width: auto;"" data-sortOrder>
													");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bd4ce9aa3625df4f76e8d59d880f15a68e06417129", async() => {
                    WriteLiteral(" Sort by Position ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6bd4ce9aa3625df4f76e8d59d880f15a68e06418390", async() => {
                    WriteLiteral(" Sort by Custom Data ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
												</select>
												<div class=""btn-group"">
													<a class=""btn btn-default"" href=""javascript:void(0)"" data-sortAsc> Ascending </a>
													<a class=""btn btn-default"" href=""javascript:void(0)"" data-sortDesc> Descending </a>
												</div>
											</div>
										</div>
									</div>
									<div>
										<div class=""filter-container p-0 row"">
											<div class=""filtr-item col-sm-2"" data-category=""1"" data-sort=""white sample"">
												<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=1"" data-toggle=""lightbox"" data-title=""sample 1 - white"">
													<img src=""https://via.placeholder.com/300/FFFFFF?text=1"" class=""img-fluid mb-2"" alt=""white sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""2, 4"" data-sort=""black sample"">
												<a href=""https://via.placeholder.com/1200/000000.png?text=2"" data-toggle=""lightbox"" data-title=""sample 2 - black"">
													<img src=""https://via.pla");
                WriteLiteral(@"ceholder.com/300/000000?text=2"" class=""img-fluid mb-2"" alt=""black sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""3, 4"" data-sort=""red sample"">
												<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=3"" data-toggle=""lightbox"" data-title=""sample 3 - red"">
													<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=3"" class=""img-fluid mb-2"" alt=""red sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""3, 4"" data-sort=""red sample"">
												<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=4"" data-toggle=""lightbox"" data-title=""sample 4 - red"">
													<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=4"" class=""img-fluid mb-2"" alt=""red sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""2, 4"" data-sort=""black sample"">
												<a href=""https://via.placeholder.com/1200/0");
                WriteLiteral(@"00000.png?text=5"" data-toggle=""lightbox"" data-title=""sample 5 - black"">
													<img src=""https://via.placeholder.com/300/000000?text=5"" class=""img-fluid mb-2"" alt=""black sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""1"" data-sort=""white sample"">
												<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=6"" data-toggle=""lightbox"" data-title=""sample 6 - white"">
													<img src=""https://via.placeholder.com/300/FFFFFF?text=6"" class=""img-fluid mb-2"" alt=""white sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""1"" data-sort=""white sample"">
												<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=7"" data-toggle=""lightbox"" data-title=""sample 7 - white"">
													<img src=""https://via.placeholder.com/300/FFFFFF?text=7"" class=""img-fluid mb-2"" alt=""white sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=");
                WriteLiteral(@"""2, 4"" data-sort=""black sample"">
												<a href=""https://via.placeholder.com/1200/000000.png?text=8"" data-toggle=""lightbox"" data-title=""sample 8 - black"">
													<img src=""https://via.placeholder.com/300/000000?text=8"" class=""img-fluid mb-2"" alt=""black sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""3, 4"" data-sort=""red sample"">
												<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=9"" data-toggle=""lightbox"" data-title=""sample 9 - red"">
													<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=9"" class=""img-fluid mb-2"" alt=""red sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""1"" data-sort=""white sample"">
												<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=10"" data-toggle=""lightbox"" data-title=""sample 10 - white"">
													<img src=""https://via.placeholder.com/300/FFFFFF?text=10"" class=""img-fluid mb-2"" alt=""white samp");
                WriteLiteral(@"le"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""1"" data-sort=""white sample"">
												<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=11"" data-toggle=""lightbox"" data-title=""sample 11 - white"">
													<img src=""https://via.placeholder.com/300/FFFFFF?text=11"" class=""img-fluid mb-2"" alt=""white sample"" />
												</a>
											</div>
											<div class=""filtr-item col-sm-2"" data-category=""2, 4"" data-sort=""black sample"">
												<a href=""https://via.placeholder.com/1200/000000.png?text=12"" data-toggle=""lightbox"" data-title=""sample 12 - black"">
													<img src=""https://via.placeholder.com/300/000000?text=12"" class=""img-fluid mb-2"" alt=""black sample"" />
												</a>
											</div>
										</div>
									</div>

								</div>
							</div>
						</div>
						<div class=""col-12"">
							<div class=""card card-primary"">
								<div class=""card-header"">
									<h4 class=""card-title"">Ekko Lightbox");
                WriteLiteral(@"</h4>
								</div>
								<div class=""card-body"">
									<div class=""row"">
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=1"" data-toggle=""lightbox"" data-title=""sample 1 - white"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FFFFFF?text=1"" class=""img-fluid mb-2"" alt=""white sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/000000.png?text=2"" data-toggle=""lightbox"" data-title=""sample 2 - black"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/000000?text=2"" class=""img-fluid mb-2"" alt=""black sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=3"" data-toggle=""lightbox"" data-title=""sample 3 - red"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=3"" class=""");
                WriteLiteral(@"img-fluid mb-2"" alt=""red sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=4"" data-toggle=""lightbox"" data-title=""sample 4 - red"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=4"" class=""img-fluid mb-2"" alt=""red sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/000000.png?text=5"" data-toggle=""lightbox"" data-title=""sample 5 - black"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/000000?text=5"" class=""img-fluid mb-2"" alt=""black sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=6"" data-toggle=""lightbox"" data-title=""sample 6 - white"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FFFFFF?text=6"" class=""img-fluid mb-2");
                WriteLiteral(@""" alt=""white sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=7"" data-toggle=""lightbox"" data-title=""sample 7 - white"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FFFFFF?text=7"" class=""img-fluid mb-2"" alt=""white sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/000000.png?text=8"" data-toggle=""lightbox"" data-title=""sample 8 - black"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/000000?text=8"" class=""img-fluid mb-2"" alt=""black sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FF0000/FFFFFF.png?text=9"" data-toggle=""lightbox"" data-title=""sample 9 - red"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FF0000/FFFFFF?text=9"" class=""img-fluid mb-2"" alt=""red");
                WriteLiteral(@" sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=10"" data-toggle=""lightbox"" data-title=""sample 10 - white"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FFFFFF?text=10"" class=""img-fluid mb-2"" alt=""white sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/FFFFFF.png?text=11"" data-toggle=""lightbox"" data-title=""sample 11 - white"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/FFFFFF?text=11"" class=""img-fluid mb-2"" alt=""white sample"" />
											</a>
										</div>
										<div class=""col-sm-2"">
											<a href=""https://via.placeholder.com/1200/000000.png?text=12"" data-toggle=""lightbox"" data-title=""sample 12 - black"" data-gallery=""gallery"">
												<img src=""https://via.placeholder.com/300/000000?text=12"" class=""img-fluid mb-2"" alt=""black sample"" />
");
                WriteLiteral(@"											</a>
										</div>
									</div>
								</div>
							</div>
						</div>
					</div>
				</div><!-- /.container-fluid -->
			</section>
			<!-- /.content -->
		
		<!-- /.content-wrapper -->

		
	<script>
  $(function () {
    $(document).on('click', '[data-toggle=""lightbox""]', function(event) {
      event.preventDefault();
      $(this).ekkoLightbox({
        alwaysShowClose: true
      });
    });

    $('.filter-container').filterizr({gutterPixels: 3});
    $('.btn[data-filter]').on('click', function() {
      $('.btn[data-filter]').removeClass('active');
      $(this).addClass('active');
    });
  })
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.GalleryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.GalleryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.GalleryModel>)PageContext?.ViewData;
        public Psoft.Pages.GalleryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
