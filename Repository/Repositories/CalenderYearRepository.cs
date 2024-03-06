using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CalederYearRepository : ICalenderYearRepository
    {
        IDataSource dataSource;
        public CalederYearRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public CalenderYear Add(CalenderYear model)
        {
            dataSource.CalenderYear.Add(model) ;
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderYear> GetAll()
        {
            return dataSource.CalenderYear.ToList();//may be do id deep copy
        }

        public CalenderYear GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderYear> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(CalenderYear model)
        {
            throw new NotImplementedException();
        }
    }
}
