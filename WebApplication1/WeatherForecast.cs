using System;
using System.Runtime.Serialization;

namespace WebApplication1
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    
    [DataContract]
    public class Town
    {
        [DataMember]
        public int Id {get; set;}

        /// <summary>
        /// Name of item description
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name = "name")]
        public string Name {get; set;}
    }
}