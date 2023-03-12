using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DistributedSystems2020.Models
{
    public class ExchangeModel
    {
        public string Currency { get; set; }
        public ExchangeInfo Exchange { get; set; }
    }

    public class ExchangeInfo
    {
        public decimal amount { get; set; }
        public string Base {get; set;}
        public string date { get; set; }
        public ExchangeInfoRates rates { get; set; }
    }

    public class ExchangeInfoRates
    {
        public decimal BGN { get; set; }
    }
}