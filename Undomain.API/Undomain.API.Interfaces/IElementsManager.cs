using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undomain.API.ServiceModel.Types;

namespace Undomain.API.Interfaces
{
    public interface IElementsManager
    {
        IEnumerable<Element> GetElements();

        IEnumerable<Element> GetElement(int ID);
    }
}
