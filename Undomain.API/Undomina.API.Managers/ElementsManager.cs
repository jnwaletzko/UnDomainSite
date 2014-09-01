using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undomain.API.Interfaces;
using Undomain.API.ServiceModel.Types;

namespace Undomain.API.Managers
{
    public class ElementsManager : IElementsManager
    {
        private readonly IElementsRepository repository;

        public ElementsManager(IElementsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Element> GetElements()
        {
            return repository.GetElements();
        }

        public IEnumerable<Element> GetElement(int ID)
        {
            List<Element> elements = new List<Element>();
            elements.Add(repository.GetElement(ID));
            return elements;
        }
    }
}
