using ImageView.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Unsplasharp;

namespace ImageView.Services
{
    public class ImagesService
    {
        public async Task<List<ImageInfo>> GetImagesInfo()
        {

            var client = new UnsplasharpClient("Co4P8IUw-pCICF0UPf64fa-y1ibg9vYOh_PAXAnyYOQ");
            var rndImages = await client.GetRandomPhoto(count: 5);
            List<ImageInfo> res = new List<ImageInfo>();
            foreach (var rndImage in rndImages)
            {
                ImageInfo imageInfo = new ImageInfo();
                imageInfo.Source = rndImage.Links.Download;
                StringBuilder sb = new StringBuilder();
                sb.Append("Resolution: ");
                sb.Append(rndImage.Width);
                sb.Append("x");
                sb.Append(rndImage.Height);
                imageInfo.Resolution = sb.ToString();
                imageInfo.Name = "Author: " + rndImage.User.Name;
                res.Add(imageInfo);
            }
            return res;
        }
    }
}
