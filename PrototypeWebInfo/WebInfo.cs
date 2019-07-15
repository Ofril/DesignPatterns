using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebInfo
{
    class WebInfo : IProtoType<WebInfo>
    {
        DateTime timestamp;
        string size;
        string url;

        public WebInfo(DateTime timestamp, string size, string url)
        {
            this.timestamp = timestamp;
            this.size = size;
            this.url = url;
        }

        public WebInfo clone()
        {
            return new WebInfo(timestamp, size, url);
        }

        public string ToString()
        {
            return $"Timestamp: {timestamp} Size: {size} Url: {url} "; 
        }
    }
}
