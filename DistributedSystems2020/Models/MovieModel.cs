using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models {
    public class MovieModel {
        public string Title { get; set; }
        public MovieInfo Movie { get; set; }
    }

    public class MovieInfo {
        public string Title { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Country { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Awards { get; set; }
        public decimal imdbRating { get; set; }
        public string Poster { get; set; }
    }
}