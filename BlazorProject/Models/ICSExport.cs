using BlazorProject.Modles;
using Ical.Net.DataTypes;
using Ical.Net.Serialization;
using System;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace BlazorProject.Models
{
    public class ICSExport
    {
        public void ExportToFile()
        {
            CalendarDay dayevent=new CalendarDay();               
            

            var serializer = new CalendarSerializer(new SerializationContext());
            var serializedCalendar = serializer.SerializeToString(dayevent);
            var bytesCalendar = Encoding.UTF8.GetBytes(serializedCalendar);
            MemoryStream ms = new MemoryStream(bytesCalendar);
            System.Net.Mail.Attachment attachment = new System.Net.Mail.Attachment(ms, "event.ics", "text/calendar");

            MailMessage message = new MailMessage();
            message.To.Add("10051@student.eadania.dk");
            message.From = new MailAddress("info@company.com", "Company, Inc");
            message.Subject = "subject";
            message.Body = "emailbody";
            message.IsBodyHtml = true;

            message.Attachments.Add(attachment);


        }
    }
}
