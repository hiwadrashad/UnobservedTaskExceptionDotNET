using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class HandleExceptionContinueWith
    {
        public static void execute()
        {
           Console.WriteLine("Starting task in which an exception is thrown");
           Console.WriteLine("\n");
           Console.WriteLine("ContinueWith executes method when task is done, in which the val property is used inside");
           Console.WriteLine("the lambda expression, which translates to an aggregate exception");
           Console.WriteLine("in which all innerexceptions are written down below:");
           Console.WriteLine("\n");
           Task.Factory.StartNew(() => { throw new Exception("From method HandleExceptionContinueWith"); })
           .ContinueWith(val =>
           {
             foreach (var ex in val.Exception.Flatten().InnerExceptions)
             {
               Console.WriteLine("HandleExceptionContinueWith: exception handled in ContinueWith.");
             }
           }, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
