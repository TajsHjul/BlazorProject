using System;
using System.Collections.Generic;
using System.Text;
using BlazorProject.Models;
using BlazorProject.Modles;
using Microsoft.EntityFrameworkCore;

namespace BlazorProject.Data.Contexts
{
    public class CalendarEventContext : DbContext
    {
        public CalendarEventContext(DbContextOptions<CalendarEventContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=events.db");            
        }
        public DbSet<CalendarEvent> CalendarEvents { get; set; }

        public DbSet<CalendarDay> CalendarDays { get; set; }

        public DbSet<Employees> Employee { get; set; }

       
    }
}
