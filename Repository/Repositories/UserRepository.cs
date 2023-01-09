using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : IUserRepository
    {
        IDataSource dataSource;
        public UserRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public User Add(User model)
        {
            dataSource.User.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// ////////
        /// </summary>
        /// <returns></returns>
        public List<User> GetAll()
        {
            return dataSource.User.ToList();//may be do id deep copy
        }

        public User GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<User> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
