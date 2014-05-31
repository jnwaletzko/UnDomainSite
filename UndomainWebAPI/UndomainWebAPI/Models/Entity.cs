using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UndomainWebAPI.Models
{
    public class Entity
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public string ValueFamily { get; set; }
        public string Value { get; set; }
        public int ParentID { get; set; }
    }
}