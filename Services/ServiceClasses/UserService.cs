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
    public class UserService : IUserService
    {
        private readonly IUserRepository rep;
        private readonly IMapper mapper;

        public UserService(IUserRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<User, UserModel>()
        //       .ReverseMap()
        //       );

        public UserModel Add(UserModel model)
        {
            return mapper.Map<UserModel>(rep.Add(mapper.Map<User>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> GetAll()
        {
            List<User> list = rep.GetAll();
            List<UserModel> listToReturn = new List<UserModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<UserModel>(item));
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
        public UserModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(UserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
