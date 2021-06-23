using Services.BO;
using Services.Interfaces;
using System;
using System.Collections.Generic;

namespace Services.Logic
{
    public class StatisticsService : IStatisticsService
    {
        public static Action GetStatisticsCallbackEvent = null;

        public StatisticsService()
        {

        }

        public void SetUpdateStatisticsEvent(Action getStatistics)
        {
            if (GetStatisticsCallbackEvent == null)
            {
                GetStatisticsCallbackEvent = getStatistics;
            }
        }

        public List<TradeUI> GetTradesCache()
        {
            return new List<TradeUI>()
            {
                new TradeUI(){
                    Symbol = "BTC",
                    MonthlyProfit = 2133.123m,
                    DailyProfit = 312,
                    MonthlyTrades = 500,
                    DailyTrades =23
                },
                new TradeUI(){
                    Symbol = "IOTA",
                    MonthlyProfit = 52133.123m,
                    DailyProfit = 3312,
                    MonthlyTrades = 1380,
                    DailyTrades = 55
                },
                new TradeUI(){
                    Symbol = "ETH",
                    MonthlyProfit = 3543,
                    DailyProfit = 51,
                    MonthlyTrades = 5,
                    DailyTrades =1
                },
                new TradeUI(){
                    Symbol = "XLM",
                    MonthlyProfit = 513,
                    DailyProfit = 33,
                    MonthlyTrades = 123,
                    DailyTrades =33
                },
                new TradeUI(){
                    Symbol = "Doge",
                    MonthlyProfit = 938123,
                    DailyProfit = 33312,
                    MonthlyTrades = 420,
                    DailyTrades = 69
                },
            };
        }
    }
}
