using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Models.Api
{
    public class UsersResponse : BaseResponse
    {
        [JsonProperty(PropertyName = "data")]
        public User[] Data;
        [JsonProperty(PropertyName = "page")]
        public Int32 Page;
        [JsonProperty(PropertyName = "per_page")]
        public Int32 PerPage;
        [JsonProperty(PropertyName = "total")]
        public Int32 Total;
        [JsonProperty(PropertyName = "TotalPages")]
        public Int32 TotalPages;
    }
}
