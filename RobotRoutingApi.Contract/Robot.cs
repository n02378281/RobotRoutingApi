using System;
using System.Collections.Generic;
using System.Text;

namespace RobotRoutingApi.Contract
{
    public class Robot
    {
        public string robotId { get; set; }
        public int batteryLevel { get; set; }
        public int y { get; set; }
        public int x { get; set; }
    }
    public class closestRobot
    {
        public string robotId { get; set; }
        public double distanceToGoal { get; set; }
        public int batteryLevel { get; set; }
    }
}
