using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternRobots
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTasklike { get; set; }

        public IndustrialRobot(string modelName, double batteryCapacity, string softwareVersion, string industrialTasklike)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTasklike = industrialTasklike;
        }

        public override object Clone()
        {
            return new IndustrialRobot(ModelName, BatteryCapacity, SoftwareVersion, IndustrialTasklike);
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"   Task Type: Industrial | Industrial Task: {IndustrialTasklike}");
        }
    }
}
