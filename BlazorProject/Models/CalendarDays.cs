using BlazorProject.Models;
using System;
using System.Collections.Generic;

namespace BlazorProject.Modles{



   public class CalendarDay{

      public int Id { get; set; }
      public int DayNumber {get;set;}
      public DateTime Date {get;set;}
      public bool IsEmpty{get;set;}
        
      public List<Employees> Employee { get; set; }
      public List<CalendarEvent> Events {get;set;}

}
}