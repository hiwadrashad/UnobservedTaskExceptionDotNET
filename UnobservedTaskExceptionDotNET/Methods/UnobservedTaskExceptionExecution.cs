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
            Console.WriteLine("Start task with given exception");
            Console.WriteLine("\n");
            Task.Factory.StartNew(() => { throw new Exception("fire-and-forget no exception handling"); });
            Console.WriteLine("\n");
            Console.WriteLine("Garbage collector starting in which the UnobservedTaskException will be thrown");
            Console.WriteLine("\n");
            Console.WriteLine("GC: Collecting");
            Console.WriteLine("\n");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("GC: Collected");
            Console.WriteLine("\n");
            Console.WriteLine("UnobservedTaskException Error would be shown if app.settings was set right");
            Console.WriteLine("It will fail silently now");

        }
    }
}
