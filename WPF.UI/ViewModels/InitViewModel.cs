using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.UI.Locators;

namespace WPF.UI.ViewModels
{
    public class InitViewModel : ViewModelBase
    {
        private bool _hideEverythingFlag = true;
        public bool HideEverythingFlag
        {
            get => _hideEverythingFlag;
            set => Set(ref _hideEverythingFlag, value);
        }

        private string _welcomeText;
        public string WelcomeText
        {
            get => _welcomeText;
            set => Set(ref _welcomeText, value);
        }

        //Commands
        public RelayCommand LogMeIn { get; }

        private readonly IInitializationService _initService;

        public InitViewModel(IInitializationService initService)
        {
            WelcomeText = "Welcome to this random app";
            _initService = initService;

            LogMeIn = new RelayCommand(async () => await InitializeApp());
        }

        private async Task InitializeApp()
        {
            
            WelcomeText = "Faking some checks, wait...";
            HideEverythingFlag = false;

            //Fake checking
            await _initService.DummyCheck();

            //Redirect to HomeWindow/HomeView
            ViewModelLocator.MainViewModel.ViewModel = ViewModelLocator.HomeViewModel;
        }
    }
}
