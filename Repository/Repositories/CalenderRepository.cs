using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CalenderRepository : ICalenderRepository
    {
        IDataSource dataSource;
        public CalenderRepository(IDataSource ds)
        {
            dataSource = ds;
        }    
        public Calender Add(Calender model)
        {
            dataSource.Calender.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Calender> GetAll()
        {
            return dataSource.Calender.ToList();//may be do id deep copy
        }

        public Calender GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Calender> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Calender model)
        {
            throw new NotImplementedException();
        }
    }
}
