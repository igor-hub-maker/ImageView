using ImageView.Models;
using ImageView.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImageView.ViewModels
{
    public class VeticalImageViewModel : BaseViewModel
    {
        private List<ImageInfo> images;
        public ICommand AlertShowCommand { protected set; get; }
        public VeticalImageViewModel()
        {
            AddImages();
            AlertShowCommand = new Command(AlertShow);
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
        public async void AlertShow()
        {
            var r = await App.Current.MainPage.DisplayAlert("it`s me", "I`m a Yes/No PopUp", "Yes", "No");
        }
        public async void AddImages()
        {
            ImagesService imagesService = new ImagesService();
            Images = await imagesService.GetImagesInfo();
        }
    }
}
