using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class IntException : ArgumentException
    {
        public IntException(string message) : base(message)
        {

        }
    }
}
