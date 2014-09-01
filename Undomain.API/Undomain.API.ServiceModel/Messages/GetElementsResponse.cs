using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Undomain.API.ServiceModel.Types;

namespace Undomain.API.ServiceModel.Messages
{
    public class GetElementsResponse : IHasResponseStatus
    {
        public IEnumerable<Element> Elements {get; set;}

        public ResponseStatus ResponseStatus { get; set; }
    }
}
