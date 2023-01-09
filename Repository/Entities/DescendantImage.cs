using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Repository.Entities
{
    public class DescendantImage
    {
     
        public int DescendantImageId { get; set; }
        public Image Image { get; set; }
        public bool IsMain { get; set; }

        
    }
}
