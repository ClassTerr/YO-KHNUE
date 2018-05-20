using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE.Controllers
{
    interface IBlock<T>
    {
        T Value { get; set; }
        void InitValue(T val);
    }
}
