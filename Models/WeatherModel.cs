using Microsoft.AspNetCore.Http.HttpResults;

namespace WeatherStation
{
    public class WeatherObject
    {
        public class Geometry
        {
            public string[]? Coordinates { get; set; }
        }

        public class TimeSeries
        {
            public Data[]? Data { get; set; }
        }

        public class Data
        {
            public int Air_temperature { get; set; }
            public int Wind_speed { get; set; }
            public int Wind_from_direction { get; set; }
            public int Wind_speed_of_gust { get; set; }
            public int Relative_humidity { get; set; }
            public int Air_pressure_at_mean_sea_level { get; set; }
            public int Precipitation_amount_min { get; set; }
            public int Precipitation_amount_max { get; set; }
        }
    }
}
