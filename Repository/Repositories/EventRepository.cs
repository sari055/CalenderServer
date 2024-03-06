using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class EvevntRepository :IEventRepository
    {
        IDataSource dataSource;
        public EvevntRepository(IDataSource ds)
        {
            dataSource = ds;
        }
        public Event Add(Event model)
        {
            dataSource.Event.Add(model);
            dataSource.SaveChanges();
            return model;
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<Event> GetAll()
        {
            return dataSource.Event.ToList();//may be do id deep copy
        }

        public Event GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<Event> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(Event model)
        {
            throw new NotImplementedException();
        }

        Event IRepository<Event>.Add(Event model)
        {
            throw new NotImplementedException();
        }

        List<Event> IRepository<Event>.GetAll()
        {
            throw new NotImplementedException();
        }

        Event IRepository<Event>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<Event> IRepository<Event>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IRepository<Event>.Update(Event model)
        {
            throw new NotImplementedException();
        }
    }
}

