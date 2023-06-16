using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSCExtended.Models
{

    public class FoundData
    {
        public int? FDID { get; set; }
        public string FData { get; set; }
        public string Category { get; set; }
        public string Link { get; set; }

        public FoundData()
        { }

        public FoundData(string data, string category, string link)
        {
            FData = data;
            Category = category;
            Link = link;
        }

        public FoundData(int id, string data, string category, string link)
        {
            FDID = id;
            FData = data;
            Category = category;
            Link = link;
        }

    }
}
