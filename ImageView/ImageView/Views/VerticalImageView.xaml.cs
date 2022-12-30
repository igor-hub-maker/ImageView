using ImageView.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerticalImageView : ContentPage
    {
        public VerticalImageView()
        {
            InitializeComponent();
            BindingContext = new VeticalImageViewModel();
        }
    }
}