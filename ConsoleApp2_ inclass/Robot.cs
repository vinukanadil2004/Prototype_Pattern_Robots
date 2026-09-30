using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternRobots
{
    public abstract class Robot : ICloneable
    {
        public string ModelName { get; set; }
        public double BatteryCapacity { get; set; } s
        public string SoftwareVersion { get; set; }

        public Robot(string modelName, double batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract object Clone();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {ModelName} | Battery: {BatteryCapacity}h | Software: {SoftwareVersion}");
        }
    }
}
