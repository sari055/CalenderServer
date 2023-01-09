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
    public class SpecialDateService : ISpecialDateService
    {
        private readonly ISpecialDateRepository rep;
        private readonly IMapper mapper;
        public SpecialDateService( ISpecialDateRepository _rep,IMapper _mapper)
        {
            rep = _rep;
            mapper= _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<SpecialDate, SpecialDateModel>()
        //       .ReverseMap()
        //       );
       
        public SpecialDateModel Add(SpecialDateModel model)
        {
            return mapper.Map<SpecialDateModel>(rep.Add(mapper.Map<SpecialDate>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialDateModel> GetAll()
        {
            List<SpecialDate> list = rep.GetAll();
            List<SpecialDateModel> listToReturn = new List<SpecialDateModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<SpecialDateModel>(item));
            }
            return listToReturn;
        }

        public SpecialDateModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<SpecialDateModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(SpecialDateModel model)
        {
            throw new NotImplementedException();
        }
    }
}
