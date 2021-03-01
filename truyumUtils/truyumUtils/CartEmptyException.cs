using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace truyumUtils
{
    public class CartEmptyException : Exception
    {
        public CartEmptyException()
        {

        }
        public CartEmptyException(string msg)
            : base(msg)
        {

        }
    }
}
