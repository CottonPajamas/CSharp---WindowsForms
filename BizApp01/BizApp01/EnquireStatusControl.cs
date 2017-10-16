using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizApp01
{
    class EnquireStatusControl
    {
        public Vehicle RetrieveVehicle(String plateNo)
        {
            // 4 : retrieveCustomer()  -  Request is process here and then send to the VehicleDAO class
            //Please bear in mind that the info from the form is inside the string container called 'plateNo'


            //Need to declare the object as usual and then initialize it.
            RentalDAO vehicleDAO = RentalDAO.getInstance();

            try
            {
                //This will open the connection to the DAO class and then the object with the infor
                //collected from the form can then be pass on to there for retrieval.
                vehicleDAO.openConnection();
                Vehicle v = vehicleDAO.RetrieveVehicle(plateNo);
                return v;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                vehicleDAO.CloseConnection();
            }
        }
    }
}
