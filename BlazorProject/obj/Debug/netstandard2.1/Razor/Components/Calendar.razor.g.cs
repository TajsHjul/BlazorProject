#pragma checksum "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83e6414ab7c763b1fb2832b1f0a04d501a91d714"
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
            __builder.AddMarkupContent(0, "<h3>Calendar</h3>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenElement(3, "body");
            __builder.AddMarkupContent(4, "\n\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\n\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-sm-12 col-lg-9");
            __builder.AddMarkupContent(10, "\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "calendar");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-sm-12 col-1g-2");
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "select");
            __builder.AddAttribute(18, "name", "");
            __builder.AddAttribute(19, "id", "");
            __builder.AddAttribute(20, "class", "fluent-input");
            __builder.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                                                          SelectYear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(22, "\n");
#nullable restore
#line 14 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                         for (int i = 2018; i < 2023; i++)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                            ");
            __builder.OpenElement(24, "option");
            __builder.AddContent(25, 
#nullable restore
#line 16 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                     i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n");
#nullable restore
#line 17 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n\n                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "col-sm-12 col-1g-2");
            __builder.AddMarkupContent(32, "\n                    ");
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "name", "");
            __builder.AddAttribute(35, "id", "");
            __builder.AddAttribute(36, "class", "fluent-input");
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                                                          SelectMonth

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(38, "\n                        ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "1");
            __builder.AddContent(41, "January");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                        ");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "2");
            __builder.AddContent(45, "February");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n                        ");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "3");
            __builder.AddContent(49, "March");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n                        ");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "4");
            __builder.AddContent(53, "April");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\n                        ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "5");
            __builder.AddContent(57, "May");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n                        ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "6");
            __builder.AddContent(61, "June");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\n                        ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "7");
            __builder.AddContent(65, "July");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\n                        ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "8");
            __builder.AddContent(69, "August");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\n                        ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "9");
            __builder.AddContent(73, "September");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n                        ");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "10");
            __builder.AddContent(77, "October");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\n                        ");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "value", "11");
            __builder.AddContent(81, "November");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n                        ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "12");
            __builder.AddContent(85, "December");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\n\n                ");
            __builder.OpenElement(89, "table");
            __builder.AddAttribute(90, "class", "calendar-table");
            __builder.AddMarkupContent(91, "\n                    ");
            __builder.AddMarkupContent(92, @"<thead>
                        <tr>
                            <td>Sun</td>
                            <td>Mon</td>
                            <td>Tue</td>
                            <td>Wed</td>
                            <td>Thu</td>
                            <td>Fri</td>
                            <td>Sat</td>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(93, "tbody");
            __builder.AddMarkupContent(94, "\n");
#nullable restore
#line 51 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                         for (int r = 0; r < rowsCount; r++)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(95, "                            ");
            __builder.OpenElement(96, "tr");
            __builder.AddMarkupContent(97, "\n                                \n");
#nullable restore
#line 55 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                 foreach (var item in days.Skip(r * 7).Take(7))
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(98, "                                ");
            __builder.OpenElement(99, "td");
            __builder.AddContent(100, " ");
            __builder.AddContent(101, 
#nullable restore
#line 57 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                      DayTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\n");
#nullable restore
#line 58 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(103, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\n");
#nullable restore
#line 60 "C:\Users\Tajs\Desktop\BlazorProject-Nichlas-TestBranch - 3\BlazorProject-Nichlas-TestBranch\BlazorProject\Components\Calendar.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(105, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\n\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\n\n\n        \n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\n");
            __builder.CloseElement();
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