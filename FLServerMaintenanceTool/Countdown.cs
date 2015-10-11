using System;
using System.Collections.Generic;
using System.Threading;

namespace FLServerMaintenanceTool
{
    public static class Countdown
    {
        public static void StartCountdown()
        {
            //Quit countdown if it is disabled
            if (!Boolean.Parse(Common.IniFile.IniReadValue("countdown", "enabled")))
            {
                return;
            }

            //Load countdown items
            var countdownItems = new List<CountdownItem>();
            int items = int.Parse(Common.IniFile.IniReadValue("countdown", "count"));
            for (int i = 0; i < items; i++)
            {
                var ci = new CountdownItem();
                ci.ConsoleMessage = Common.IniFile.IniReadValue("countdown", string.Format("item{0}console", i));
                ci.UniverseMessage = Common.IniFile.IniReadValue("countdown", string.Format("item{0}universe", i));
                ci.WaitTime = int.Parse(Common.IniFile.IniReadValue("countdown", string.Format("item{0}wait", i)));
                countdownItems.Add(ci);
            }

            //Create a connection to flhook and connect it
            var flhookconnection = new FLHookConnection();
            flhookconnection.Connect();
            
            //Run Countdown
            foreach (CountdownItem ci in countdownItems)
            {
                Console.WriteLine(ci.ConsoleMessage);
                flhookconnection.SendUniverseMessage(ci.UniverseMessage);
                Wait(ci.WaitTime);
            }

            //Diconnect from FLHook
            flhookconnection.Disconnect();
        }

        private static void Wait(int mins)
        {
            int minstogo = mins;
            for (int i = 0; i < mins; i++)
            {
                Console.Write(string.Format("Waiting for {0}mins...", minstogo));
                #if DEBUG
                Thread.Sleep(1000);
                #else
                Thread.Sleep(60 * 1000);
                #endif
                minstogo--;
                Console.CursorLeft = 0;
            }
        }
    }
}