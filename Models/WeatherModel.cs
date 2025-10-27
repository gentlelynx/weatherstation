using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using WeatherStation.Components.Pages;


namespace WeatherStation
{
    public class WeatherClass
    {
        //var type VariableName
        public string CreatedTime { get; set; } = "";
        public WeatherGeometry? Geometry { get; set; }
        public TimeSeriesEntry[] TimeSeries { get; set; } = [];
        public override string ToString()
        {
            return CreatedTime;
            //return TimeSeries[1].Data.Air_temperature.ToString();
        }
    }
    public class WeatherGeometry
    {
        public string Type { get; set; } = "";
        public float[] Coordinates { get; set; } = [];

    }
    public class TimeSeriesEntry
    {
        public DateTime Time { get; set; }
        public DataEntry? Data { get; set; }
        public class DataEntry
        {
            public float Air_temperature { get; set; } = 0;
            public float Wind_speed { get; set; } = 0;
            public int Wind_from_direction { get; set; } = 0;
            public float Wind_speed_of_gust { get; set; } = 0;
            public int Relative_humidity { get; set; } = 0;
            public float Air_pressure_at_mean_sea_level { get; set; } = 0;
            public float Precipitation_amount_min { get; set; } = 0;
            public float Precipitation_amount_max { get; set; } = 0;
            public float Symbol_code { get; set; } = 0;
        }

        public string SymbolCodeData()
        {
            if (Data?.Symbol_code == 1)
            {
                return "Klart";
            }
            else if (Data?.Symbol_code == 2)
            {
                return "Lätt molnighet";
            }
            else if (Data?.Symbol_code == 3)
            {
                return "Halvklart";
            }
            else if (Data?.Symbol_code == 4)
            {
                return "Molnigt";
            }
            else if (Data?.Symbol_code == 5)
            {
                return "Mycket moln";
            }
            else if (Data?.Symbol_code == 6)
            {
                return "Mulet";
            }
            else if (Data?.Symbol_code == 7)
            {
                return "Dimma";
            }
            else if (Data?.Symbol_code == 8)
            {
                return "Lätt regnskur";
            }
            else if (Data?.Symbol_code == 9)
            {
                return "Regnskur";
            }
            else if (Data?.Symbol_code == 10)
            {
                return "Kraftig regnskur";
            }
            else if (Data?.Symbol_code == 11)
            {
                return "Åskskur";
            }
            else if (Data?.Symbol_code == 12)
            {
                return "Lätt by av regn och snö";
            }
            else if (Data?.Symbol_code == 13)
            {
                return "By av regn och snö";
            }
            else if (Data?.Symbol_code == 14)
            {
                return "Kraftig by av regn och snö";
            }
            else if (Data?.Symbol_code == 15)
            {
                return "Lätt snöby";
            }
            else if (Data?.Symbol_code == 16)
            {
                return "Snöby";
            }
            else if (Data?.Symbol_code == 17)
            {
                return "Kraftig snöby";
            }
            else if (Data?.Symbol_code == 18)
            {
                return "Lätt regn";
            }
            else if (Data?.Symbol_code == 19)
            {
                return "Regn";
            }
            else if (Data?.Symbol_code == 20)
            {
                return "Kraftigt regn";
            }
            else if (Data?.Symbol_code == 21)
            {
                return "Åska";
            }
            else if (Data?.Symbol_code == 22)
            {
                return "Lätt snöblandat regn";
            }
            else if (Data?.Symbol_code == 23)
            {
                return "Snöblandat regn";
            }
            else if (Data?.Symbol_code == 24)
            {
                return "Kraftigt snöblandat regn";
            }
            else if (Data?.Symbol_code == 25)
            {
                return "Lätt snöfall";
            }
            else if (Data?.Symbol_code == 26)
            {
                return "Snöfall";
            }
            else if (Data?.Symbol_code == 27)
            {
                return "Ymnigt snöfall";
            }
            else
            {
                return "";
            }
        }
    }

    public class RiseSetkEntry
    {
        public RiseSet? Results { get; set; }

        public class RiseSet
        {
            public TimeOnly Sunrise { get; set; }
            public TimeOnly Sunset { get; set; }
        }
    }   
}

