using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class YearEventRepository:IYearEvevntRepository
    {
        IDataSource dataSource;
        public YearEventRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public YearEvent Add(YearEvent model)
        {
            dataSource.YearEvent.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }
        public List<YearEvent> GetAll()
        {
            return dataSource.YearEvent.ToList();//may be do id deep copy
        }

        public YearEvent GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<YearEvent> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(YearEvent model)
        {
            throw new NotImplementedException();
        }

        YearEvent IRepository<YearEvent>.Add(YearEvent model)
        {
            throw new NotImplementedException();
        }

        YearEvent IRepository<YearEvent>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<YearEvent> IRepository<YearEvent>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IRepository<YearEvent>.Update(YearEvent model)
        {
            throw new NotImplementedException();
        }
    }
}

