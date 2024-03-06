
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Model
{
    public class YearEventModel
    {

        public int Id { get; set; }
        public int EventId { get; set; }
        public int CalenderId { get; set; }
        public DateOnly GregorianDate { get; set; }

        public YearEventModel(int id,int eventId,int calenderId,DateOnly gregorianDate)
        {
           Id = id;
           EventId = eventId;
           CalenderId = calenderId;
           GregorianDate = gregorianDate;
        }

        public YearEventModel()
        {
        }
    }
}
