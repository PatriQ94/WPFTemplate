using GalaSoft.MvvmLight;
using Services.BO;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using WPF.UI.Models;

namespace WPF.UI.ViewModels
{
    public class StatisticsViewModel : ViewModelBase
    {

        //Private properties
        private ObservableCollection<TradeStatisticsModel> _trades = new ObservableCollection<TradeStatisticsModel>();

        //Public properties
        public ObservableCollection<TradeStatisticsModel> Trades
        {
            get => _trades;
            set => Set(ref _trades, value);
        }

        private readonly IStatisticsService _statisticsService;

        public StatisticsViewModel(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;

            //Fake loading data
            GetStatisticsOnLoad();
        }

        private void GetStatisticsOnLoad()
        {
            _ = Application.Current.Dispatcher.InvokeAsync(delegate
            {
                //Pull the updated list of trades
                List<TradeUI> trades = _statisticsService.GetTradesCache();
                foreach (var trade in trades)
                {
                    Trades.Add(new TradeStatisticsModel()
                    {
                        Symbol = trade.Symbol,
                        MonthlyProfit = trade.MonthlyProfit,
                        DailyProfit = trade.DailyProfit,
                        MonthlyTrades = trade.MonthlyTrades,
                        DailyTrades = trade.DailyTrades
                    });
                }
            }, System.Windows.Threading.DispatcherPriority.Background);
        }
    }
}
