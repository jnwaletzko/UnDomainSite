using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undomain.API.ServiceModel.Types;

namespace Undomain.API.Interfaces
{
    public interface IElementsRepository
    {
        IEnumerable<Element> GetElements();

        Element GetElement(int ID);
    }
}
