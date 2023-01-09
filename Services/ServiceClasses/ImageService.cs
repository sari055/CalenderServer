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
    public class ImageService : IImageService
    {
        private readonly IImageRepository rep;
        private readonly IMapper mapper;

        public ImageService(IImageRepository _rep, IMapper _mapper)  
        {
            rep = _rep;
            mapper=_mapper;
        }
        //AutoMapper.MapperConfiguration config =
        //    new AutoMapper.MapperConfiguration(
        //       conf => conf.CreateMap<Image, ImageModel>()
        //       .ReverseMap()
        //       );

        public ImageModel Add(ImageModel model)
        {
            return mapper.Map<ImageModel>(rep.Add(mapper.Map<Image>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<ImageModel> GetAll()
        {
            List<Image> list = rep.GetAll();
            List<ImageModel> listToReturn = new List<ImageModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<ImageModel>(item));
            }
            return listToReturn;
        }

        public ImageModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<ImageModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(ImageModel model)
        {
            throw new NotImplementedException();
        }
    }
}
