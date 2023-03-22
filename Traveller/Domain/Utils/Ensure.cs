using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Utils
{
    public static class Ensure
    {
        public static void ArgumentNotNull(object argument, Exception exception)
        {
            if (argument == null)
            {
                throw exception;
            }
        }
    }
}
