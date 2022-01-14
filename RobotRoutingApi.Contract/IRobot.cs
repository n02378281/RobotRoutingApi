using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RobotRoutingApi.Contract
{
    public interface IRobot
    {
        public  Task<List<Robot>> GetRobots();
        public Task<closestRobot> GetClosestRobot(LoadRequest loadRequest);
    }
}
