using System.Net.Http.Headers;

namespace WeatherStation
{
    public class ApiHelper
    {
        //to make it run only once per application, use static?
        public static HttpClient? ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            //base adress to fetch data from (https://opendata-download-metfcst.smhi.se). leave blank if additional websites are added later
            ApiClient.BaseAddress = new Uri("");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            //add a header that asks for data of type json that we can parse in the models
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}