using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.UI.Models
{
    public class UserModel : ObservableObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        private string _surname;
        public string Surname
        {
            get => _surname;
            set => Set(ref _surname, value);
        }

        private string _age;
        public string Age
        {
            get => _age;
            set => Set(ref _age, value);
        }
    }
}
