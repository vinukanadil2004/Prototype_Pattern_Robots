using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrototypePatternRobots
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RobotRegistry registry = new RobotRegistry();

            ServiceRobot clonedServiceRobot = (ServiceRobot)registry.GetRobot("SERVICE");
            clonedServiceRobot.BatteryCapacity = 18.0;
            clonedServiceRobot.SoftwareVersion = "v1.1.0";
            Console.WriteLine("--- Cloned Service Robot ---");
            clonedServiceRobot.DisplayDetails();

            Console.WriteLine();

            IndustrialRobot clonedIndustrialRobot = (IndustrialRobot)registry.GetRobot("INDUSTRIAL");
            clonedIndustrialRobot.SoftwareVersion = "v2.2.0-patch";
            Console.WriteLine("--- Cloned Industrial Robot ---");
            clonedIndustrialRobot.DisplayDetails();

            Console.WriteLine();

            EntertainmentRobot clonedEntertainmentRobot = (EntertainmentRobot)registry.GetRobot("ENTERTAINMENT");
            clonedEntertainmentRobot.EntertainmentFeature = "Voice Mimicry & Singing";
            Console.WriteLine("--- Cloned Entertainment Robot ---");
            clonedEntertainmentRobot.DisplayDetails();
        }
    }
}
