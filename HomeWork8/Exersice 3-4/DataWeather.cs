using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HomeWork8
{
    class DataWeather
    {
        public ObservableCollection<Forecast> Data { get; set; }

        WebClient web;
        string cityName;

        public void Clear()
        {
            Data.Clear();
        }
        public void AddCity(string url)
        {
            string xml = web.DownloadString(url);

            var city = XDocument.Parse(xml)
                      .Descendants("MMWEATHER")
                      .Descendants("REPORT")
                      .Descendants("TOWN")
                      .ToList();
            foreach (var item in city)
                cityName = WebUtility.UrlDecode(item.Attribute("sname").Value);


            var list = XDocument.Parse(xml)
                      .Descendants("MMWEATHER")
                      .Descendants("REPORT")
                      .Descendants("TOWN")
                      .Descendants("FORECAST")
                      .ToList();
            
            foreach (var item in list)
            {
                var temp = new Forecast()
                {
                    PresMax = item.Element("PRESSURE").Attribute("max").Value,
                    PresMin = item.Element("PRESSURE").Attribute("min").Value,
                    TempMax = item.Element("TEMPERATURE").Attribute("max").Value,
                    TempMin = item.Element("TEMPERATURE").Attribute("min").Value,
                    CityName = cityName,
                    Date = $"{item.Attribute("day").Value}.{item.Attribute("month").Value} {item.Attribute("hour").Value}:00"
                };
                //temp.PresMax = item.Element("PRESSURE").Attribute("min").Value;
                //temp.PresMin = item.Element("PRESSURE").Attribute("min").Value;
                //temp.TempMax = item.Element("TEMPERATURE").Attribute("max").Value;
                //temp.TempMin = item.Element("TEMPERATURE").Attribute("min").Value;
                //temp.CityName = cityName;
                //temp.Date = $"{item.Attribute("day").Value} {item.Attribute("month").Value}";
                Data.Add(temp);
            }
        }

        public DataWeather()
        {
            Data = new ObservableCollection<Forecast>();
            web = new WebClient();
            //AddCity("https://xml.meteoservice.ru/export/gismeteo/point/5.xml");
        }

    }
}
