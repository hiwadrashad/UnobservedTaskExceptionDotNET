using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class HandleTaskTryCatchResult
    {
        public static void execute()
        {
            try
            {
                Console.WriteLine("Starting try clause");
                Console.WriteLine("\n");
                Console.WriteLine("Start Task Factory which gives a an exception and a return type");
                Console.WriteLine("\n");
                var task = Task.Factory.StartNew(() =>
                {
                    throw new Exception("From method HandleExceptionTryCatchResult");
#pragma warning disable CS0162 // Unreachable code detected
                    return 1;
#pragma warning restore CS0162 // Unreachable code detected
                });
                Console.WriteLine("return result of task");
                Console.WriteLine("\n");
                var result = task.Result;
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("starting catch clause");
                Console.WriteLine("\n");
                Console.WriteLine("HandleExceptionTryCatchResult: exception handled in try catch block");
                Console.WriteLine("\n");
                Console.WriteLine("Exception gets called because returning result from a task");
                Console.WriteLine("propogates exceptions to the caller");
            }
        }
    }
}
