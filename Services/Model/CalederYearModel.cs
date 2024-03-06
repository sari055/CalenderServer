
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class CalenderYearModel
    {

        public int Id { get; set; }
        public int CalenderId { get; set; }
        public int Year { get; set; }
        public CalenderYearModel(int id,int calenderId,int year)
        {
            Id = id;
            CalenderId = calenderId;
            Year = year;
        }

        public CalenderYearModel()
        {
        }
    }
}
