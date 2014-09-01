using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Undomain.API.ServiceModel.Messages;
using Undomain.API.Interfaces;


namespace Undomain.API.ServiceDefinition
{
    public class ElementsService : Service
    {
        private readonly IElementsManager manager;

        public ElementsService(IElementsManager manager)
        {
            this.manager = manager;
        }

        public GetElementsResponse Get(GetElements request)
        {
            GetElementsResponse response = new GetElementsResponse();

            if (request.ID == 0)
            {
                response.Elements = this.manager.GetElements();
            }
            else
            {
                response.Elements = this.manager.GetElement(request.ID);
            }

            return response;
        }
    }

}
