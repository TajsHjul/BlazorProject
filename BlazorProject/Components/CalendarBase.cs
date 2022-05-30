using BlazorProject.Modles;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProject.Components
{
    public class CalendarBase : ComponentBase
    {

        [Parameter]
        public RenderFragment<CalendarDay> DayTemplate { get; set; }

        private int year = 2022;
        private int month = 05;

        protected List<CalendarDay> days = new List<CalendarDay>();
        protected int rowsCount = 0;

        protected void SelectYear(ChangeEventArgs e)
        {
            year = Convert.ToInt32(e.Value.ToString());
            //Refresh Calendar
            UpdateCalendar();
        }

        protected void SelectMonth(ChangeEventArgs e)
        {
            month = Convert.ToInt32(e.Value.ToString());
            //Refresh Month
            UpdateCalendar();
        }

        protected void UpdateCalendar()
        {
            days = new List<CalendarDay>();

            //Calculate number of empty days
            var firstDayDate = new DateTime(year, month, 1);

            int weekDayNumber = (int)firstDayDate.DayOfWeek;

            int numberOfEmptyDays = 0;

            if (weekDayNumber == 7)//Sunday
            {
                numberOfEmptyDays = 0;
            }
            else
            {
                numberOfEmptyDays = weekDayNumber;
            }

            for (int i = 0; i < numberOfEmptyDays; i++)
            {
                days.Add(new CalendarDay
                {
                    DayNumber = 0,
                    IsEmpty = true
                });
            }

            int numberOfDaysInMonth = DateTime.DaysInMonth(year, month);

            for (int i = 0; i < numberOfDaysInMonth; i++)
            {
                days.Add(new CalendarDay
                {
                    DayNumber = i + 1,
                    IsEmpty = false,
                    Date = new DateTime(year, month, i + 1)
                });
            }

            //calculate number of rows

            int remaining = days.Count % 7;
            if (remaining == 0)
                rowsCount = days.Count / 7;
            else
                rowsCount = Convert.ToInt32(days.Count / 7) + 1;

            Console.WriteLine($"Total Rows: {rowsCount} | Number of Empty Days {numberOfEmptyDays} | Month Days {numberOfDaysInMonth}");

        }
    }
}
