using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Population_X.Classes.Processes
{
    class Processes
    {
        Enumerations runProcessResults = new Enumerations();

        public delegate void RunProcessCompletedHandler(bool ReturnResult);
        public event RunProcessCompletedHandler RunProcessCompleted;
        public delegate void RunProcessLogHandler(string Message);
        public event RunProcessLogHandler RunProcessLog;

        internal bool FindProcess(string processName)
        {
            if (RunProcessLog != null) RunProcessLog("Searching for Process " + processName);
            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName.ToLowerInvariant().Contains(processName))
                {
                    return true;
                }
            }

            return false;
        }

        internal void RunProcess(string pathToExecutable)
        {
            if (RunProcessLog != null) RunProcessLog("Running Process " + pathToExecutable);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = pathToExecutable;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process proc = new Process();
            proc.WaitForExit();
            proc.StartInfo = startInfo;
            proc.Start();
            int eCode = proc.ExitCode;

            if (RunProcessCompleted != null)
            {
                RunProcessCompleted(true);
            }
            else
            {
                RunProcessCompleted(false);
            }
        }

        internal void RunProcess(string pathToExecutable, string Options)
        {
            if (RunProcessLog != null) RunProcessLog("Running Process " + pathToExecutable);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "\"" + pathToExecutable + "\""; 
                startInfo.Arguments = Options;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            
            Process proc = new Process();
            if (System.Environment.OSVersion.Version.Major >= 6)
            {
                proc.StartInfo.Verb = "runas";
            }
            proc.StartInfo = startInfo;
            
            //FIX: ClickOnce does not allow Admin Rights... May have to convert to a standard Installer
            proc.Start();
            proc.WaitForExit();


            int eCode = proc.ExitCode;

            if (RunProcessCompleted != null)
            {
                RunProcessCompleted(true);
            }
            else
            {
                RunProcessCompleted(false);
            }
        }
    }
}
