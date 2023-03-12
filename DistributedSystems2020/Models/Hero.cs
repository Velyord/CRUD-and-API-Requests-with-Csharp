using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models {
    public class HeroModel {
        public string Hero { get; set; }
        public HeroInfo SuperHero { get; set; }
    }

    public class HeroInfo {
        public List<HeroInfoResults> results { get; set; }
    }
    public class HeroInfoResults
    {
        public string name { get; set; }
        public HeroInfoResultsPowerstats powerstats {get;set;}
        public HeroInfoResultsBiography biography { get; set; }
        public HeroInfoResultsAppearance appearance { get; set; }
        public HeroInfoResultsWork work { get; set; }
        public HeroInfoResultsImage image { get; set; }
    }
    public class HeroInfoResultsPowerstats {
        public string intelligence { get; set; }
        public string strength { get; set; }
        public string speed { get; set; }
        public string durability { get; set; }
        public string power { get; set; }
        public string combat { get; set; }
    }
    public class HeroInfoResultsBiography
    {
        [JsonProperty("full-name")]
        public string full_name {get;set;}
        [JsonProperty("place-of-birth")]
        public string place_of_birth { get; set; }
        public string publisher { get; set; }
        public string alignment { get; set; }
    }
    public class HeroInfoResultsAppearance
    {
        public string gender { get; set; }
        public string race { get; set; }
        [JsonProperty("eye-color")]
        public string eye_color { get; set; }
        [JsonProperty("hair-color")]
        public string hair_color { get; set; }
    }
    public class HeroInfoResultsWork
    {
        public string occupation { get; set; }
        public string Base { get; set; }
    }
    public class HeroInfoResultsImage
    {
        public string url { get; set; }
    }
}