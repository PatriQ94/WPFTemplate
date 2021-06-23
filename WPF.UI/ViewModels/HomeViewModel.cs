using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Extensions.Logging;
using WPF.UI.Locators;

namespace WPF.UI.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private ViewModelBase _viewModel;
        public ViewModelBase ViewModel
        {

            get => _viewModel;
            set => Set(ref _viewModel, value);
        }

        //Commands
        public RelayCommand AccountPanelActivate { get; }
        public RelayCommand StatisticsPanelActivate { get; }
        public RelayCommand ExitApp { get; }

        private readonly ILogger<HomeViewModel> _logger;
        public HomeViewModel(ILogger<HomeViewModel> logger)
        {
            _logger = logger;

            //On load show the Account view
            ViewModel = HomePanelLocator.AccountViewModel;

            AccountPanelActivate = new RelayCommand(() => ShowAccountPanel());
            StatisticsPanelActivate = new RelayCommand(() => ShowStatisticsPanel());
            ExitApp = new RelayCommand(() => ExitApplication());
        }


        private void ShowAccountPanel()
        {
            _logger.LogInformation($"Showing to account view...");
            ViewModel = HomePanelLocator.AccountViewModel;
        }

        private void ShowStatisticsPanel()
        {
            _logger.LogInformation($"Showing to statistics view...");
            ViewModel = HomePanelLocator.StatisticsViewModel;
        }

        private void ExitApplication()
        {
            _logger.LogInformation($"Exiting application...");
            System.Windows.Application.Current.Shutdown();
        }
    }
}
