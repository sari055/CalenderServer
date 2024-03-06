using AutoMapper;
//using NHibernate.Mapping.ByCode.Impl;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceClasses
{
    public class Eventservice : IEventService
    {
        private readonly IEventRepository rep;
        private readonly IMapper mapper;

        public Eventservice(IEventRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
       

        public EventModel Add(EventModel model)
        {
            return mapper.Map<EventModel>(rep.Add(mapper.Map<Event>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<EventModel> GetAll()
        {
            List<Event> list = rep.GetAll();
            List<EventModel> listToReturn = new List<EventModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<EventModel>(item));
            }
            return listToReturn;
        }
        
        public UserModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<EventModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(EventModel model)
        {
            throw new NotImplementedException();
        }

        EventModel IServices<EventModel>.Add(EventModel model)
        {
            throw new NotImplementedException();
        }

        void IServices<EventModel>.Delete(int key)
        {
            throw new NotImplementedException();
        }

        List<EventModel> IServices<EventModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        EventModel IServices<EventModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<EventModel> IServices<EventModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<EventModel>.Update(EventModel model)
        {
            throw new NotImplementedException();
        }
    }
}
