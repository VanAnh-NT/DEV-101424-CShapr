using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt04_03
{
    internal interface IStorage
    {
        void Read(object filename);
        void Write(object filename);
    }
}
