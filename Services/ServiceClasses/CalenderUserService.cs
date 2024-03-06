using AutoMapper;
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
    public class CalenderUserService : ICalenderUserService
    {
        private readonly ICalenderUserRepository rep;
        private readonly IMapper mapper;

        public CalenderUserService(ICalenderUserRepository _rep, IMapper _mapper)  
        {
            rep = _rep;
            mapper=_mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<Image, ImageModel>()
        //       .ReverseMap()
        //       );

        public CalenderUserModel Add(CalenderUserModel model)
        {
            return mapper.Map<CalenderUserModel>(rep.Add(mapper.Map<CalenderUser>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderUserModel> GetAll()
        {
            List<CalenderUser> list = rep.GetAll();
            List<CalenderUserModel> listToReturn = new List<CalenderUserModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<CalenderUserModel>(item));
            }
            return listToReturn;
        }

        public CalenderUserModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderUserModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(CalenderUserModel model)
        {
            throw new NotImplementedException();
        }

        CalenderUserModel IServices<CalenderUserModel>.Add(CalenderUserModel model)
        {
            throw new NotImplementedException();
        }

        List<CalenderUserModel> IServices<CalenderUserModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        CalenderUserModel IServices<CalenderUserModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<CalenderUserModel> IServices<CalenderUserModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<CalenderUserModel>.Update(CalenderUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
