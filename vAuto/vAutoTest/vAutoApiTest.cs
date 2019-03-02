using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vAuto;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;

namespace vAutoTest
{
    [TestClass]
    public class vAutoApiTest 
    {
        private static IVAutoAPI objvAutoApi = new VAutoAPI();
        [TestMethod]
        public void GetDataSetID()
        {
            Assert.IsTrue(objvAutoApi.GetDataSetId().ToString().Length > 0);
        }

        [TestMethod]
        public void GetVehicleListWithValidDatasetId()
        {
            VehicleIdList objVehicleIdList = objvAutoApi.GetVehicleList(objvAutoApi.GetDataSetId());
            Assert.IsTrue(objVehicleIdList.vehicleIds.Count > 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),"Datasetid cant'be empty")]
        public void GetVehicleListWithEmptyDatasetId()
        {
            VehicleIdList objVehicleIdList = objvAutoApi.GetVehicleList(string.Empty);
        }

        [TestMethod]
        public void GetVehicleListWithInValidDatasetId()
        {
            VehicleIdList objVehicleIdList = objvAutoApi.GetVehicleList("testdata");
            Assert.IsNull(objVehicleIdList.vehicleIds);
        }
        [TestMethod]
        public void GetDealerDetailsWithValidDatasetIdAndValidDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails("EUWoYwSe1gg", 377391714);
            Assert.IsTrue(objDealerDetials.dealerId == 377391714);
        }
        [TestMethod]
        public void GetDealerDetailsWithInValidDatasetIdAndValidDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails("EUWoYwSe1g", 377391714);
            Assert.IsTrue(objDealerDetials.dealerId == 0);
        }

        [TestMethod]
        public void GetDealerDetailsWithValidDatasetIdAndInValidDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails("EUWoYwSe1gg", 377317140);
            Assert.IsTrue(objDealerDetials.dealerId == 0);
        }

        [TestMethod]
        public void GetDealerDetailsWithInValidDatasetIdAndInValidDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails("EUWoYwSe1g", 377317140);
            Assert.IsTrue(objDealerDetials.dealerId == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid cant'be empty")]
        public void GetDealerDetailsWithEmptyDatasetIdAndValidDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails(String.Empty, 377391714);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "DealerId cant'be less than 0")]
        public void GetDealerDetailsWithValidDatasetIdAndNegativeDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails("EUWoYwSe1gg", -377391714);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid cant'be empty and DealerId cant'be less than 0")]
        public void GetDealerDetailsWithEmptyDatasetIdAndNegativeDealerId()
        {
            DealerDetails objDealerDetials = new DealerDetails();
            objDealerDetials = objvAutoApi.GetDealerDetails(String.Empty, -377391714);
        }
        
        [TestMethod]
        public void GetVehicleDetailsWithValidDatasetIdAndValidvehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails("EUWoYwSe1gg", 459605654);
            Assert.IsTrue(objDealerDetials.vehicleId == 459605654);
        }
        [TestMethod]
        public void GetVehicleDetailsWithInValidDatasetIdAndValidvehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails("EUWoYwSe1g", 459605654);
            Assert.IsTrue(objDealerDetials.vehicleId == 0);
        }

        [TestMethod]
        public void GetVehicleDetailsWithValidDatasetIdAndInValidvehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails("EUWoYwSe1gg", 459609654);
            Assert.IsTrue(objDealerDetials.vehicleId == 0);
        }

        [TestMethod]
        public void GetVehicleDetailsWithInValidDatasetIdAndInValidvehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails("EUWoYwSe1g", 459609654);
            Assert.IsTrue(objDealerDetials.vehicleId == 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid cant'be empty")]
        public void GetVehicleDetailsWithEmptyDatasetIdAndValidvehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails(String.Empty, 459605654);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "vehicleId cant'be less than 0")]
        public void GetVehicleDetailsWithValidDatasetIdAndNegativevehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails("EUWoYwSe1gg", -459605654);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid cant'be empty and vehicleId cant'be less than 0")]
        public void GetVehicleDetailsWithEmptyDatasetIdAndNegativevehicleId()
        {
            VehicleWithDealer objDealerDetials = new VehicleWithDealer();
            objDealerDetials = objvAutoApi.GetVehicleDetails(String.Empty, -459605654);
        }

        [TestMethod]
        public void SaveDealerAndVehicleDetailsWithValidDatasetIdandValidDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("cw3m4aee1gg", GetDealeardetails.GetDealerListDetails());
            Assert.IsTrue(objAnswerResponse.success);
        }

        [TestMethod]
        public void SaveDealerAndVehicleDetailsWithValidDatasetIdandInValidDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("cw3m4aee1gg", GetDealeardetails.GetDealerListDetailsWithInvalidData());
            Assert.IsFalse(objAnswerResponse.success);
        }

        [TestMethod]
        public void SaveDealerAndVehicleDetailsWithInValidDatasetIdandValidDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("cw3m4aee", GetDealeardetails.GetDealerListDetails());
            Assert.IsFalse(objAnswerResponse.success);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid cant'be empty")]
        public void SaveDealerAndVehicleDetailsWithEmptyDatasetIdandValidDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("", GetDealeardetails.GetDealerListDetails());
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Dealer's cant'be empty")]
        public void SaveDealerAndVehicleDetailsWithValidDatasetIdandEmptyDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("cw3m4aee1gg", new List<Dealers>());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Datasetid and Dealer's cant'be empty")]
        public void SaveDealerAndVehicleDetailsWithEmptyDatasetIdandEmptyDealerDetails()
        {
            AnswerResponse objAnswerResponse = new AnswerResponse();
            objAnswerResponse = objvAutoApi.SaveDealerAndVehicleDetails("", new List<Dealers>());
        }

    }
}
