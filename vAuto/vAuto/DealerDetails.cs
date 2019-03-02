using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vAuto
{
    public class DealerDetails
    {
        public int dealerId { get; set; }
        public string name { get; set; }
        
    }

    public class Dealers: DealerDetails
    {
        public List<Vehicle> vehicles { get; set; }
    }
}
