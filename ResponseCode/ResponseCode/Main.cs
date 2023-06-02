using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;
using FivePD.API;
using FivePD.API.Utils;
using CitizenFX.Core.Native;

#pragma warning disable 1998
namespace ResponseCode
{
    public class Main : Plugin
    {
        internal Main() 
        {
            Events.OnCalloutAccepted += new Events.OnCalloutAcceptedDelegate(this.OnCalloutAccepted);
        }

        public async Task OnCalloutAccepted(Callout callout)
        {
            int callResponse = callout.ResponseCode;
            if (callResponse == 1) { Common.DisplayNotification($"Respond code ~w~1"); }
            if (callResponse == 2) { Common.DisplayNotification($"Respond code ~y~2"); }
            if (callResponse == 3) { Common.DisplayNotification($"Respond code ~r~3"); }
        }
    }
}
