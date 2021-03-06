#pragma checksum "E:\PSOFT FINAL\PSOFT\Psoft\Pages\Calendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "772b0b4f7ff3e9c8bb622b83ea3659f44c644fbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Psoft.Pages.Pages_Calendar), @"mvc.1.0.razor-page", @"/Pages/Calendar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"772b0b4f7ff3e9c8bb622b83ea3659f44c644fbc", @"/Pages/Calendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b20578ff2bc0f330113957cac6f714775a8f096", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Calendar : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772b0b4f7ff3e9c8bb622b83ea3659f44c644fbc3681", async() => {
                WriteLiteral(@"
	<meta charset=""utf-8"">
	<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
	<title>Psoft| Calendar</title>

	<!-- Google Font: Source Sans Pro -->
	<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
	<!-- Font Awesome -->
	<link rel=""stylesheet"" href=""../plugins/fontawesome-free/css/all.min.css"">
	<!-- fullCalendar -->
	<link rel=""stylesheet"" href=""../plugins/fullcalendar/main.css"">
	<!-- Theme style -->
	<link rel=""stylesheet"" href=""../dist/css/adminlte.min.css"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "772b0b4f7ff3e9c8bb622b83ea3659f44c644fbc5238", async() => {
                WriteLiteral(@"
	
			<!-- Content Header (Page header) -->
			<section class=""content-header"">
				<div class=""container-fluid"">
					<div class=""row mb-2"">
						<div class=""col-sm-6"">
							<h1>Calendar</h1>
						</div>
						<div class=""col-sm-6"">
							<ol class=""breadcrumb float-sm-right"">
								<li class=""breadcrumb-item""><a href=""#"">Home</a></li>
								<li class=""breadcrumb-item active"">Calendar</li>
							</ol>
						</div>
					</div>
				</div><!-- /.container-fluid -->
			</section>

			<!-- Main content -->
			<section class=""content"">
				<div class=""container-fluid"">
					<div class=""row"">
						<div class=""col-md-3"">
							<div class=""sticky-top mb-3"">
								<div class=""card"">
									<div class=""card-header"">
										<h4 class=""card-title"">Draggable Events</h4>
									</div>
									<div class=""card-body"">
										<!-- the events -->
										<div id=""external-events"">
											<div class=""external-event bg-success"">Lunch</div>
											<div class=""ext");
                WriteLiteral(@"ernal-event bg-warning"">Go home</div>
											<div class=""external-event bg-info"">Do homework</div>
											<div class=""external-event bg-primary"">Work on UI design</div>
											<div class=""external-event bg-danger"">Sleep tight</div>
											<div class=""checkbox"">
												<label for=""drop-remove"">
													<input type=""checkbox"" id=""drop-remove"">
													remove after drop
												</label>
											</div>
										</div>
									</div>
									<!-- /.card-body -->
								</div>
								<!-- /.card -->
								<div class=""card"">
									<div class=""card-header"">
										<h3 class=""card-title"">Create Event</h3>
									</div>
									<div class=""card-body"">
										<div class=""btn-group"" style=""width: 100%; margin-bottom: 10px;"">
											<ul class=""fc-color-picker"" id=""color-chooser"">
												<li><a class=""text-primary"" href=""#""><i class=""fas fa-square""></i></a></li>
												<li><a class=""text-warning"" href=""#""><i class=""fas fa-square"">");
                WriteLiteral(@"</i></a></li>
												<li><a class=""text-success"" href=""#""><i class=""fas fa-square""></i></a></li>
												<li><a class=""text-danger"" href=""#""><i class=""fas fa-square""></i></a></li>
												<li><a class=""text-muted"" href=""#""><i class=""fas fa-square""></i></a></li>
											</ul>
										</div>
										<!-- /btn-group -->
										<div class=""input-group"">
											<input id=""new-event"" type=""text"" class=""form-control"" placeholder=""Event Title"">

											<div class=""input-group-append"">
												<button id=""add-new-event"" type=""button"" class=""btn btn-primary"">Add</button>
											</div>
											<!-- /btn-group -->
										</div>
										<!-- /input-group -->
									</div>
								</div>
							</div>
						</div>
						<!-- /.col -->
						<div class=""col-md-9"">
							<div class=""card card-primary"">
								<div class=""card-body p-0"">
									<!-- THE CALENDAR -->
									<div id=""calendar""></div>
								</div>
								<!-- /.card-body -->
		");
                WriteLiteral(@"					</div>
							<!-- /.card -->
						</div>
						<!-- /.col -->
					</div>
					<!-- /.row -->
				</div><!-- /.container-fluid -->
			</section>
			<!-- /.content -->
		
		<!-- /.content-wrapper -->


		<!-- Control Sidebar -->
		<aside class=""control-sidebar control-sidebar-dark"">
			<!-- Control sidebar content goes here -->
		</aside>

	<!-- ./wrapper -->
	<!-- jQuery -->
	<script src=""../plugins/jquery/jquery.min.js""></script>
	<!-- Bootstrap -->
	<script src=""../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
	<!-- jQuery UI -->
	<script src=""../plugins/jquery-ui/jquery-ui.min.js""></script>
	<!-- AdminLTE App -->
	<script src=""../dist/js/adminlte.min.js""></script>
	<!-- fullCalendar 2.2.5 -->
	<script src=""../plugins/moment/moment.min.js""></script>
	<script src=""../plugins/fullcalendar/main.js""></script>
	<!-- AdminLTE for demo purposes -->
	<script src=""../dist/js/demo.js""></script>
	<!-- Page specific script -->
	<script>
		$(function () {

			/* initi");
                WriteLiteral(@"alize the external events
			 -----------------------------------------------------------------*/
			function ini_events(ele) {
				ele.each(function () {

					// create an Event Object (https://fullcalendar.io/docs/event-object)
					// it doesn't need to have a start or end
					var eventObject = {
						title: $.trim($(this).text()) // use the element's text as the event title
					}

					// store the Event Object in the DOM element so we can get to it later
					$(this).data('eventObject', eventObject)

					// make the event draggable using jQuery UI
					$(this).draggable({
						zIndex: 1070,
						revert: true, // will cause the event to go back to its
						revertDuration: 0  //  original position after the drag
					})

				})
			}

			ini_events($('#external-events div.external-event'))

			/* initialize the calendar
			 -----------------------------------------------------------------*/
			//Date for the calendar events (dummy data)
			var date = new Date()
			var d");
                WriteLiteral(@" = date.getDate(),
				m = date.getMonth(),
				y = date.getFullYear()

			var Calendar = FullCalendar.Calendar;
			var Draggable = FullCalendar.Draggable;

			var containerEl = document.getElementById('external-events');
			var checkbox = document.getElementById('drop-remove');
			var calendarEl = document.getElementById('calendar');

			// initialize the external events
			// -----------------------------------------------------------------

			new Draggable(containerEl, {
				itemSelector: '.external-event',
				eventData: function (eventEl) {
					return {
						title: eventEl.innerText,
						backgroundColor: window.getComputedStyle(eventEl, null).getPropertyValue('background-color'),
						borderColor: window.getComputedStyle(eventEl, null).getPropertyValue('background-color'),
						textColor: window.getComputedStyle(eventEl, null).getPropertyValue('color'),
					};
				}
			});

			var calendar = new Calendar(calendarEl, {
				headerToolbar: {
					left: 'prev,next today',");
                WriteLiteral(@"
					center: 'title',
					right: 'dayGridMonth,timeGridWeek,timeGridDay'
				},
				themeSystem: 'bootstrap',
				//Random default events
				events: [
					{
						title: 'All Day Event',
						start: new Date(y, m, 1),
						backgroundColor: '#f56954', //red
						borderColor: '#f56954', //red
						allDay: true
					},
					{
						title: 'Long Event',
						start: new Date(y, m, d - 5),
						end: new Date(y, m, d - 2),
						backgroundColor: '#f39c12', //yellow
						borderColor: '#f39c12' //yellow
					},
					{
						title: 'Meeting',
						start: new Date(y, m, d, 10, 30),
						allDay: false,
						backgroundColor: '#0073b7', //Blue
						borderColor: '#0073b7' //Blue
					},
					{
						title: 'Lunch',
						start: new Date(y, m, d, 12, 0),
						end: new Date(y, m, d, 14, 0),
						allDay: false,
						backgroundColor: '#00c0ef', //Info (aqua)
						borderColor: '#00c0ef' //Info (aqua)
					},
					{
						title: 'Birthday Party',
						start: new Date(y, m, ");
                WriteLiteral(@"d + 1, 19, 0),
						end: new Date(y, m, d + 1, 22, 30),
						allDay: false,
						backgroundColor: '#00a65a', //Success (green)
						borderColor: '#00a65a' //Success (green)
					},
					{
						title: 'Click for Google',
						start: new Date(y, m, 28),
						end: new Date(y, m, 29),
						url: 'https://www.google.com/',
						backgroundColor: '#3c8dbc', //Primary (light-blue)
						borderColor: '#3c8dbc' //Primary (light-blue)
					}
				],
				editable: true,
				droppable: true, // this allows things to be dropped onto the calendar !!!
				drop: function (info) {
					// is the ""remove after drop"" checkbox checked?
					if (checkbox.checked) {
						// if so, remove the element from the ""Draggable Events"" list
						info.draggedEl.parentNode.removeChild(info.draggedEl);
					}
				}
			});

			calendar.render();
			// $('#calendar').fullCalendar()

			/* ADDING EVENTS */
			var currColor = '#3c8dbc' //Red by default
			// Color chooser button
			$('#color-chooser > li > ");
                WriteLiteral(@"a').click(function (e) {
				e.preventDefault()
				// Save color
				currColor = $(this).css('color')
				// Add color effect to button
				$('#add-new-event').css({
					'background-color': currColor,
					'border-color': currColor
				})
			})
			$('#add-new-event').click(function (e) {
				e.preventDefault()
				// Get value and make sure it is not null
				var val = $('#new-event').val()
				if (val.length == 0) {
					return
				}

				// Create events
				var event = $('<div />')
				event.css({
					'background-color': currColor,
					'border-color': currColor,
					'color': '#fff'
				}).addClass('external-event')
				event.text(val)
				$('#external-events').prepend(event)

				// Add draggable funtionality
				ini_events(event)

				// Remove event from text input
				$('#new-event').val('')
			})
		})
	</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Psoft.Pages.CalendarModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.CalendarModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Psoft.Pages.CalendarModel>)PageContext?.ViewData;
        public Psoft.Pages.CalendarModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
