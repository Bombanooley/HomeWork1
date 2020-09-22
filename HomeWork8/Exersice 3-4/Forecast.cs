using System;
using System.Collections.Generic;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Forecast
    {
        public override string ToString()
        {
            return $"{CityName,30} {Date,30} {TempMin,10} {TempMax,10}  {PresMin,10} {PresMax,10} ";
        }
        public string CityName { get; set; }
        public string PresMinF { get; set; }
        public string PresMaxF { get; set; }
        public string TempMinF { get; set; }
        public string TempMaxF { get; set; }
        public string Date { get; set; }

        public string PresMin { get { return $"{PresMinF} мм.рт.ст."; } set { PresMinF = value; } }
        public string PresMax { get { return $"{PresMaxF} мм.рт.ст."; } set { PresMaxF = value; } }
        public string TempMin { get { return $"{TempMinF} °c"; } set { TempMinF = value; } }
        public string TempMax { get { return $"{TempMaxF} °c"; } set { TempMaxF = value; } }


    }
}