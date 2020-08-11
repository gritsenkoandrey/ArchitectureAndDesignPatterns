using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_3
{
    public interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}