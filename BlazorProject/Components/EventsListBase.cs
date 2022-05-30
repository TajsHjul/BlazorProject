using BlazorProject.Modles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Components
{
    public class EventsListBase : ComponentBase
    {
        [Parameter]
        public CalendarDay SelectedDay { get; set; }

        protected void ExportToICS()
        {

            foreach (var item in SelectedDay.Events)
            {
                Console.WriteLine($"Test data {SelectedDay.Events.Count} | {item.StartDate} | {item.EndDate}  | {item.Subject}");
            }



        }
    }
}
