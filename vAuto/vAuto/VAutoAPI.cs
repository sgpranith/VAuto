using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace vAuto
{
    public class VAutoAPI : IVAutoAPI
    {

        private static HttpClient client = new HttpClient();
        /// <summary>
        /// Constructor set the HttpClient properties 
        /// </summary>
        public VAutoAPI()
        {
            client.BaseAddress = new Uri("http://vautointerview.azurewebsites.net/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        /// <summary>
        /// This method get the datasetId.
        /// </summary>
        /// <returns></returns>
        public string GetDataSetId()
        {
            try
            {
                string path = "datasetId";
                HttpResponseMessage response = client.GetAsync(path).Result;
                DataSet objDataSet = new DataSet();
                if (response.IsSuccessStatusCode)
                {
                    objDataSet =
                        response.Content.ReadAsAsync<DataSet>().Result;

                }
                return objDataSet.datasetId;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Get the dealers details for given datasetId and dealerId.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="dealerId"></param>
        /// <returns></returns>
        public DealerDetails GetDealerDetails(string datasetId, int dealerId)
        {
            if (datasetId.Length <= 0)
            {
                throw new ArgumentException("DatasetId can't be empty");
            }
            if (dealerId <= 0)
            {
                throw new ArgumentException("dealerId  can't be less than 0");
            }
            try
            {
                string path = datasetId + "/dealers/" + dealerId.ToString();
                DealerDetails objDealerDetails = new DealerDetails();
                HttpResponseMessage response = client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    objDealerDetails = response.Content.ReadAsAsync<DealerDetails>().Result;

                }
                return objDealerDetails;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// This method gets the Vehicle details from the given datasetId and vehicleId.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="vehicleId"></param>
        /// <returns></returns>
        public VehicleWithDealer GetVehicleDetails(string datasetId, int vehicleId)
        {
            if (datasetId.Length <= 0)
            {
                throw new ArgumentException("DatasetId can't be empty");
            }
            if (vehicleId <= 0)
            {
                throw new ArgumentException("vehicleId  can't be less than 0");
            }
            try
            {
                string path = datasetId + "/vehicles/" + vehicleId.ToString();
                VehicleWithDealer objVehicle = new VehicleWithDealer();
                HttpResponseMessage response = client.GetAsync(path).Result;
                if (response.IsSuccessStatusCode)
                {
                    objVehicle = response.Content.ReadAsAsync<VehicleWithDealer>().Result;

                }
                return objVehicle;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// This method gets the list of VehicleId's for the given datasetId.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <returns></returns>
        public VehicleIdList GetVehicleList(string datasetId)
        {
            VehicleIdList objVehicleIdList = new VehicleIdList();
            if(datasetId.Length<=0)
            {
                throw new ArgumentException("DatasetId can't be empty");
            }
            if (datasetId.Trim().Length >= 0)
            {
                try
                {
                    string path = datasetId + "/vehicles";
                    HttpResponseMessage response = client.GetAsync(path).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        objVehicleIdList = response.Content.ReadAsAsync<VehicleIdList>().Result;

                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
            return objVehicleIdList;
        }

        /// <summary>
        /// This method post the dealers and vehicle details for the give datasetId.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="objdealerList"></param>
        /// <returns></returns>
        public AnswerResponse SaveDealerAndVehicleDetails(string datasetId, List<Dealers> objdealerList)
        {
            if (datasetId.Length <= 0)
            {
                throw new ArgumentException("DatasetId can't be empty");
            }
            if (objdealerList.Count() <= 0)
            {
                throw new ArgumentException("Dealers details can't be empty");
            }
            try
            {
                var dealersWapper = new { dealers = objdealerList };
                string path = datasetId + "/answer";
                AnswerResponse objAnswerResponse = new AnswerResponse();
                HttpResponseMessage response = client.PostAsJsonAsync(path, dealersWapper).Result;
                if (response.IsSuccessStatusCode)
                {
                    objAnswerResponse = response.Content.ReadAsAsync<AnswerResponse>().Result;

                }
                return objAnswerResponse;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
