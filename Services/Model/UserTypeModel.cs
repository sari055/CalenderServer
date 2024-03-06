
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class UserTypeModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public UserTypeModel(int id, string name)
        {
           Id = id;
           Name = name;
        }

        public UserTypeModel()
        {
        }
    }
}
