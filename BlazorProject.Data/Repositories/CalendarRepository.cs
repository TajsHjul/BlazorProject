using BlazorProject.Data.Contexts;
using BlazorProject.Modles;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorProject.Data.Repositories
{
    public class CalendarRepository : ICalendarRepository
    {
        private readonly CalendarEventContext _CalendarDayContext;

        public CalendarRepository(CalendarEventContext CalendarDayContext)
        {
            _CalendarDayContext = CalendarDayContext;
        }

        public IEnumerable<CalendarDay> GetAllCalendarDays()
        {
            return _CalendarDayContext.CalendarDays;
        }

        public CalendarDay GetCalendarDayById(int CalendarDayId)
        {
            var CalendarDay = _CalendarDayContext.CalendarDays
                .Include(x => x.Date)

                .FirstOrDefault(c => c.Id == CalendarDayId);
            return CalendarDay;
        }

        public CalendarDay AddCalendarDay(CalendarDay CalendarDay)
        {
            var addedEntity = _CalendarDayContext.CalendarDays.Add(CalendarDay);
            _CalendarDayContext.SaveChanges();
            return addedEntity.Entity;
        }

        public CalendarDay UpdateCalendarDay(CalendarDay CalendarDay)
        {
            var foundCalendarDay = _CalendarDayContext.CalendarDays.FirstOrDefault(e => e.Id == CalendarDay.Id);

            if (foundCalendarDay != null)
            {
                foundCalendarDay.Date = CalendarDay.Date;
                foundCalendarDay.DayNumber = CalendarDay.DayNumber;

                _CalendarDayContext.SaveChanges();

                return foundCalendarDay;
            }

            return null;
        }

        public void DeleteCalendarDay(int CalendarDayId)
        {
            var foundCalendarDay = _CalendarDayContext.CalendarDays.FirstOrDefault(e => e.Id == CalendarDayId);
            if (foundCalendarDay == null) return;

            _CalendarDayContext.CalendarDays.Remove(foundCalendarDay);
            _CalendarDayContext.SaveChanges();
        }
    }
}
