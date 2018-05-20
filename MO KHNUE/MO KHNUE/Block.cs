using MO_KHNUE.Controllers;
using MO_KHNUE.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE
{
    public class Block<T> : SolidComponent where T : class
    {
        private T currentValue = null;
        public virtual T Value
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }
    }
}
