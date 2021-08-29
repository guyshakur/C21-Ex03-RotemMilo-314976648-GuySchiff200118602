using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace FacebookWinFormsApp
{
    public static class JsonUtils
    {
        public static T GetApiDetailsFromJsonElement<T>(string i_Url)
        {
            return JsonConvert.DeserializeObject<T>(GetJsonResponse(i_Url));
        }

        public static List<T> GetApiDetailsFromJsonArray<T>(string i_Url)
        {
            return JsonConvert.DeserializeObject<List<T>>(GetJsonResponse(i_Url));
        }

        public static string GetJsonResponse(string i_Url)
        {
            WebRequest request = HttpWebRequest.Create(i_Url);
            WebResponse response = request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            return reader.ReadToEnd();
        }
    }
}