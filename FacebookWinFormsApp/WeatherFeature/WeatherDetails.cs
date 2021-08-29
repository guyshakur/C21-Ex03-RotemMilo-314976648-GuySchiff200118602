using Newtonsoft.Json;

namespace FacebookWinFormsApp.WeatherFeature
{
    public class WeatherDetails
    {
        private Location m_Location;
        private Current m_DailyPredict;

        [JsonProperty("Location")]
        public Location Location
        {
            get
            {
                return m_Location;
            }

            set
            {
                m_Location = value;
            }
        }

        [JsonProperty("Current")]
        public Current DailyPredict
        {
            get
            {
                return m_DailyPredict;
            }

            set
            {
                m_DailyPredict = value;
            }
        }
    }
}