using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logic
{
    public class AccountService : IAccountService
    {
        public string GetAge()
        {
            return "32";
        }

        public string GetSurname()
        {
            return "Lee";
        }

        public string GetUserName()
        {
            return "Bruce";
        }
    }
}
