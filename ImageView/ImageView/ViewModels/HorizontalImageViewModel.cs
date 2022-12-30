using ImageView.Models;
using ImageView.Services;
using System.Collections.Generic;

namespace ImageView.ViewModels
{
    public class HorizontalImageViewModel : BaseViewModel
    {
        private List<ImageInfo> images;

        public HorizontalImageViewModel()
        {
            AddImages();
        }
        public List<ImageInfo> Images
        {
            get => images;
            set
            {
                images = value;
                OnPropertyChanged();
            }
        }
        public async void AddImages()
        {
            ImagesService imagesService = new ImagesService();
            Images = await imagesService.GetImagesInfo();
        }
    }
}
