using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistributedSystems2020.Models;
using System.Net;
using Newtonsoft.Json;
using System.Web.UI.WebControls;

namespace DistributedSystems2020.Controllers {
    public class HomeController : Controller {
        public ActionResult Index( string id ) {
            var viewModel = new IndexViewModel() {
                Title = "Проверка на винетка " + id,
                //Description = body
            };
            
            var bgTollUrl = "https://check.bgtoll.bg/check/vignette/plate/BG/";

            var client = new WebClient();
            var body = "";
            if ( id != null && id != "" ) {
                body = client.DownloadString( bgTollUrl + id );
                viewModel.BgToll = JsonConvert.DeserializeObject<BGTollModel>( body );
            }
            
            return View( viewModel );
        }

        public ActionResult Weather( string city ) {
            var viewModel = new WeatherModel() {
                City = city
            };

            if ( city != null && city != "" ) {
                var apiKey = "5afa920673234dc90e1018bf6f4ceeb2";
                var info = new WebClient()
                    .DownloadString( 
        $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric" );

                viewModel.Weather = JsonConvert.DeserializeObject<WeatherInfo>( info );
            }

            return View( viewModel );
        }

        public ActionResult Hero(string hero)
        {
            var viewModel = new HeroModel()
            {
                Hero = hero
            };

            if (hero != null && hero != "")
            {
                var apiKey = "3428129700567785";
                var info = new WebClient()
                    .DownloadString(
        $"https://www.superheroapi.com/api.php/{apiKey}/search/{hero}");

                viewModel.SuperHero = JsonConvert.DeserializeObject<HeroInfo>( info );
            }

            return View(viewModel);
        }

        public ActionResult Movie(string title)
        {
            var viewModel = new MovieModel()
            {
                Title = title
            };

            if (title != null && title != "")
            {
                var apiKey = "b78be101";
                var info = new WebClient()
                    .DownloadString(
        $"http://www.omdbapi.com/?t={title}&apikey={apiKey}");

                viewModel.Movie = JsonConvert.DeserializeObject<MovieInfo>(info);
            }

            return View(viewModel);
        }

        public ActionResult Artist(string artistName)
        {
            var viewModel = new ArtistModel()
            {
                ArtistName = artistName
            };

            if (artistName != null && artistName != "")
            {
                var test = new WebClient()
                    .DownloadString(
        $"https://www.theaudiodb.com/api/v1/json/1/search.php?s={artistName}");

                viewModel.Artist = JsonConvert.DeserializeObject<ArtistInfo>(test);
            }

            return View(viewModel);
        }

        public ActionResult Exchange(string currency)
        {
            var viewModel = new ExchangeModel()
            {
                Currency = currency
            };

            if (currency != null && currency != "")
            {
                var to = "BGN";
                var test = new WebClient()
                    .DownloadString(
        $"https://api.frankfurter.app/latest?from={currency}&to={to}");

                viewModel.Exchange = JsonConvert.DeserializeObject<ExchangeInfo>(test);
            }

            return View(viewModel);
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}