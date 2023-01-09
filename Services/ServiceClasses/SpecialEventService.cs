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
    public class SpecialEventService : ISpecialEventService
    {
        private readonly ISpecialEventRepository rep;
        private readonly IMapper mapper;

        public SpecialEventService(ISpecialEventRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<SpecialEvent, SpecialEventModel>()
        //       .ReverseMap()
        //       );
        public SpecialEventModel Add(SpecialEventModel model)
        {
            return mapper.Map<SpecialEventModel>(rep.Add(mapper.Map<SpecialEvent>(model)));
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialEventModel> GetAll()
        {
            List<SpecialEvent> list = rep.GetAll();
            List<SpecialEventModel> listToReturn = new List<SpecialEventModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<SpecialEventModel>(item));
            }
            return listToReturn;
        }

        public SpecialEventModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialEventModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(SpecialEventModel model)
        {
            throw new NotImplementedException();
        }
    }
}
