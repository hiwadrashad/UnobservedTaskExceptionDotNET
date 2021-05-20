using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class UnobservedTaskExceptionExecution
    {
        public static void execute()
        {
            Task.Factory.StartNew(() => { throw new Exception("fire-and-forget no exception handling"); });
            using (var autoresetEvent = new AutoResetEvent(false))
            {
                //wait for task to run
                autoresetEvent.WaitOne(TimeSpan.FromSeconds(2));
            }

            Console.WriteLine("GC: Collecting");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("GC: Collected");
        }
    }
}
