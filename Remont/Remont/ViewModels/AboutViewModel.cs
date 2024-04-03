using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Remont.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "О приложении";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/4a11"));
        }

        public ICommand OpenWebCommand { get; }
    }
}