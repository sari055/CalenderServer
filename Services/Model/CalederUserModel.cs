
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class CalenderUserModel
    {

        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserType { get; set; }
        public int LevelId { get; set; }
        public int FamilyId { get; set; }
        public CalenderUserModel(int id,int userId,string userType,int levelId,int familyId)
        {
            Id = id;
            UserId = userId;
            UserType = userType;
            LevelId = levelId;
            FamilyId = familyId;
        }

        public CalenderUserModel()
        {
        }
    }
}
