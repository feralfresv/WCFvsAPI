using API.Models;
using ConsoleClient.ServiceAcademy;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace API.Controllers
{
    public class YT_APIController : ApiController
    {
        [HttpGet]
        public List<SearchResultModified> BuscarLista(string palabra)
        {
            var ServicioYouTube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyCENuuzGXhwKTvQVsuG0HyhEYW9DWuXGPg",
                ApplicationName = this.GetType().ToString()
            });

            var BuscarListaSolicitud = ServicioYouTube.Search.List("snippet");
            BuscarListaSolicitud.Q = palabra; //Buscador
            BuscarListaSolicitud.MaxResults = 5;

            SearchListResponse BuscarListaRespuesta = BuscarListaSolicitud.Execute();
            IList<Google.Apis.YouTube.v3.Data.SearchResult> searchResults = BuscarListaRespuesta.Items;
            List<SearchResultModified> searchResultModifieds = new List<SearchResultModified>();

            foreach (var item in searchResults)
            {
                SearchResultModified searchResultC = new SearchResultModified();
                searchResultC.VideoId = item.Id.VideoId;
                searchResultC.ImageUrl = item.Snippet.Thumbnails.Default__.Url;
                searchResultC.Title = item.Snippet.Title;
                searchResultC.Title = item.Snippet.ChannelTitle;
                searchResultC.Expo = "Hello";

                searchResultModifieds.Add(searchResultC);
            }
            //return searchResults.ToList();
            return searchResultModifieds;

        }
    }
}
