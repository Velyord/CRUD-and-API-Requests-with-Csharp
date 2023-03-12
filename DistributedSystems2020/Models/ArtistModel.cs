using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models
{
    public class ArtistModel
    {
        public string ArtistName { get; set; }
        public ArtistInfo Artist { get; set; }
    }

    public class ArtistInfo
    {
        public List<ArtistInfoArtists> artists { get; set; }
    }

    public class ArtistInfoArtists
    {
        public string strArtist { get; set; }
     // public decimal intBornYear { get; set; }
     // public decimal intDiedYear { get; set; }
        public decimal intFormedYear { get; set; }
        public string strStyle { get; set; }
        public string strGenre { get; set; }
        public string strMood { get; set; }
        public string strBiographyEN { get; set; }
        public string strGender { get; set; }
        public decimal intMembers { get; set; }
        public string strCountry { get; set; }
        public string strArtistThumb { get; set; }
    }
}