
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class EventModel
    {

        public int Id { get; set; }
        public int CalenderId { get; set; }
        public string EventType { get; set; }
        public string HebrewDate { get; set; }
        public int UserId { get; set; }
        public string EventYear { get; set; }
        public bool OneTimeEvent { get; set; }

        public EventModel(int id,int calenderId,string eventType,string hebrewDate,int userId,string eventYear,bool oneTimeEvent)
        {
            Id = id;
            CalenderId = calenderId;
            EventType = eventType;
            HebrewDate = hebrewDate;
            UserId = userId;
            EventYear = eventYear;
            OneTimeEvent = oneTimeEvent;
        }

        public EventModel()
        {
        }
    }
}
