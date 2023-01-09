using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ImageRepository : IImageRepository
    {
        IDataSource dataSource;
        public ImageRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public Image Add(Image model)
        {
           dataSource.Image.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Image> GetAll()
        {
            return dataSource.Image.ToList();//may be do id deep copy
        }

        public Image GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Image> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Image model)
        {
            throw new NotImplementedException();
        }
    }
}
