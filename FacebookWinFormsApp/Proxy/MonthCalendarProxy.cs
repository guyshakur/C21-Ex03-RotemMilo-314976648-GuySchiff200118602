using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Proxy
{
    public class MonthCalendarProxy : MonthCalendar
    {
        public static HebrewDateDetails GetHebrewDateDetails(string i_GregorianDate)
        {
            string url = $@"https://www.hebcal.com/converter?cfg=json&start={i_GregorianDate}&end={i_GregorianDate}&g2h=1";
            return JsonUtils.GetApiDetailsFromJsonElement<HebrewDateDetails>(url);
        }

        public new void SetDate(DateTime i_Date)
        {
            DateRangeEventArgs dateRangeEventArgs = new DateRangeEventArgs(i_Date, i_Date);
            base.OnDateSelected(dateRangeEventArgs);
            showHebrewDate(dateRangeEventArgs, "יום ההולדת העברי הוא ");
            DateTime birthdayCurrentYearDate = i_Date.AddYears(DateTime.Today.Year - i_Date.Year);
            Invoke(new Action(() => base.SetDate(birthdayCurrentYearDate)));
        }

        protected override void OnDateSelected(DateRangeEventArgs i_DateRangeEventArgs)
        {
            base.OnDateSelected(i_DateRangeEventArgs);
            showHebrewDate(i_DateRangeEventArgs, "התאריך העברי הוא ");
        }

        private void showHebrewDate(DateRangeEventArgs i_DateRangeEventArgs, string i_PrefixMessage)
        {
            try
            {
                MessageBox.Show($"{i_PrefixMessage}{GetHebrewDateDetails(makeDayForApi(i_DateRangeEventArgs)).HebrewDate}");
            }
            catch (Exception)
            {
            }
        }

        private string makeDayForApi(DateRangeEventArgs i_DateRangeEventArgs)
        {
            StringBuilder gregorianDate = new StringBuilder();
            if (i_DateRangeEventArgs.Start.Year < 10)
            {
                gregorianDate.Append('0');
            }

            gregorianDate.Append(i_DateRangeEventArgs.Start.Year.ToString()).Append('-');
            if (i_DateRangeEventArgs.Start.Month < 10)
            {
                gregorianDate.Append('0');
            }

            gregorianDate.Append(i_DateRangeEventArgs.Start.Month.ToString()).Append('-');
            if (i_DateRangeEventArgs.Start.Day < 10)
            {
                gregorianDate.Append('0');
            }

            gregorianDate.Append(i_DateRangeEventArgs.Start.Day.ToString());

            return gregorianDate.ToString();
        }
    }
}
