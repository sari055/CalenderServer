
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Model
{
    public class CalenderModel
    {

        public int Id { get; set; }
        public int DirectorId { get; set; }
        public string GroupName { get; set; }

        public CalenderModel(int id,int directorId,string groupName)
        {
            Id = id;
            DirectorId = directorId;
            GroupName = groupName;
        }

        public CalenderModel()
        {
        }
    }
}
