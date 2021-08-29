using Newtonsoft.Json;

namespace FacebookWinFormsApp.WeatherFeature
{
    public class Current
    {
        private double m_TempertureInCelsius;
        private double m_TempertureInFahrenheit;
        private Condition m_Condition;

        [JsonProperty("Temp_C")]
        public double TempertureInCelsius
        {
            get
            {
                return m_TempertureInCelsius;
            }

            set
            {
                m_TempertureInCelsius = value;
            }
        }

        [JsonProperty("Temp_F")]
        public double TempertureInFahrenheit
        {
            get
            {
                return m_TempertureInFahrenheit;
            }

            set
            {
                m_TempertureInFahrenheit = value;
            }
        }

        [JsonProperty("Condition")]
        public Condition Condition
        {
            get
            {
                return m_Condition;
            }

            set
            {
                m_Condition = value;
            }
        }
    }
}