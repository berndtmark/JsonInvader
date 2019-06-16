using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInvader.BusinessLayer.Readers.Interfaces
{
    public interface IReader
    {
        T Read<T>();
    }
}
