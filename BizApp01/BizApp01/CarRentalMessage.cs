using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizApp01
{
    class CarRentalMessage
    {
        public const String RegularErrorMsg
            = "The system is current unavailable. Please restart and try again.";

        public const String VehiclePlateNoFound
            = "Vehicle plate number is successfully retrieved.";

        public const String VehiclePlateNoNotFound
            = "Vehicle plate number you have entered is incorrect. Please try again.";
    }
}
