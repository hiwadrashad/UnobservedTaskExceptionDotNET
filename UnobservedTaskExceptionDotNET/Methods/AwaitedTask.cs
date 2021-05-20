using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
   
    public class AwaitedTask
    {
        public static async Task<int> HandleExceptionTryCatchAwaitInternal()
        {
            Console.WriteLine("Awaiting simple Task which throws an excpetion with a given parameter");
            return await Task.Factory.StartNew(() =>
            {
                throw new Exception();
#pragma warning disable CS0162 // Unreachable code detected
                return 1;
#pragma warning restore CS0162 // Unreachable code detected
            }, TaskCreationOptions.LongRunning);
        }
    }
}
