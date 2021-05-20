using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class HandleTaskTryCatchWait
    {
        public static void execute()
        {
            try
            {
                Console.WriteLine("Starting try clause");
                Console.WriteLine("\n");
                Console.WriteLine("Start Task Factory which gives a an exception without a return type");
                Console.WriteLine("\n");
                var task = Task.Factory.StartNew(() =>
                {
                    throw new Exception("From method HandleExceptionTryCatchAwait");
                });
                Console.WriteLine("return result of task");
                Console.WriteLine("\n");
                task.Wait();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("starting catch clause");
                Console.WriteLine("\n");
                Console.WriteLine("HandleExceptionTryCatchAwait: exception handled in try catch block");
                Console.WriteLine("\n");
                Console.WriteLine("Exception gets called because awaiting a task");
                Console.WriteLine("propogates exceptions to the caller");
            }
        }
    }
}
