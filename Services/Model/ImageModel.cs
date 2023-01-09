
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Model
{
    public class ImageModel
    {
    
        public int ImageId { get; set; }
        public string ImageDescription { get; set; }  // מה השדה אמור להכיל?
        public string ImageSource { get; set; }

        public ImageModel(int imageId, string imageDescription, string imageSource)
        {
            ImageId = imageId;
            ImageDescription = imageDescription;
            ImageSource = imageSource;
        }

        public ImageModel()
        {
        }
    }
}
