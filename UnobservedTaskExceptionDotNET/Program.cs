using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnobservedTaskExceptionDotNET.Methods;

namespace UnobservedTaskExceptionDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Faulty task catching ======================");
            Console.WriteLine("\n");
            FaultyTryCatchTask.Execute();
            Console.WriteLine("\n");
            Console.WriteLine("====================== Handle task catch trough result method ======================");
            Console.WriteLine("\n");
            HandleTaskTryCatchResult.execute();
            Console.WriteLine("\n");
            Console.WriteLine("====================== Handle task catch trough wait method ======================");
            Console.WriteLine("\n");
            HandleTaskTryCatchWait.execute();
            Console.WriteLine("\n");
            Console.WriteLine("Problem with await and result methods is that this will lead to blocking calls");
            Console.WriteLine("it is possible to bypass this problem with the following methods");
            Console.WriteLine("the following methods are for .NET versions below 4.5");
            Console.WriteLine("\n");
            Console.WriteLine("====================== Handle task catch without blocking trough continuewith method ======================");
            Console.WriteLine("\n");
            HandleExceptionContinueWith.execute();
            Console.WriteLine("\n");
            Console.WriteLine("====================== Handle task catch without blocking trough continuewith and handle ======================");
            Console.WriteLine("\n");
            HandleExceptionContinueWithAndHandleMethod.execute();
            Console.WriteLine("\n");
            Console.WriteLine("The next method is a simpler execution of the above which is possible in .NET 4.5 and above");
            Console.WriteLine("\n");
            HandleExceptionTryCatchAwait.Execute();
            Console.WriteLine("\n");
            Console.WriteLine("====================== UnobservedTaskException ======================");
            Console.WriteLine("\n");
            Console.WriteLine("sometimes an error is thrown which is not being handled which will");
            Console.WriteLine("throw an unobserved exception");
            Console.WriteLine("this will happen when you execute the garbagecollector at the right time");
            Console.WriteLine("The finalizer will throw the UnobservedTaskException");
            Console.WriteLine("\n");
            Console.WriteLine("the UnobservedTaskException will be thrown specifically in versions .NET 4.5 and later");
            Console.WriteLine("on one merrit, if the App.Config has the next line added");
            Console.WriteLine("<runtime>");
            Console.WriteLine(@"  <ThrowUnobservedTaskExceptions enabled='true'/>");
            Console.WriteLine("<runtime>");
            Console.WriteLine("\n");
            UnobservedTaskExceptionExecution.execute();
            Console.WriteLine("\n");
            Console.WriteLine("====================== UnobservedTaskException Older version ======================");
            Console.WriteLine("\n");
            Console.WriteLine("Problems will arise if you make use of .NET versions 4.0 and earlier");
            Console.WriteLine("Escalation policies are stricter in this version");
            Console.WriteLine("In which independant of the app.settings the UnobservedException will fail silently");
            Console.WriteLine("\n");
            Console.WriteLine("This can be bypassed trough making use of the TaskScheduler.UnobservedTaskException which will be shown below");
            Console.WriteLine("\n");
            TaskSchedulerUnobservedTaskException.execute();
            Console.WriteLine("\n");
            Console.WriteLine("No exception will be thrown as this is .NET version 5> to enable this i should change the app.config");
            Console.WriteLine("\n");

        }
    }
}
