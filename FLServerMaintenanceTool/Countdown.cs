using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FLServerMaintenanceTool
{
    public static class Countdown
    {
        public static void StartCountdown()
        {
            //Load countdown items
            List<CountdownItem> countdownItems = new List<CountdownItem>();
            int items = int.Parse(Common.IniFile.IniReadValue("countdown", "count"));
            for (int i = 0; i < items; i++)
            {
                CountdownItem ci = new CountdownItem();
                ci.ConsoleMessage = Common.IniFile.IniReadValue("countdown", "item" + i + "console");
                ci.UniverseMessage = Common.IniFile.IniReadValue("countdown", "item" + i + "universe");
                ci.WaitTime = int.Parse(Common.IniFile.IniReadValue("countdown", "item" + i + "wait"));
                countdownItems.Add(ci);
            }

            //Create a connection to flhook and connect it
            FLHookConnection flhookconnection = new FLHookConnection();
            flhookconnection.Connect();
            
            //Run Countdown
            foreach (CountdownItem ci in countdownItems)
            {
                Console.WriteLine(ci.ConsoleMessage);
                flhookconnection.SendUniverseMessage(ci.UniverseMessage);
                Wait(ci.WaitTime);
            }

            //Send shutdown warning
            Console.WriteLine("Auto Maintainance Started");

            //Diconnect from FLHook
            flhookconnection.Disconnect();
        }

        private static void Wait(int mins)
        {
            int minstogo = mins;
            for (int i = 0; i < mins; i++)
            {
                Console.Write("Waiting for " + minstogo + "mins...");
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
