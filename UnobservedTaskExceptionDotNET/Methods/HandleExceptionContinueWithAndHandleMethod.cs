using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class HandleExceptionContinueWithAndHandleMethod
    {
        public static void execute()
        {
            Console.WriteLine("Starting task factory in which an exception is thrown");
            Console.WriteLine("\n");
            Console.WriteLine("ContinueWith is applied again, in which the val parameter inside the lambda expression");
            Console.WriteLine("is applied as an aggregatexception");
            Console.WriteLine("\n");
            Console.WriteLine("lambda expression is used again with the given parameter which is the handle of the aggregatexception");
            Console.WriteLine("\n");
            Task.Factory.StartNew(() => { throw new Exception("From method HandleExceptionContinueWith"); })
            .ContinueWith(val =>
            {
               val.Exception.Handle(ex =>
               {
               Console.WriteLine("HandleExceptionContinueWith: exception handled in AggregateException.Handle.");
               return true;
               });
            }, TaskContinuationOptions.OnlyOnFaulted);
        }
    }
}
