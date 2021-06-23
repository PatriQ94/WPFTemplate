using GalaSoft.MvvmLight;
using Services.Interfaces;
using System;
using WPF.UI.Models;

namespace WPF.UI.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        private UserModel _user = new UserModel();
        public UserModel User
        {
            get => _user;
            set => Set(ref _user, value);
        }

        private readonly IAccountService _accountService;
        public AccountViewModel(IAccountService accountService)
        {
            _accountService = accountService;

            //On load fetch user data
            GetUserData();
        }

        private void GetUserData()
        {
            User.Name = _accountService.GetUserName();
            User.Surname = _accountService.GetSurname();
            User.Age = _accountService.GetAge();
        }
    }
}
