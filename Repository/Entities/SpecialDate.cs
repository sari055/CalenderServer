using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class SpecialDate
    {
        public int SpecialDateId { get; set; }
        public int DescendantId { get; set; }
        public Descendant Descendant { get; set; }
        public int SpecialEventId { get; set; }
        public SpecialEvent SpecialEvent { get; set; }
        public string EventDescription { get; set; }
        public DateOnly EventDate { get; set; }

    }
}
