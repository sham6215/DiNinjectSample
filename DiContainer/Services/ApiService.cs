using DiContainer.Models;
using DiContainer.Models.Api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Services
{
    class ApiService
    {
        private string _Domain;
        private bool _IsHttps;
        public ApiService(string domain) : this(domain, true)
        {
        }
        public ApiService(string domain, bool isHttps)
        {
            _Domain = domain;
            _IsHttps = isHttps;
        }

        private string _RootUrl;

        public string RootUrl
        {
            get
            {
                if (String.IsNullOrEmpty(_RootUrl))
                {
                    _RootUrl = String.Format("http{0}://{1}", _IsHttps ? "s" : "", _Domain);
                }
                return _RootUrl;
            }
        }

        private string _ApiGet(string uri)
        {
            string url = _GetUrl(uri);
            using (WebClient client = GetWebClient())
            {
                return client.DownloadString(url);
            }
        }

        private string _GetUrl(string uri)
        {
            return RootUrl + uri;
        }

        private WebClient GetWebClient()
        {
            WebClient client = new WebClient();
            return client;
        }

        private string _ApiPost(string url)
        {
            throw new NotImplementedException("_ApiPost is not implemented");
        }

        public UserResponse GetUser(Int32 Id)
        {
            string response = _ApiGet(String.Format(Properties.Settings.ApiUriUser, Id));
            return JsonConvert.DeserializeObject<UserResponse>(response);
        }

        public UsersResponse GetUsers()
        {
            string response = _ApiGet(Properties.Settings.ApiUriUsers);
            return JsonConvert.DeserializeObject<UsersResponse>(response);
        }
    }
}
