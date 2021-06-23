using Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace Services.Logic
{
    public class InitializationService : IInitializationService
    {
        public async Task DummyCheck()
        {
            //Fake delay to simulate some checks
            await Task.Delay(3000);
        }
    }
}
