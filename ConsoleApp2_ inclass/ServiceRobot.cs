using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternRobots
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(string modelName, double batteryCapacity, string softwareVersion, string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override object Clone()
        {
            return new ServiceRobot(ModelName, BatteryCapacity, SoftwareVersion, ServiceTask);
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"   Task Type: Service | Service Task: {ServiceTask}");
        }
    }
}