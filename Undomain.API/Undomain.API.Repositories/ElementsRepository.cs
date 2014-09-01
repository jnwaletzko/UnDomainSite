using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undomain.API.Interfaces;
using Undomain.API.ServiceModel.Types;

namespace Undomain.API.Repositories
{
    public class ElementsRepository : IElementsRepository
    {
        public ElementsRepository()
        {

        }

        public IEnumerable<Element> GetElements()
        {
            return new List<Element> { new Element { ID = 1, ValueFamily = "test1", Value = "test1" }, new Element { ID = 2, ValueFamily = "test2", Value = "test2" } };
        }

        public Element GetElement(int ID)
        {
            return new Element { ID = ID, Value = "NOT A LIST", ValueFamily = "testElement" };
        }
    }
}
