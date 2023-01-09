using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageDescription { get; set; }  // מה השדה אמור להכיל?
        public string ImageSource { get; set; }
    }
}
