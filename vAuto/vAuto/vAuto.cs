using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vAuto
{
    public partial class vAuto : Form
    {
        private static IVAutoAPI objvAutoApi = new VAutoAPI();

        public vAuto()
        {
            InitializeComponent();
        }


        private static  string GetDataSetId()
        {
            return  objvAutoApi.GetDataSetId();
        }

        private static VehicleIdList GetVehicleIdList(string datasetId)
        {
            return  objvAutoApi.GetVehicleList(datasetId);
        }



        private static List<VehicleWithDealer> GetVehicleDetailsList(string datasetId, VehicleIdList vehicleIdList)
        {
            List<VehicleWithDealer> objVehicleDetails = new List<VehicleWithDealer>();
            foreach (int vehicleId in vehicleIdList.vehicleIds)
            {


                objVehicleDetails.Add( objvAutoApi.GetVehicleDetails(datasetId, vehicleId));
            }
            return objVehicleDetails;
        }

        private static List<DealerDetails> GetDealerDetailsList(string datasetId, List<VehicleWithDealer> vehicleDetailsList)
        {
            List<DealerDetails> objDealerDetailsList = new List<DealerDetails>();
            var dealerIds = from vehicle in vehicleDetailsList select new { vehicle.dealerId };
            var dealerIdList = dealerIds.Distinct();
            foreach (var item in dealerIdList)
            {
                objDealerDetailsList.Add( objvAutoApi.GetDealerDetails(datasetId, item.dealerId));
            }
            return objDealerDetailsList;
        }

        private static List<Dealers> GetDealerWithVehicalsDetails(List<DealerDetails> dealerDetailsList, List<VehicleWithDealer> objVehicaleDetilsList)
        {

            List<Dealers> objDealerList = new List<Dealers>();
            foreach (DealerDetails dealerDetails in dealerDetailsList)
            {

                Dealers objDealers = new Dealers();
                List<Vehicle> objVehicleList = new List<Vehicle>();
                var dealerVechiles = objVehicaleDetilsList.Where(m => m.dealerId == dealerDetails.dealerId);
                foreach (var dealerVechile in dealerVechiles)
                {

                    Vehicle objVehicle = new Vehicle();
                    objVehicle.vehicleId = dealerVechile.vehicleId;
                    objVehicle.year = dealerVechile.year;
                    objVehicle.make = dealerVechile.make;
                    objVehicle.model = dealerVechile.model;
                    objVehicleList.Add(objVehicle);

                }
                objDealers.dealerId = dealerDetails.dealerId;
                objDealers.name = dealerDetails.name;
                objDealers.vehicles = objVehicleList;
                objDealerList.Add(objDealers);
            }
            return objDealerList;
        }
        private  void btnProcess_Click(object sender, EventArgs e)
        {
            lblloading.Visible = true;
            string datasetId =  GetDataSetId();
            txtDatasetId.Text = datasetId;
            VehicleIdList objVehicleIdList =  GetVehicleIdList(datasetId);

            List<VehicleWithDealer> objVehicleWithDealer =  GetVehicleDetailsList(datasetId, objVehicleIdList);

            List<DealerDetails> objDealerDetailsList =  GetDealerDetailsList(datasetId, objVehicleWithDealer);

            List<Dealers> objDealersList =  GetDealerWithVehicalsDetails(objDealerDetailsList, objVehicleWithDealer);

            var dealerWapper = new { dealers = objDealersList };
            txtInput.Text = JToken.Parse(JsonConvert.SerializeObject(dealerWapper)).ToString(Formatting.Indented);
            AnswerResponse response =  objvAutoApi.SaveDealerAndVehicleDetails(datasetId, objDealersList);
            txtResponse.Text = JToken.Parse((JsonConvert.SerializeObject(response))).ToString(Formatting.Indented);
            lblloading.Visible = false;
        }
    }
}
