using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class ThrowError
    {
        public void Test()
        {
            Console.WriteLine("Throw task which throws an exception");
            Console.WriteLine("\n");
            Task t = new Task(() =>
            {
                throw new Exception();
            }); t.Start();
        }
    }
    public class TaskSchedulerUnobservedTaskException
    {
        public static void execute()
        {
            Console.WriteLine("Generate TaskScheduler.UnobservedTaskException");
            TaskScheduler.UnobservedTaskException += new EventHandler<UnobservedTaskExceptionEventArgs>
                (TaskScheduler_UnobservedTaskException);
            ThrowError errorobject = new ThrowError();
            Console.WriteLine("\n");
            Console.WriteLine("Execute throwing error");
            Console.WriteLine("\n");
            errorobject.Test();
            Console.WriteLine("Garbage collector started");
            Console.WriteLine("\n");
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
        {
            Console.WriteLine("Error.");
            Console.WriteLine("\n");
            Console.WriteLine("Set observed");
            e.SetObserved();
        }
    }
}
