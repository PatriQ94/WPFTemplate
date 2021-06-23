using Services.BO;
using System;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IStatisticsService
    {
        List<TradeUI> GetTradesCache();
        void SetUpdateStatisticsEvent(Action getStatistics);
    }
}
