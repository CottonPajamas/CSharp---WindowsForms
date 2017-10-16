using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace BizApp01
{
    class RentalDAO
    {
        // Declaring Connection object
        SqlConnection cn;
        SqlCommand cmRetreiveByPlateNo;


        private static RentalDAO dbInstance;

        public static RentalDAO getInstance()
        {

            if (dbInstance == null)
                dbInstance = new RentalDAO();

            return dbInstance;
        }


        //Constructor
        private RentalDAO()
        {
            //This will establish the connection to the .mdf file.
            string strCN = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                           @"AttachDbFilename =|DataDirectory|BizApp01.mdf;" +
                           @"Integrated Security = true";

            cn = new SqlConnection(strCN);

            initializeSQLCmd();
        }

        private void initializeSQLCmd()      //This will all be created when this class is called.
        {
            //This will initialize our SqlCommand object that we have declared above.
            cmRetreiveByPlateNo = new SqlCommand();


            //This here will insert the sql 'code' into our respective objects. Depending on what we do.
            cmRetreiveByPlateNo.CommandText =
               "SELECT [VEHICLE-M], [VEHICLE-MODEL-M], [VEHICLE-COLOUR-T], [VEHICLE-ENGINE-T], [VEHICLE-RENT-STATUS-T] FROM VEHICLE WHERE [VEHICLE-M] = @VehiclePlateNo";
            cmRetreiveByPlateNo.Connection = cn;
        }

        //To open a connection with the database.
        public void openConnection()
        {
            cn.Open();
        }
        //To close a connection with the database.
        public void CloseConnection()
        {
            if (cn != null)
                cn.Close();
        }


        // 5 : Vehicle()  -  Will pass the request to the Vehicle entity
        public Vehicle RetrieveVehicle(String plateNo)
        {
            //Specifying the parameter 'plateNo'.
            SqlParameter pVehiclePlateNo = new SqlParameter("@VehiclePlateNo", SqlDbType.NVarChar, 7);
            pVehiclePlateNo.Value = plateNo;    //Assigning our input to the sql code

            // clear any previous parameters set before adding new parameters
            cmRetreiveByPlateNo.Parameters.Clear();

            // add the new parameters to the sql code
            cmRetreiveByPlateNo.Parameters.Add(pVehiclePlateNo);


            //Create a new vehicle object to contain all the necessary info when data is retrieved from the database.
            Vehicle v = new Vehicle(); ;


            // 6 : setAttr()  -   This will specify the attributes that will need to be retrieved from the connection.

            // execute reader to read based on our Sql command (aka 'cmRetreiveByPlateNo') and then contain all the info retrieved
            // into the vehicle object 'v'
            SqlDataReader rd = cmRetreiveByPlateNo.ExecuteReader();
            if (rd.Read())
            {
                v.VehiclePlateNo = rd["VEHICLE-M"].ToString();
                v.VehicleModel = rd["VEHICLE-MODEL-M"].ToString();
                v.VehicleColour = rd["VEHICLE-COLOUR-T"].ToString();
                v.EngineSerialNo = rd["VEHICLE-ENGINE-T"].ToString();
                v.VehicleStatus = rd["VEHICLE-RENT-STATUS-T"].ToString();
            }
            else
            {    //For exception when retrieving, here its if the plate no cant be found.
                throw new CarRentalException(CarRentalMessage.VehiclePlateNoNotFound);
            }

            // close SQLreader
            rd.Close();

            //This will return the vehicle object with all the relevant info back to the :EnquireStatusControl
            return v;
        }


    }
}
