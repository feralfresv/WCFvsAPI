using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WCFvsAPI1
{
    [DataContract]
    public class SearchResultModified
    {
        public string videoId;
        public string title;
        public string imageUrl;

        [DataMember]
        public string VideoId {
            get { return videoId; }
            set { videoId = value; }
        }
        [DataMember]
        public string Title {
            get {return title; }
            set { title = value; }
        }
        [DataMember]
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
    }


}