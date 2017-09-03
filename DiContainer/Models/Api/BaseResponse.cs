using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiContainer.Models
{
    public class BaseResponse
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
    }
}
