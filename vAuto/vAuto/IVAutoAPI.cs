using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vAuto
{
    public interface IVAutoAPI
    {
        string GetDataSetId();
        VehicleIdList GetVehicleList(string datasetId);
        VehicleWithDealer GetVehicleDetails(string datasetId, int vehicleId);
        DealerDetails GetDealerDetails(string datasetId, int dealerId);
        AnswerResponse SaveDealerAndVehicleDetails(string datasetId, List<Dealers> objdealerList);
    }
}
