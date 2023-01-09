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
    public class DescendantService : IDescendantService
    {
       private readonly IDescendantRepository rep;
      private readonly  IMapper mapper;
        public DescendantService(IDescendantRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<Descendant, DescendantModel>()
        //       .ReverseMap()
        //       );
       
        public DescendantModel Add(DescendantModel model)
        {
            return mapper.Map<DescendantModel>(rep.Add(mapper.Map<Descendant>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantModel> GetAll()
        {
            List<Descendant> list = rep.GetAll();
            List<DescendantModel> listToReturn = new List<DescendantModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<DescendantModel>(item));
            }
            return listToReturn;
        }

        public DescendantModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(DescendantModel model)
        {
            throw new NotImplementedException();
        }
    }
}
