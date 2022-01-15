using System;
using System.Collections.Generic;
using System.Text;

namespace RobotRoutingApi.Contract
{
    public class LoadRequest
    {
        public string loadId { get; set; } 
        public int x { get; set; }
        public int y { get; set; }
    }
}
