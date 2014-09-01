using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace Undomain.API.ServiceModel.Messages
{
    [Route("/Elements/", "GET")]
    [Route("/Elements/{ID}", "GET")]
    public class GetElements : IReturn<GetElementsResponse> {

        public int ID { get; set; }
    }
}
