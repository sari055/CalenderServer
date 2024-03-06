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
    public class LevelService : ILevelService
    {
        private readonly ILevelRepository rep;
        private readonly IMapper mapper;
        public LevelService( ILevelRepository _rep,IMapper _mapper)
        {
            rep = _rep;
            mapper= _mapper;
        }
       
       
        public LevelModel Add(LevelModel model)
        {
            return mapper.Map<LevelModel>(rep.Add(mapper.Map<Level>(model)));
        }

        public void Delete(int key)
        {
            throw new NotImplementedException();
        }

        public List<LevelModel> GetAll()
        {
            List<Level> list = rep.GetAll();
            List<LevelModel> listToReturn = new List<LevelModel>();
            foreach (var item in list)
            {
                listToReturn.Add(mapper.Map<LevelModel>(item));
            }
            return listToReturn;
        }

        public LevelModel GetById(int key)
        {
            throw new NotImplementedException();
        }

        public List<LevelModel> Search(int id = 0, string searchstring = "")
        {
            throw new NotImplementedException();
        }

        public void Update(LevelModel model)
        {
            throw new NotImplementedException();
        }

        LevelModel IServices<LevelModel>.Add(LevelModel model)
        {
            throw new NotImplementedException();
        }

        List<LevelModel> IServices<LevelModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        LevelModel IServices<LevelModel>.GetById(int key)
        {
            throw new NotImplementedException();
        }

        List<LevelModel> IServices<LevelModel>.Search(int id, string searchstring)
        {
            throw new NotImplementedException();
        }

        void IServices<LevelModel>.Update(LevelModel model)
        {
            throw new NotImplementedException();
        }
    }
}
