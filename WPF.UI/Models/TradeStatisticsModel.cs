using GalaSoft.MvvmLight;

namespace WPF.UI.Models
{
    public class TradeStatisticsModel : ObservableObject
    {
        private string _symbol;
        public string Symbol
        {
            get => _symbol;
            set => Set(ref _symbol, value);
        }

        private decimal _monthlyProfit;
        public decimal MonthlyProfit
        {
            get => _monthlyProfit;
            set => Set(ref _monthlyProfit, value);
        }

        private decimal _dailyProfit;
        public decimal DailyProfit
        {
            get => _dailyProfit;
            set => Set(ref _dailyProfit, value);
        }

        private int _monthlyTrades;
        public int MonthlyTrades
        {
            get => _monthlyTrades;
            set => Set(ref _monthlyTrades, value);
        }

        private int _dailyTrades;
        public int DailyTrades
        {
            get => _dailyTrades;
            set => Set(ref _dailyTrades, value);
        }
    }
}
