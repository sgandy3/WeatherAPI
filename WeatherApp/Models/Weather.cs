using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace WeatherApp.Models
{
    class Weather
    {
        public Object getWeatherForcast()
        {
            string appid = "4cfcbf5314476ecc9effbaee2bd86060";
            string url = "http://api.openweathermap.org/data/2.5/weather?q=London&APPID" + appid;
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
           var jsonContent = serializer.Deserialize<object>(content);
            return jsonContent;
        }
    }
}
