using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undomain.API.ServiceModel.Types
{
    public class Element
    {
        public int ID { get; set; }
        public int Type { get; set; }
        public string ValueFamily { get; set; }
        public string Value { get; set; }
        public int ParentID { get; set; }
        public ICollection<Element> Children { get; set; }
        public ICollection<Element> Attributes { get; set; }
        public Element Parent { get; set; }
    }
}
