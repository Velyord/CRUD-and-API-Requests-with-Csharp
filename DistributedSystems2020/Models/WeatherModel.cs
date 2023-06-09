﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models {
    public class WeatherModel {
        public string City { get; set; }
        public WeatherInfo Weather { get; set; }
    }

    public class WeatherInfo {
        public string name { get; set; }
        public List<WeatherInfoWeather> weather { get; set; }
        public WeatherInfoMain main { get; set; }
        public WeatherInfoWind wind { get; set; }
        public WeatherInfoSys sys { get; set; }
    }
    public class WeatherInfoMain {
        public decimal temp { get; set; }
        public decimal feels_like { get; set; }
        public decimal humidity { get; set; }
    }
    public class WeatherInfoWeather {

        public string description { get; set; }
    }
    public class WeatherInfoWind
    {
        public string speed { get; set; }
    }
    public class WeatherInfoSys
    {
        public string country { get; set; }
    }
}