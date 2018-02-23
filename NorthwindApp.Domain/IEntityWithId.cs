using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NorthwindApp.Domain
{
    public interface IEntityWithId
    {
        int Identificador { get; }
    }
}
