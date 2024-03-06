
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class LevelModel
    {

        public int Id { get; set; }
        public string LevelName { get; set; }
        public int Sort { get; set; }

        public LevelModel(int id,string levelName,int sort)
        {
            Id = id;
            LevelName = levelName;
            Sort = sort;
        }

        public LevelModel()
        {
        }
    }
}
