
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Services.Model
{
    public class UserModel
    {

        public int Id { get; set; }
        public int UserTZ { get; set; }
        public int UserSpouseID { get; set; }
        public int UserFatherID { get; set; }
        public int UserMotherID { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }

        public UserModel(int id,int userTZ,int userSpouseID,int userFatherID,int userMotherID,string userName, string userPhoneNumber, string userEmail, string userPassword)
        {
            Id = id;
            UserTZ=userTZ;
            UserSpouseID=userSpouseID;
            UserFatherID=userFatherID;
            UserMotherID=userMotherID;
            UserName = userName;
            UserPhoneNumber = userPhoneNumber;
            UserEmail = userEmail;
            UserPassword = userPassword;
        }

        public UserModel()
        {
        }
    }
}
