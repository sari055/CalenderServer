using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Descendant
    {
        public int DescendantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FatherId { get; set; }
        public int MotherId { get; set; }
        public DateOnly DOB { get; set; }
        public int SpouseId { get; set; }

        //יום נישואין??
        //האם להוסיף קוד תמונה עיקרית?
        //האם להוסיף כתובת מייל ומספר טלפון?
    }
}
