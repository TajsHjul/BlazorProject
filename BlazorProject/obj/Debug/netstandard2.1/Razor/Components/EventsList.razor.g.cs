#pragma checksum "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "802feb67ab7db522fddf59cf0dd5017204d1aff7"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class EventsList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "ms-depth-16 card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                     SelectedDay

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                                                 ExportToICS

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "card-content");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.AddMarkupContent(11, "<button class=\"toolbar-button\" type=\"submit\" download=\"Events.ics\">Export to ICS file</button>\r\n        ");
                __builder2.OpenElement(12, "h3");
                __builder2.AddAttribute(13, "class", "ms-fontSize-14 msfontWeight-regular");
                __builder2.AddContent(14, 
#nullable restore
#line 7 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                                                         SelectedDay.Date.ToString("D")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n");
#nullable restore
#line 8 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
          
            if (SelectedDay.Events == null || SelectedDay.Events.Count == 0)
            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(16, "                ");
                __builder2.AddMarkupContent(17, "<h3 class=\"ms-fontSize-14 msfontWeight-regular\">No Events</h3>\r\n");
#nullable restore
#line 12 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
            }
            else
            {
                foreach (var item in SelectedDay.Events)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(18, "                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "event shadow-effect");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "h3");
                __builder2.AddAttribute(23, "class", "ms-fontSize-14 msfontWeight-regular");
                __builder2.AddContent(24, 
#nullable restore
#line 18 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                                                                         item.StartDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(25, " to ");
                __builder2.AddContent(26, 
#nullable restore
#line 18 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                                                                                                              item.EndDate.ToString("HH:mm")

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenElement(28, "p");
                __builder2.AddAttribute(29, "class", "ms-fontSize-11 ms-fontWeight-regular");
                __builder2.AddContent(30, 
#nullable restore
#line 19 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                                                                         item.Subject

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n");
#nullable restore
#line 21 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
                }

            }
        

#line default
#line hidden
#nullable disable
                __builder2.AddContent(33, "    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\rulle\Documents\GitHub\BlazorProject\BlazorProject\Components\EventsList.razor"
       
    [Parameter]
    public CalendarDay SelectedDay { get; set; }



    private void ExportToICS()
    {

        foreach (var item in SelectedDay.Events)
        {
            Console.WriteLine($"Test data {SelectedDay.Events.Count} | {item.StartDate} | {item.EndDate}  | {item.Subject}");
        }

         

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
