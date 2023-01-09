using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DescendantRepository : IDescendantRepository
    {
        IDataSource dataSource;
        public DescendantRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public Descendant Add(Descendant model)
        {
            dataSource.Descendant.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Descendant> GetAll()
        {
            return dataSource.Descendant.ToList();//may be do id deep copy
        }

        public Descendant GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Descendant> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Descendant model)
        {
            throw new NotImplementedException();
        }
    }
}
