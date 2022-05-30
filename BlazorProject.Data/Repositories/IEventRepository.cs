using BlazorProject.Modles;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    interface IEventRepository
    {
        IEnumerable<CalendarEvent> GetAllCalendarEvents();
        CalendarEvent GetCalendarEventById(int employeeId);
        CalendarEvent AddCalendarEvent(CalendarEvent calenderEvent);
        CalendarEvent UpdateCalendarEvent(CalendarEvent calenderEvent);
        void DeleteCalendarEvent(int calenderEventId);
    }
}
