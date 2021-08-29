namespace FacebookWinFormsApp.WeatherFeature
{
    public static class WeatherFeature
    {
        private static readonly string sr_PrefixUrl = "http://api.weatherapi.com/v1/current.json?key=653ce11ceb1a4b3ba0195804211707&q=";
        private static readonly string sr_SuffixUrl = "&aqi=no";

        public static WeatherDetails GetWeatherDetails(string i_Location)
        {
            string url = $"{sr_PrefixUrl}{i_Location}{sr_SuffixUrl}";
            return JsonUtils.GetApiDetailsFromJsonElement<WeatherDetails>(url);
        }
    }
}