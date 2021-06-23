using Microsoft.Extensions.DependencyInjection;
using WPF.UI.ViewModels;

namespace WPF.UI.Locators
{
    //This Locator is used to navigate between the screens
    public class ViewModelLocator
    {
        public static MainViewModel MainViewModel => App.ServiceProvider.GetRequiredService<MainViewModel>();
        public static InitViewModel InitViewModel => App.ServiceProvider.GetRequiredService<InitViewModel>();
        public static HomeViewModel HomeViewModel => App.ServiceProvider.GetRequiredService<HomeViewModel>();
    }
}
