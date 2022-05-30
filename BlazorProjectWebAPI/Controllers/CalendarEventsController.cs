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
    public class CalendarEventsController : ControllerBase
    {
        private readonly CalendarEventContext _context;

        public CalendarEventsController(CalendarEventContext context)
        {
            _context = context;
        }

        // GET: api/CalendarEvents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CalendarEvent>>> GetCalendarEvents()
        {
            return await _context.CalendarEvents.ToListAsync();
        }

        // GET: api/CalendarEvents/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CalendarEvent>> GetCalendarEvent(int id)
        {
            var calendarEvent = await _context.CalendarEvents.FindAsync(id);

            if (calendarEvent == null)
            {
                return NotFound();
            }

            return calendarEvent;
        }

        // PUT: api/CalendarEvents/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCalendarEvent(int id, CalendarEvent calendarEvent)
        {
            if (id != calendarEvent.Id)
            {
                return BadRequest();
            }

            _context.Entry(calendarEvent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CalendarEventExists(id))
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

        // POST: api/CalendarEvents
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CalendarEvent>> PostCalendarEvent(CalendarEvent calendarEvent)
        {
            _context.CalendarEvents.Add(calendarEvent);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCalendarEvent", new { id = calendarEvent.Id }, calendarEvent);
        }

        // DELETE: api/CalendarEvents/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CalendarEvent>> DeleteCalendarEvent(int id)
        {
            var calendarEvent = await _context.CalendarEvents.FindAsync(id);
            if (calendarEvent == null)
            {
                return NotFound();
            }

            _context.CalendarEvents.Remove(calendarEvent);
            await _context.SaveChangesAsync();

            return calendarEvent;
        }

        private bool CalendarEventExists(int id)
        {
            return _context.CalendarEvents.Any(e => e.Id == id);
        }
    }
}
