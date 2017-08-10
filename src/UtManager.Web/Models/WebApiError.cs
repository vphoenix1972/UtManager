using Newtonsoft.Json;
using UtManager.Utils;

namespace UtManager.Web.Models
{
    public class WebApiError
    {
        public int Code { get; set; } = 1;

        [NotNull]
        public string Message { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [CanBeNull]
        public object Info { get; set; }
    }
}