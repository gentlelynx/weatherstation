using Microsoft.AspNetCore.Http.HttpResults;

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
            return TimeSeries[1].Data.Air_temperature.ToString();
        }
    }
    public class WeatherGeometry
    {
        public string Type { get; set; } = "";
        public float[] Coordinates { get; set; } = [];

    }
    public class TimeSeriesEntry
    {
        public string Time { get; set; } = "";
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
        }
    }
}

