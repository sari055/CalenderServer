using AutoMapper;
//using NHibernate.Mapping.ByCode.Impl;
using Repository.Entities;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ServiceClasses
{
    public class YearEventService : IYearEventService
    {
        private readonly IYearEvevntRepository rep;
        private readonly IMapper mapper;

        public YearEventService(IYearEvevntRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        

        public YearEventModel Add(YearEventModel model)
        {
            return mapper.Map<YearEventModel>(rep.Add(mapper.Map<YearEvent>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<YearEventModel> GetAll()
        {
            List<YearEvent> list = rep.GetAll();
            List<YearEventModel> listToReturn = new List<YearEventModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<YearEventModel>(item));
            }
            return listToReturn;
        }
        //public IEnumerable<UserModel> GetAll_Y()
        //{
        //    foreach (var item in rep.GetAll())
        //    {
        //        yield return mapper.Map<UserModel>(item);
        //    }
        //}
        public YearEventModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<YearEventModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(YearEventModel model)
        {
            throw new NotImplementedException();
        }

        YearEventModel IServices<YearEventModel>.Add(YearEventModel model)
        {
            throw new NotImplementedException();
        }

        List<YearEventModel> IServices<YearEventModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        YearEventModel IServices<YearEventModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<YearEventModel> IServices<YearEventModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<YearEventModel>.Update(YearEventModel model)
        {
            throw new NotImplementedException();
        }
    }
}
