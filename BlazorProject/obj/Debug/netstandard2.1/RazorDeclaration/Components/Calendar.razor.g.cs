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
    public partial class Calendar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 117 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
         

[Parameter]
public RenderFragment<CalendarDay> DayTemplate{get;set;}

private int year=2022;
private int month=05;

private List<CalendarDay> days=new List<CalendarDay>();
private int rowsCount=0;

void SelectYear(ChangeEventArgs e){
  year=Convert.ToInt32(e.Value.ToString());
  //Refresh Calendar
  UpdateCalendar();
}

void SelectMonth(ChangeEventArgs e){
  month=Convert.ToInt32(e.Value.ToString());
  //Refresh Month
  UpdateCalendar();
}

void UpdateCalendar(){
  days=new List<CalendarDay>();

    //Calculate number of empty days
    var firstDayDate=new DateTime(year,month,1);

    int weekDayNumber=(int)firstDayDate.DayOfWeek;

    int numberOfEmptyDays=0;

    if(weekDayNumber==7)//Sunday
    {
        numberOfEmptyDays=0;
    }
    else
    {
        numberOfEmptyDays=weekDayNumber;
    }

    for(int i=0;i<numberOfEmptyDays;i++){
        days.Add(new CalendarDay{
            DayNumber=0,
            IsEmpty=true
        });
    }

    int numberOfDaysInMonth=DateTime.DaysInMonth(year,month);

    for(int i=0;i<numberOfDaysInMonth;i++){
        days.Add(new CalendarDay{
            DayNumber=i+1,
            IsEmpty=false,
            Date=new DateTime(year,month, i+1)
        });
    }

    //calculate number of rows

    int remaining=days.Count%7;
    if(remaining==0)
        rowsCount=days.Count/7;
    else
    rowsCount=Convert.ToInt32(days.Count/7)+1;
    
    Console.WriteLine($"Total Rows: {rowsCount} | Number of Empty Days {numberOfEmptyDays} | Month Days {numberOfDaysInMonth}");

}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
