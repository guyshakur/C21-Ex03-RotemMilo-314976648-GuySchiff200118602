using Newtonsoft.Json;

namespace FacebookWinFormsApp.FinanceFeature
{
    public class Stock
    {
        private double m_Price;
        private double m_Changes;
        private string m_IpoDate;
        private string m_Image;

        [JsonProperty("Price")]

        public double Price
        {
            get
            {
                return m_Price;
            }

            set
            {
                m_Price = value;
            }
        }

        [JsonProperty("Changes")]

        public double Changes
        {
            get
            {
                return m_Changes;
            }

            set
            {
                m_Changes = value;
            }
        }

        [JsonProperty("IpoDate")]

        public string IpoDate
        {
            get
            {
                return m_IpoDate;
            }

            set
            {
                m_IpoDate = value;
            }
        }

        [JsonProperty("Image")]

        public string Image
        {
            get
            {
                return m_Image;
            }

            set
            {
                m_Image = value;
            }
        }
    }
}