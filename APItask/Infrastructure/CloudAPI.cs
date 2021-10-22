using System.Net;
using Newtonsoft.Json;
using APItask.Models;
using System.Collections.Generic;

namespace APItask.Infrastructure
{
    public class CloudAPI
    {
        public static List<Cloud> Fetch()
        {
            string json = new WebClient().DownloadString("http://tasks.cloudsite.ir/api/");
            return JsonConvert.DeserializeObject<List<Cloud>>(json);
        }
    }
}
