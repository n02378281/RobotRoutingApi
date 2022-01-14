using System;
using System.Collections.Generic;
using System.Text;

namespace RobotRoutingApi.Contract
{
    public class LoadRequest
    {
        public string loadId { get; set; } = "Empty";
        public int x { get; set; }
        public int y { get; set; }
    }
}
