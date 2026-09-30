using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternRobots
{
    public class RobotRegistry
    {
        private readonly Dictionary<string, Robot> _robotPrototypes = new Dictionary<string, Robot>();

        public RobotRegistry()
        {
            _robotPrototypes["SERVICE"] = new ServiceRobot("HealthBot-v1", 12.0, "v1.0.0", "Patient Assistance");
            _robotPrototypes["INDUSTRIAL"] = new IndustrialRobot("AutoArm-3000", 24.0, "v2.1.0", "Precision Welding");
            _robotPrototypes["ENTERTAINMENT"] = new EntertainmentRobot("DinoSpark", 8.0, "v1.5.2", "Interactive Dancing");
        }

        public Robot GetRobot(string type)
        {
            string key = type.ToUpper();
            if (_robotPrototypes.TryGetValue(key, out Robot prototype))
            {
                return (Robot)prototype.Clone();
            }
            throw new ArgumentException($"Unknown robot type: {type}");
        }
    }
}