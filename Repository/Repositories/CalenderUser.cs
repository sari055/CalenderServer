using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CalenderUser : ICalenderUserRepository
    {
        IDataSource dataSource;
        public CalenderUser(IDataSource ds)
        {
            dataSource = ds;
        }
        public Entities.CalenderUser Add(Entities.CalenderUser model)
        {
           dataSource.CalenderUser.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Entities.CalenderUser> GetAll()
        {
            return dataSource.CalenderUser.ToList();//may be do id deep copy
        }

        public Entities.CalenderUser GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Entities.CalenderUser> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.CalenderUser model)
        {
            throw new NotImplementedException();
        }
    }
}
