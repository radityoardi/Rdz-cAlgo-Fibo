using System;
using System.Linq;
using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;
using Rdz.cAlgo.Library;

namespace Rdz.cAlgo.Fibo
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public partial class FibocBot : RdzRobot
    {
        [Parameter(DefaultValue = 0.0)]
        public double Parameter { get; set; }

        protected override void OnStart()
        {
            // Put your initialization logic here
        }

        protected override void OnTick()
        {
            // Put your core logic here
        }

        protected override void OnStop()
        {
            // Put your deinitialization logic here
        }
    }
}
