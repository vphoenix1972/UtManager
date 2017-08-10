using System.Collections.Generic;
using UtManager.Utils;

namespace UtManager.Web.Models
{
    public sealed class WebApiErrorModel
    {
        [NotNull]
        public IList<object> Errors { get; set; } = new List<object>();
    }
}