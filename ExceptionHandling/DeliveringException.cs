using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class DeliveringException: Exception
    {
        public DeliveringException(string message) : base(message)
        {

        }
    }
}
