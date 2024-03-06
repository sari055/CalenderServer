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
    public class UserTypeService : IUserTypeService
    {
        private readonly IUserTypeRepository rep;
        private readonly IMapper mapper;

        public UserTypeService(IUserTypeRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<User, UserModel>()
        //       .ReverseMap()
        //       );

        public UserTypeModel Add(UserTypeModel model)
        {
            return mapper.Map<UserTypeModel>(rep.Add(mapper.Map<UserType>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserTypeModel> GetAll()
        {
            List<UserType> list = rep.GetAll();
            List<UserTypeModel> listToReturn = new List<UserTypeModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<UserTypeModel>(item));
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
        public UserTypeModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserTypeModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(UserTypeModel model)
        {
            throw new NotImplementedException();
        }
    }
}
