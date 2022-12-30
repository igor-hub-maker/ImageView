using ImageView.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ImageView.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HorizontalImageView : ContentPage
    {
        public HorizontalImageView()
        {
            InitializeComponent();
            BindingContext = new HorizontalImageViewModel();
        }
    }
}