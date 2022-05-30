#pragma checksum "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02929a2d8c71322a8cfa2fbbb7620013e2f84b1c"
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
#line 1 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using BlazorProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using BlazorProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using BlazorProject.Modles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\_Imports.razor"
using BlazorProject.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Weather forecast</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server.</p>\n\n");
#nullable restore
#line 8 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
 if (forecasts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\n");
#nullable restore
#line 11 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\n        ");
            __builder.AddMarkupContent(8, "<thead>\n            <tr>\n                <th>Date</th>\n                <th>Temp. (C)</th>\n                <th>Temp. (F)</th>\n                <th>Summary</th>\n            </tr>\n        </thead>\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 24 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
             foreach (var forecast in forecasts)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
                         forecast.Date.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
                         forecast.TemperatureC

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
                         forecast.TemperatureF

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 30 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
                         forecast.Summary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 32 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 35 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Pages\FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
