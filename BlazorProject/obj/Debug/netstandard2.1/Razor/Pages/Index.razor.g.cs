#pragma checksum "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5402d98cc33aaa7e9898ab57d4fafb4571108fd6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorProject.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject.Modles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\_Imports.razor"
using BlazorProject.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-sm-12 col-md-12 col-lg-9");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenComponent<BlazorProject.Components.Calendar>(6);
            __builder.AddAttribute(7, "DayTemplate", (Microsoft.AspNetCore.Components.RenderFragment<BlazorProject.Modles.CalendarDay>)((day) => (__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 9 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                  
                    string currentDayClass = day.Date == DateTime.Now.Date ? "current-day" : "";
                    string selectedDayClass = day == selectedDay ? "selected-day" : "";

                

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(9, "\r\n");
#nullable restore
#line 15 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                 if (!day.IsEmpty)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(10, "                    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "day" + " shadow-effect" + " " + (
#nullable restore
#line 17 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                                                   currentDayClass

#line default
#line hidden
#nullable disable
                ) + " " + (
#nullable restore
#line 17 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                                                                    selectedDayClass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                                                                                                ()=>selectedDay=day

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(14, "\r\n                        ");
                __builder2.OpenElement(15, "h3");
                __builder2.AddAttribute(16, "class", "ms-fontSize-24 ms-fontWeight-regular");
                __builder2.AddContent(17, 
#nullable restore
#line 18 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                                                                          day.DayNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n");
#nullable restore
#line 20 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(20, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-12 col-md-12 col-lg-3");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenComponent<BlazorProject.Components.AddEvent>(26);
            __builder.AddAttribute(27, "SelectedDay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorProject.Modles.CalendarDay>(
#nullable restore
#line 26 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                               selectedDay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n        ");
            __builder.OpenComponent<BlazorProject.Components.EventsList>(29);
            __builder.AddAttribute(30, "SelectedDay", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorProject.Modles.CalendarDay>(
#nullable restore
#line 28 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
                                 selectedDay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Pages\Index.razor"
      
    private CalendarDay selectedDay = new CalendarDay
    {
        Date = DateTime.Now
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
