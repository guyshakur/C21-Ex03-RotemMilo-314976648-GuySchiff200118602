using Newtonsoft.Json;

namespace FacebookWinFormsApp.WeatherFeature
{
    public class Location
    {
        private string m_CityName;
        private string m_Country;
        private string m_LocalTime;

        [JsonProperty("Name")]
        public string City
        {
            get
            {
                return m_CityName;
            }

            set
            {
                m_CityName = value;
            }
        }

        [JsonProperty("Country")]
        public string Country
        {
            get
            {
                return m_Country;
            }

            set
            {
                m_Country = value;
            }
        }

        [JsonProperty("LocalTime")]
        public string LocalTime
        {
            get
            {
                return m_LocalTime;
            }

            set
            {
                m_LocalTime = value;
            }
        }
    }
}