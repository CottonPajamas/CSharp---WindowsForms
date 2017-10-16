using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizApp01
{
    class CarRentalException : ApplicationException
    {
        public CarRentalException() : base()
        {

        }
        public CarRentalException(string message) : base(message)
        {

        }
    }
}
