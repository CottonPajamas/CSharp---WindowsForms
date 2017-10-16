using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizApp01
{
    class Vehicle
    {
        private String vehiclePlateNo;
        private String vehicleModel;
        private String vehicleColour;
        private String engineSerialNo;
        private String vehicleStatus;

        public string VehiclePlateNo
        {
            get
            {
                return vehiclePlateNo;
            }

            set
            {
                vehiclePlateNo = value;
            }
        }

        public string VehicleModel
        {
            get
            {
                return vehicleModel;
            }

            set
            {
                vehicleModel = value;
            }
        }
        public string VehicleColour
        {
            get
            {
                return vehicleColour;
            }

            set
            {
                vehicleColour = value;
            }
        }

        public string EngineSerialNo
        {
            get
            {
                return engineSerialNo;
            }

            set
            {
                engineSerialNo = value;
            }
        }

        public string VehicleStatus
        {
            get
            {
                return vehicleStatus;
            }

            set
            {
                vehicleStatus = value;
            }
        }
    }
}
