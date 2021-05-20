using System;
using System.Collections.Generic;
using System.Text;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class HandleExceptionTryCatchAwait
    {
        public static async void Execute()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Start try clause");
            Console.WriteLine("\n");
            try
            {
               await AwaitedTask.HandleExceptionTryCatchAwaitInternal();
            }
#pragma warning disable CS0168 // Variable is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // Variable is declared but never used
            {
                Console.WriteLine("Exception caught");
                Console.WriteLine("\n");
                Console.WriteLine("HandleExceptionTryCatchAwait: exception handled in try catch block");
            }
        }
    }
}
