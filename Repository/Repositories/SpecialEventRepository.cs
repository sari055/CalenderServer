using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class SpecialEventRepository : ISpecialEventRepository
    {
        IDataSource dataSource;
        public SpecialEventRepository(IDataSource ds)
        {
            dataSource = ds;
        }    
        public SpecialEvent Add(SpecialEvent model)
        {
            dataSource.SpecialEvent.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialEvent> GetAll()
        {
            return dataSource.SpecialEvent.ToList();//may be do id deep copy
        }

        public SpecialEvent GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialEvent> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(SpecialEvent model)
        {
            throw new NotImplementedException();
        }
    }
}
