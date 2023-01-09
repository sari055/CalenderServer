using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class SpecialDateRepository : ISpecialDateRepository
    {
        IDataSource dataSource;
        public SpecialDateRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public SpecialDate Add(SpecialDate model)
        {
           dataSource.SpecialDate.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialDate> GetAll()
        {
            return dataSource.SpecialDate.ToList();//may be do id deep copy
        }

        public SpecialDate GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialDate> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(SpecialDate model)
        {
            throw new NotImplementedException();
        }
    }
}
