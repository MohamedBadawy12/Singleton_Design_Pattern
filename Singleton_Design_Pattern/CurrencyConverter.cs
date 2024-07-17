namespace Singleton_Design_Pattern
{
    public class CurrencyConverter
    {
        private static CurrencyConverter _instance;
        private Dictionary<string, decimal> _exchangeRates;
        private static readonly object _locker = new object();
        public CurrencyConverter()
        {
            _exchangeRates = new Dictionary<string, decimal>
            {
                {"USD", 1.0m},
                {"EUR", 0.85m},
                {"GBP", 0.75m},
                {"JPY", 110.0m}
            };
        }
        public static CurrencyConverter GetInstance()
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new CurrencyConverter();
                    }
                }
            }
            return _instance;
        }
        public decimal Convert(string fromCurrency, string toCurrency, decimal amount)
        {
            if (!_exchangeRates.ContainsKey(fromCurrency) || !_exchangeRates.ContainsKey(toCurrency))
            {
                throw new ArgumentException("Invalid currency code.");
            }
            decimal fromRate = _exchangeRates[fromCurrency];
            decimal toRate = _exchangeRates[toCurrency];
            return (amount / fromRate) * toRate;
        }
    }
}
