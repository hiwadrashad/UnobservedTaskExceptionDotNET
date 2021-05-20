using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDotNET.Methods
{
    public class FaultyTryCatchTask
    {
        public static void Execute()
        {
            try
            {
                Console.WriteLine("starting try block");
                Console.WriteLine("\n");
                Console.WriteLine("Generating Task Factory which throws an error");
                Console.WriteLine("\n");
                Task.Factory.StartNew(() => { throw new Exception("From Task factory throwing general exception"); });
                Console.WriteLine("As you can see when the Task throws the error it is not being catched");
                Console.WriteLine("This comes as Tasks can not be catched inside a try catch block");
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Start catch clause");
                Console.WriteLine("\n");
                Console.WriteLine("Catch exception and write it down");
                Console.WriteLine("\n");
                Console.WriteLine("Exception handled {0}", ex);
            }
        }
    }
}
