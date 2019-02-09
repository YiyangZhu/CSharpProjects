using System;
namespace Chapter6
{
    public class ConcurrencyCoordinationRuntime
    {
       

        public ConcurrencyCoordinationRuntime()
        {
        }

        public static void Demo()
        {

        }

        HoldingValue ComputeTotalStockValue(string user, string password)
        {
            Token token = AuthService.Check(user, password);
            Holdings stocks = DbService.GetStockHoldings(token);
            StockRates rates = StockService.GetRates(token);
            return ProcessStocks(stocks, rates);
        }

        private HoldingValue ProcessStocks(Holdings stocks, StockRates rates)
        {
            throw new NotImplementedException();
        }
    }

    internal class StockService
    {
        internal static StockRates GetRates(Token token)
        {
            throw new NotImplementedException();
        }
    }

    internal class DbService
    {
        internal static Holdings GetStockHoldings(Token token)
        {
            throw new NotImplementedException();
        }
    }

    internal class AuthService
    {
        internal static Token Check(string user, string password)
        {
            throw new NotImplementedException();
        }
    }

    internal class StockRates
    {
    }

    internal class Holdings
    {
    }

    internal class Token
    {
    }

    internal class HoldingValue
    {
    }
}
