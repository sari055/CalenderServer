using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
   public interface IServices<T>
    {
        T Add(T model);
        void Update(T model);
        void Delete(int key);
        T GetById(int key);
        List<T> GetAll();
        List<T> Search(int id = 0, string searchstring = "");
    }
}
