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
    public class CalenderService : ICalenderService
    {
        private readonly ICalenderRepository rep;
        private readonly IMapper mapper;

        public CalenderService(ICalenderRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<SpecialEvent, SpecialEventModel>()
        //       .ReverseMap()
        //       );
        public CalenderModel Add(CalenderModel model)
        {
            return mapper.Map<CalenderModel>(rep.Add(mapper.Map<Calender>(model)));
        }
        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderModel> GetAll()
        {
            List<Calender> list = rep.GetAll();
            List<CalenderModel> listToReturn = new List<CalenderModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<CalenderModel>(item));
            }
            return listToReturn;
        }

        public CalenderModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(CalenderModel model)
        {
            throw new NotImplementedException();
        }

        CalenderModel IServices<CalenderModel>.Add(CalenderModel model)
        {
            throw new NotImplementedException();
        }

        List<CalenderModel> IServices<CalenderModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        CalenderModel IServices<CalenderModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<CalenderModel> IServices<CalenderModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<CalenderModel>.Update(CalenderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
