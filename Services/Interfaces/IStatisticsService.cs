using Services.BO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IStatisticsService
    {
        List<TradeUI> GetTradesCache();
    }
}
