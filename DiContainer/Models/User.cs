using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Models
{
    public class User
    {
        
        [JsonProperty(PropertyName = "id")]
        public Int32 Id;
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName;
        [JsonProperty(PropertyName = "last_name")]
        public string LastName;
        [JsonProperty(PropertyName = "avatar")]
        public string Avatar;
    }
}
