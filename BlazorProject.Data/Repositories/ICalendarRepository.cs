using BlazorProject.Modles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    public interface ICalendarRepository
    {
        IEnumerable<CalendarDay> GetAllCalendarDays();
        CalendarDay GetCalendarDayById(int CalendarDay);
        CalendarDay AddCalendarDay(CalendarDay CalendarDay);
        CalendarDay UpdateCalendarDay(CalendarDay CalendarDay);
        void DeleteCalendarDay(int CalendarDayId);
    }
}
