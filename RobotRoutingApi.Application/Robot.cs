using Newtonsoft.Json;
using RobotRoutingApi.Contract;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RobotRoutingApi.Application
{
    public class Robot : IRobot
    {
        public async Task<List<Contract.Robot>> GetRobots()
        {
            HttpClient client = new HttpClient();
            var response = new List<Contract.Robot>();

            try
            {
                var result = await client.GetAsync("https://60c8ed887dafc90017ffbd56.mockapi.io/robots");               
                var data = await result.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<List<Contract.Robot>>(data);
            }
            finally
            {
                client.Dispose();
            }
            return response;
        }

        public async Task<closestRobot> GetClosestRobot(LoadRequest loadRequest)
        {
            var robots = await GetRobots();
            // Find closest robot from Load
            // variables to store the closest robot info
            closestRobot closestRobotInfo = new closestRobot()
            {
                robotId = "Empty",
                distanceToGoal = Double.MaxValue,
                batteryLevel = 0
            };

            // iterate over robot fleet
            for (int index = 0; index < robots.Count; index++)
            {
                var robot = robots[index];

                // distance of robot from load
                double dist = Math.Sqrt(Math.Pow((double)(loadRequest.x - robot.x), 2) +
                                        Math.Pow((double)(loadRequest.y - robot.y), 2));

                /** Check if dist is within 10 units and batter level is > then previous instance
                    Check if dist > 10 units and is closer then previous instances
                */
                if ((dist <= 10.0 && closestRobotInfo.batteryLevel < robot.batteryLevel) ||
                    (dist > 10.0 && closestRobotInfo.distanceToGoal > dist))
                {
                    closestRobotInfo.distanceToGoal = dist;
                    closestRobotInfo.robotId = robot.robotId;
                    closestRobotInfo.batteryLevel = robot.batteryLevel;
                }
            }

            return closestRobotInfo;
        }
    }
}
