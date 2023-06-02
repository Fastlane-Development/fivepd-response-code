using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CitizenFX.Core.Native.API;

namespace ResponseCode
{
    internal static class Common
    {
        internal static void DisplayNotification(string text)
        {
            BeginTextCommandThefeedPost("STRING");
            AddTextComponentString(text);
            EndTextCommandThefeedPostTicker(true, true);
        }
    }
}
