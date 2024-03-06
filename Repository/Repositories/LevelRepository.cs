using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        IDataSource dataSource;
        public LevelRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public Level Add(Level model)
        {
           dataSource.Level.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Level> GetAll()
        {
            return dataSource.Level.ToList();//may be do id deep copy
        }

        public Level GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Level> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Level model)
        {
            throw new NotImplementedException();
        }
    }
}
