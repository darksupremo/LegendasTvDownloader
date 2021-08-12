﻿using System;
using System.Net;

namespace LegendasTv
{
    public class CustomWebClient : WebClient
    {
        public CookieContainer CookieContainer { get; set; }

        public CustomWebClient()
        {
            CookieContainer = new CookieContainer();
        }

        protected override WebRequest GetWebRequest( Uri address )
        {
            var request = base.GetWebRequest( address );
            (request as HttpWebRequest).UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.1; WOW64; Trident/6.0;)";
            if ( request is HttpWebRequest )
            {
                ( request as HttpWebRequest ).CookieContainer = CookieContainer;
            }
            return request;
        }

    }
}
