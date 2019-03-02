using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vAuto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace vAutoTest
{
    public static class GetDealeardetails
    {

        public static List<Dealers> GetDealerListDetails()
        {
            List<Dealers> objDealerList = new List<Dealers>();
            string SampleData = @"[ { ""vehicles"": [ { ""vehicleId"": 849143882, ""year"": 2016, ""make"": ""Bentley"", ""model"": ""Mulsanne"" }, { ""vehicleId"": 750162307, ""year"": 1979, ""make"": ""Cheverolet"", ""model"": ""Corvette"" }, { ""vehicleId"": 922566039, ""year"": 2012, ""make"": ""Nissan"", ""model"": ""Altima"" } ], ""dealerId"": 1138613154, ""name"": ""Doug's Doozies"" }, { ""vehicles"": [ { ""vehicleId"": 1290763659, ""year"": 2013, ""make"": ""Mitsubishi"", ""model"": ""Gallant"" }, { ""vehicleId"": 2046726089, ""year"": 2016, ""make"": ""Kia"", ""model"": ""Soul"" }, { ""vehicleId"": 117075685, ""year"": 2009, ""make"": ""Ford"", ""model"": ""F150"" } ], ""dealerId"": 1836197501, ""name"": ""House of Wheels"" }, { ""vehicles"": [ { ""vehicleId"": 1920928249, ""year"": 2016, ""make"": ""Honda"", ""model"": ""Accord"" }, { ""vehicleId"": 581263509, ""year"": 2004, ""make"": ""MINI"", ""model"": ""Cooper"" }, { ""vehicleId"": 1894862680, ""year"": 2014, ""make"": ""Ford"", ""model"": ""F150"" } ], ""dealerId"": 1109418236, ""name"": ""Bob's Cars"" } ]";
            objDealerList = JsonConvert.DeserializeObject<List<Dealers>>(SampleData);
            return objDealerList;
        }

        public static List<Dealers> GetDealerListDetailsWithInvalidData()
        {
            List<Dealers> objDealerList = new List<Dealers>();
            string SampleData = @"[ { ""vehicles"": [ { ""vehicleId"": 849143882, ""year"": 2016, ""make"": ""Bentley"", ""model"": ""Mulsanne"" }, { ""vehicleId"": 750162307, ""year"": 1979, ""make"": ""Cheverolet"", ""model"": ""Corvette"" }, { ""vehicleId"": 922566039, ""year"": 2012, ""make"": ""Nissan"", ""model"": ""Altima"" } ], ""dealerId"": 1138613159, ""name"": ""Doug's Doozies"" }, { ""vehicles"": [ { ""vehicleId"": 1290763659, ""year"": 2013, ""make"": ""Mitsubishi"", ""model"": ""Gallant"" }, { ""vehicleId"": 2046726089, ""year"": 2016, ""make"": ""Kia"", ""model"": ""Soul"" }, { ""vehicleId"": 117075685, ""year"": 2009, ""make"": ""Ford"", ""model"": ""F150"" } ], ""dealerId"": 1836197501, ""name"": ""House of Wheels"" }, { ""vehicles"": [ { ""vehicleId"": 1920928249, ""year"": 2016, ""make"": ""Honda"", ""model"": ""Accord"" }, { ""vehicleId"": 581263509, ""year"": 2004, ""make"": ""MINI"", ""model"": ""Cooper"" }, { ""vehicleId"": 1894862680, ""year"": 2014, ""make"": ""Ford"", ""model"": ""F150"" } ], ""dealerId"": 1109418236, ""name"": ""Bob's Cars"" } ]";
            objDealerList = JsonConvert.DeserializeObject<List<Dealers>>(SampleData);
            return objDealerList;
        }
    }
}
