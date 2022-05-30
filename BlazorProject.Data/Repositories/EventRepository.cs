using BlazorProject.Data.Contexts;
using BlazorProject.Modles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    
    public class EventRepository : IEventRepository
    {
        private readonly CalendarEventContext _calendarEventContext;

        public EventRepository(CalendarEventContext calendarEventContext)
        {
            _calendarEventContext = calendarEventContext;
        }

        public IEnumerable<CalendarEvent> GetAllCalendarEvents()
        {
            return _calendarEventContext.CalendarEvents;
        }

        public CalendarEvent GetCalendarEventById(int calendarEventId)
        {
            var calendarEvent = _calendarEventContext.CalendarEvents
                .Include(x => x.Subject)
                
                .FirstOrDefault(c => c.Id == calendarEventId);
            return calendarEvent;
        }

        public CalendarEvent AddCalendarEvent(CalendarEvent calendarEvent)
        {
            var addedEntity = _calendarEventContext.CalendarEvents.Add(calendarEvent);
            _calendarEventContext.SaveChanges();
            return addedEntity.Entity;
        }

        public CalendarEvent UpdateCalendarEvent(CalendarEvent calendarEvent)
        {
            var foundCalendarEvent = _calendarEventContext.CalendarEvents.FirstOrDefault(e => e.Id == calendarEvent.Id);

            if (foundCalendarEvent != null)
            {
                foundCalendarEvent.Subject = calendarEvent.Subject;
                foundCalendarEvent.StartDate = calendarEvent.StartDate;
                foundCalendarEvent.EndDate = calendarEvent.EndDate;
               
                

                _calendarEventContext.SaveChanges();

                return foundCalendarEvent;
            }

            return null;
        }

        public void DeleteCalendarEvent(int calendarEventId)
        {
            var foundCalendarEvent = _calendarEventContext.CalendarEvents.FirstOrDefault(e => e.Id == calendarEventId);
            if (foundCalendarEvent == null) return;

            _calendarEventContext.CalendarEvents.Remove(foundCalendarEvent);
            _calendarEventContext.SaveChanges();
        }
    }
}

