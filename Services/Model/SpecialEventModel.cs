
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class SpecialEventModel
    {

        public int SpecialEventId { get; set; }
        public string EventName { get; set; }

        public SpecialEventModel(int specialEventId, string eventName)
        {
            SpecialEventId = specialEventId;
            EventName = eventName;
        }

        public SpecialEventModel()
        {
        }
    }
}
