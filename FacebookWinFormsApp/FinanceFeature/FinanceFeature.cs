namespace FacebookWinFormsApp.FinanceFeature
{
    public static class FinanceFeature
    {
        private static readonly string sr_PrefixUrl = $"https://financialmodelingprep.com/api/v3/profile/";
        private static readonly string sr_SuffixUrl = "?apikey=f9867ba3b97fedb5c7bb83ebaa6aa98c";

        public static Stock GetStocksDetails(string i_StockName)
        {
            string url = $"{sr_PrefixUrl}{i_StockName}{sr_SuffixUrl}";
            return JsonUtils.GetApiDetailsFromJsonArray<Stock>(url)[0];
        }
    }
}