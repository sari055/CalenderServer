using AutoMapper;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Model;

namespace Services.ServiceClasses
{
    public class CalenderYearService : ICalenderYearService
    {
        private readonly ICalenderYearRepository rep;
        private readonly IMapper mapper;
        public CalenderYearService(ICalenderYearRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config = 
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<DescendantImage, DescendantImageModel>()
        //       .ReverseMap ()
        //       );


        public CalenderYearModel Add(CalenderYearModel model)
        {
            return mapper.Map<CalenderYearModel>(rep.Add(mapper.Map<CalenderYear>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderYearModel> GetAll()
        {
            List<CalenderYear> list = rep.GetAll();
            List<CalenderYearModel> listToReturn = new List<CalenderYearModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<CalenderYearModel>(item));
            }
            return listToReturn;
        }

        public CalenderYearModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<CalenderYearModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(CalenderYearModel model)
        {
            throw new NotImplementedException();
        }

        CalenderYearModel IServices<CalenderYearModel>.Add(CalenderYearModel model)
        {
            throw new NotImplementedException();
        }

        List<CalenderYearModel> IServices<CalenderYearModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        CalenderYearModel IServices<CalenderYearModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<CalenderYearModel> IServices<CalenderYearModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<CalenderYearModel>.Update(CalenderYearModel model)
        {
            throw new NotImplementedException();
        }
    }
}
