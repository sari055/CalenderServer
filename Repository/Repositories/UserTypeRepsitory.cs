using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserTypeRepository : IUserTypeRepository
    {
        IDataSource dataSource;
        public UserTypeRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public UserType Add(UserType model)
        {
           dataSource.UserType.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserType> GetAll()
        {
            return dataSource.UserType.ToList();//may be do id deep copy
        }

        public UserType GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserType> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(UserType model)
        {
            throw new NotImplementedException();
        }

        UserType IRepository<UserType>.Add(UserType model)
        {
            throw new NotImplementedException();
        }

        void IRepository<UserType>.Delete(int key)
        {
            throw new NotImplementedException();
        }

        List<UserType> IRepository<UserType>.GetAll()
        {
            throw new NotImplementedException();
        }

        UserType IRepository<UserType>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<UserType> IRepository<UserType>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IRepository<UserType>.Update(UserType model)
        {
            throw new NotImplementedException();
        }
    }
}
