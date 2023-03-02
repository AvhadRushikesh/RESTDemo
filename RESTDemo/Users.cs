using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTDemo
{
    public class User
    {
        // Copy all the Data from API and Paste Special JSON as Classes
        public DateTime createdAt { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
        public string id { get; set; }
    }
}