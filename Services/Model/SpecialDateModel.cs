
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class SpecialDateModel
    {
      
        public int SpecialDateId { get; set; }
        public int DescendantId { get; set; }
        public Descendant Descendant { get; set; }
        public int SpecialEventId { get; set; }
        public SpecialEvent SpecialEvent { get; set; }
        public string EventDescription { get; set; }
        public DateOnly EventDate { get; set; }

        public SpecialDateModel(int specialDateId, int descendantId, Descendant descendant, int specialEventId, SpecialEvent specialEvent, string eventDescription, DateOnly eventDate)
        {
            SpecialDateId = specialDateId;
            DescendantId = descendantId;
            Descendant = descendant;
            SpecialEventId = specialEventId;
            SpecialEvent = specialEvent;
            EventDescription = eventDescription;
            EventDate = eventDate;
        }

        public SpecialDateModel()
        {
        }
    }
}
