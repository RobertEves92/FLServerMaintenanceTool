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
            //Create a connection to flhook and connect it
            FLHookConnection flhookconnection = new FLHookConnection();
            flhookconnection.Connect();

            //Send 1hr warning
            Console.WriteLine("Auto Maintainance in 1hr");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 1 hour for auto-maintenance.");
            Wait(15);

            //Send 45min warning
            Console.WriteLine("AutoMaintainance in 45mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 45 minutes for auto-maintenance.");
            Wait(15);

            //Send 30min warning
            Console.WriteLine("Auto Maintainance in 30mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 30 minutes for auto-maintenance.");
            Wait(15);

            //Send 15min warning
            Console.WriteLine("Auto Maintainance in 15mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 15 minutes for auto-maintenance.");
            Wait(5);

            //Send 10min warning
            Console.WriteLine("Auto Maintainance in 10mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 10 minutes for auto-maintenance.");
            Wait(5);

            //Send 5min warning
            Console.WriteLine("Auto Maintainance in 5mins");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 5 minutes for auto-maintenance.  It will be back up again shortly after.");
            Wait(4);

            //Send 1min warning
            Console.WriteLine("Auto Maintainance in 1min");
            flhookconnection.SendUniverseMessage("The server will be shut down in about 1 minute for auto-maintenance.  To avoid losing information in your playerfile, please log off NOW!");
            Wait(1);

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
