
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
       
        public int UserId { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public string UserPhoneNumber { get; set; }
        public string UserEmail { get; set; }

        public UserModel(int userId, string userPassword, string userName, string userPhoneNumber, string userEmail)
        {
            UserId = userId;
            UserPassword = userPassword;
            UserName = userName;
            UserPhoneNumber = userPhoneNumber;
            UserEmail = userEmail;
        }

        public UserModel()
        {
        }
    }
}
