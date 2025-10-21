using Microsoft.AspNetCore.Http.HttpResults;

namespace WeatherStation
{
    public class WeatherClass
    {
        //var type VariableName
        public string? CreatedTime { get; set; }
        //var type of class[] variable 
        public override string ToString()
        {
            return CreatedTime;
        }

//         public Geometries[]? Geometry { get; set; }
//         public TimeSerie[]? TimeSeries { get; set; }
  
//         public class Geometries
//         {
//             public string? Coordinates { get; set; }
//             public override string ToString()
//             {
//                 return Coordinates;
//             }
//         }

//         public class TimeSerie
//         {
//             public Data[]? Data { get; set; }
//         }

//         public class Data
//         {
//             public string? Air_temperature { get; set; }
//             public int Wind_speed { get; set; }
//             public int Wind_from_direction { get; set; }
//             public int Wind_speed_of_gust { get; set; }
//             public int Relative_humidity { get; set; }
//             public int Air_pressure_at_mean_sea_level { get; set; }
//             public int Precipitation_amount_min { get; set; }
//             public int Precipitation_amount_max { get; set; }
//         }
     }
 }
