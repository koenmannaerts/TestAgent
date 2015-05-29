using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRunner
{
    public class Program
    {
        static void Main(string[] args)
        {
            var testOutput = string.Empty;

            try
            {
                var exePath = @"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe";
                var processRunner = new ProcessRunner();
                testOutput = processRunner.RunProcess(exePath, @"D:\srconline\APT\ASK\src\SupportTool.CodeUITest\bin\Debug\SupportTool.CodedUITest.dll");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Log error.
            }

            Console.WriteLine(testOutput);
        }
    }
}

