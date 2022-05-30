// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProject.Components
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
    public partial class AddEvent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\AddEvent.razor"
       

    [Parameter]
    public CalendarDay SelectedDay { get; set; }

    private CalendarEvent model = new CalendarEvent();

    private void AddEventToSelectedDay()
    {
        //Convert time within the selected day
        model.StartDate = new DateTime(SelectedDay.Date.Year,
            SelectedDay.Date.Month,
            SelectedDay.Date.Day,
            model.StartDate.Hour,
            model.StartDate.Minute,
            0);

        model.EndDate = new DateTime(SelectedDay.Date.Year,
            SelectedDay.Date.Month,
            SelectedDay.Date.Day,
            model.EndDate.Hour,
            model.EndDate.Minute,
            0);

        if (SelectedDay.Events == null)
            SelectedDay.Events = new List<CalendarEvent>();

        SelectedDay.Events.Add(new CalendarEvent
        {
            Subject=model.Subject,
            StartDate=model.StartDate,
            EndDate=model.EndDate
        });
        Console.WriteLine($"Total Events in Day {SelectedDay.Events.Count} | {model.Subject} | {model.StartDate} | {model.EndDate}");
        model = new CalendarEvent();

    }

   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
