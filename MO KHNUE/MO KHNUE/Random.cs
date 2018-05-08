using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MO_KHNUE
{
    public static class Rand
    {
        private static Random random = new Random((int)DateTime.UtcNow.Ticks);

        public static Guid RandGuid()
        {
            byte[] arr = new byte[16];
            random.NextBytes(arr);
            return new Guid(arr);
        }
    }
}
