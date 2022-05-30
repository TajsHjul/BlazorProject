using BlazorProject.Models;
using BlazorProject.Modles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Components
{
    public class AddEventBase: ComponentBase
    {
        [Parameter]
        public CalendarDay SelectedDay { get; set; }

        protected CalendarEvent model = new CalendarEvent();     

        

        protected void AddEventToSelectedDay()
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
               
                Subject = model.Subject,
                StartDate = model.StartDate,
                EndDate = model.EndDate                
            });
            Console.WriteLine($"Total Events in Day {SelectedDay.Events.Count} | {model.Subject} | {model.StartDate} | {model.EndDate}");
            model = new CalendarEvent();

        }
    }
}
