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
    class ApiService : IApiService
    {
        private IApiResource _apiResource;
        public ApiService(IApiResource apiResource)
        {
            _apiResource = apiResource;
        }

        public UserResponse GetUser(Int32 Id)
        {
            string response = _apiResource.GetUser(Id);
            return JsonConvert.DeserializeObject<UserResponse>(response);
        }

        public UsersResponse GetUsers()
        {
            string response = _apiResource.GetUsers();
            return JsonConvert.DeserializeObject<UsersResponse>(response);
        }
    }
}
