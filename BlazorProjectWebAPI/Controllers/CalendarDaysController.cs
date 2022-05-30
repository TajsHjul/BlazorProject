using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlazorProject.Data.Contexts;
using BlazorProject.Modles;

namespace BlazorProjectWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalendarDaysController : Controller
    {
        private readonly CalendarEventContext _context;

        public CalendarDaysController(CalendarEventContext context)
        {
            _context = context;
        }

        // GET: api/CalendarDays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarDay>>> GetCalendarDays()
        {
            return await _context.CalendarDays.ToListAsync();
        }

        // GET: api/CalendarDays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarDay>> GetCalendarDay(int id)
        {
            var calendarDay = await _context.CalendarDays.FindAsync(id);

            if (calendarDay == null)
            {
                return NotFound();
            }

            return calendarDay;
        }

        // PUT: api/CalendarDays/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarDay(int id, CalendarDay calendarDay)
        {
            if (id != calendarDay.Id)
            {
                return BadRequest();
            }

            _context.Entry(calendarDay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarDayExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/CalendarDays
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CalendarDay>> PostCalendarDay(CalendarDay calendarDay)
        {
            _context.CalendarDays.Add(calendarDay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalendarDay", new { id = calendarDay.Id }, calendarDay);
        }

        // DELETE: api/CalendarDays/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalendarDay>> DeleteCalendarDay(int id)
        {
            var calendarDay = await _context.CalendarDays.FindAsync(id);
            if (calendarDay == null)
            {
                return NotFound();
            }

            _context.CalendarDays.Remove(calendarDay);
            await _context.SaveChangesAsync();

            return calendarDay;
        }

        private bool CalendarDayExists(int id)
        {
            return _context.CalendarDays.Any(e => e.Id == id);
        }
    }
}
