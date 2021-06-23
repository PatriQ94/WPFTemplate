using GalaSoft.MvvmLight;
using WPF.UI.Locators;

namespace WPF.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase _viewModel;
        public ViewModelBase ViewModel
        {

            get => _viewModel;
            set => Set(ref _viewModel, value);
        }

        public MainViewModel()
        {
            //Redirect to InitView at Startup
            ViewModel = ViewModelLocator.InitViewModel;
        }
    }
}
