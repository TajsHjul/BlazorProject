using System;
using System.Collections.Generic;
using System.Text;
using BlazorProject.Modles;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Data.Contexts
{
    public class CalendarEventContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=events.db");
        }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }
    }
}
