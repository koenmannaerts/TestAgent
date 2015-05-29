using System.Diagnostics;

namespace TestRunner
{
    public class ProcessRunner : IRunAProcess
    {
        public string RunProcess(string exePath, string arguments)
        {
            var startInfo = SetupProcessStartInfo(exePath, arguments);

            string processOutput = string.Empty;
            
            using (Process exeProcess = Process.Start((ProcessStartInfo) startInfo))
            {
                exeProcess.WaitForExit();
                processOutput = exeProcess.StandardOutput.ReadToEnd();
            }

            return processOutput;
        }

        private static ProcessStartInfo SetupProcessStartInfo(string exePath, string arguments)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = exePath;
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = arguments;
            startInfo.RedirectStandardOutput = true;
            return startInfo;
        }
    }
}