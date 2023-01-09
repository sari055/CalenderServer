using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DescendantImageRepository : IDescendantImageRepository
    {
        IDataSource dataSource;
        public DescendantImageRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public DescendantImage Add(DescendantImage model)
        {
            dataSource.DescendantImage.Add(model) ;
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantImage> GetAll()
        {
            return dataSource.DescendantImage.ToList();//may be do id deep copy
        }

        public DescendantImage GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantImage> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(DescendantImage model)
        {
            throw new NotImplementedException();
        }
    }
}
