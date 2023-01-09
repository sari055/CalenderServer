
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Model
{
    public class DescendantImageModel
    {

        public int DescendantImageId { get; set; }
        public Image Image { get; set; }
        public bool IsMain { get; set; }

        public DescendantImageModel(int descendantImageId, Image image, bool isMain)
        {
            DescendantImageId = descendantImageId;
            Image = image;
            IsMain = isMain;
        }

        public DescendantImageModel()
        {
        }
    }
}
