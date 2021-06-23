using Microsoft.Extensions.DependencyInjection;
using WPF.UI.ViewModels;

namespace WPF.UI.Locators
{
    public class HomePanelLocator
    {
        public static AccountViewModel AccountViewModel => App.ServiceProvider.GetRequiredService<AccountViewModel>();
        public static StatisticsViewModel StatisticsViewModel => App.ServiceProvider.GetRequiredService<StatisticsViewModel>();
    }
}
