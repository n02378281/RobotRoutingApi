using Microsoft.AspNetCore.Mvc;
using RobotRoutingApi.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace RobotRoutingApi.Controllers
{
    [ApiController]
    public class RobotsController : ControllerBase
    {
        public IRobot _robot;
        public RobotsController(IRobot robot)
        {
            _robot = robot;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<List<Robot>> Get()
        {
            var robots = await _robot.GetRobots();
            return robots;
        }


        [Route("api/[controller]/closest")]
        [HttpPost]
        public async Task<closestRobot> Post([FromBody] LoadRequest loadRequest)
        {
            var result = await _robot.GetClosestRobot(loadRequest);
            return result;
        }

    }
}
