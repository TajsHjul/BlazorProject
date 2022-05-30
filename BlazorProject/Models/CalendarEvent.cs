using System;
using System.Collections.Generic;

namespace BlazorProject.Modles{

    public class CalendarEvent{
        public int Id { get; set; }
        public string Subject{get;set;}

        public DateTime StartDate{get;set;}

        public DateTime EndDate{get;set;}
    }
}