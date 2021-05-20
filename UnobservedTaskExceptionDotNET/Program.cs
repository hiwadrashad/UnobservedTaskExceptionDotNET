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
            Console.WriteLine("====================== Handle task catch trough await method ======================");
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
            Console.WriteLine("test");
            UnobservedTaskExceptionExecution.execute();
        }
    }
}
