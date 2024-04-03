using Remont.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Remont.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}