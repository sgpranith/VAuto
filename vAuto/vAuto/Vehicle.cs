using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vAuto
{
    public class Vehicle
    {
        public int vehicleId { get; set; }
        public int year { get; set; }
        public string make { get; set; }
        public string model { get; set; }
    }

    public class VehicleWithDealer : Vehicle
    {
        public int dealerId { get; set; }

    }

    public class VehicleIdList
    {
        public List<int> vehicleIds { get; set; }
    }
}
