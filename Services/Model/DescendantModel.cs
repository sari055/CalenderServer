
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class DescendantModel
    {
       
        public int DescendantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FatherId { get; set; }
        public int MotherId { get; set; }
        public DateOnly DOB { get; set; }
        public int SpouseId { get; set; }

        public DescendantModel(int descendantId, string firstName, string lastName, int fatherId, int motherId, DateOnly dOB, int spouseId)
        {
            DescendantId = descendantId;
            FirstName = firstName;
            LastName = lastName;
            FatherId = fatherId;
            MotherId = motherId;
            DOB = dOB;
            SpouseId = spouseId;
        }

        public DescendantModel()
        {
        }

        //יום נישואין??
        //האם להוסיף קוד תמונה עיקרית?
        //האם להוסיף כתובת מייל ומספר טלפון?
    }
}
