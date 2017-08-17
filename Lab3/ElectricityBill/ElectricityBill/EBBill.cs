using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricityBill
{
    class EBBill
    {
        public static float metreRent { get; set; }
        string ownerName;
        string houseNumber;
        float unitsConsumed;
        public EBBill(string ownerName, string houseNumber, float unitsConsumed)
        {
            this.ownerName = ownerName;
            this.houseNumber = houseNumber;
            this.unitsConsumed = unitsConsumed;
        }
        public float calculateElectricityBill()
        {
            return 1.2f * unitsConsumed + metreRent;
        }
    }
}
