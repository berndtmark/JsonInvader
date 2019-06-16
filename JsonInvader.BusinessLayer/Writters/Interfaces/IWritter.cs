using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInvader.BusinessLayer.Writters.Interfaces
{
    public interface IWritter
    {
        bool Write(IList<string> content);
    }
}
