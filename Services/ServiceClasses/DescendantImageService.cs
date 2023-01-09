using AutoMapper;
using Repository.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using Services.Model;

namespace Services.ServiceClasses
{
    public class DescendantImageService : IDescendantImageService
    {
        private readonly IDescendantImageRepository rep;
        private readonly IMapper mapper;
        public DescendantImageService(IDescendantImageRepository _rep, IMapper _mapper)
        {
            rep = _rep;
            mapper = _mapper;
        }
        //AutoMapper.MapperConfiguration config = 
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<DescendantImage, DescendantImageModel>()
        //       .ReverseMap ()
        //       );


        public DescendantImageModel Add(DescendantImageModel model)
        {
            return mapper.Map<DescendantImageModel>(rep.Add(mapper.Map<DescendantImage>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantImageModel> GetAll()
        {
            List<DescendantImage> list = rep.GetAll();
            List<DescendantImageModel> listToReturn = new List<DescendantImageModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<DescendantImageModel>(item));
            }
            return listToReturn;
        }

        public DescendantImageModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<DescendantImageModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(DescendantImageModel model)
        {
            throw new NotImplementedException();
        }
    }
}
