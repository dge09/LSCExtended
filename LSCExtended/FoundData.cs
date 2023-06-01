using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCExtended
{
    public class FoundData
    {
        public string Data { get; set; }
        public string Category { get; set; }
        public string Link { get; set; }

        public FoundData()
        { }

        public FoundData(string data, string category, string link)
        {
            Data = data;
            Category = category;
            Link = link;
        }
    }
}
