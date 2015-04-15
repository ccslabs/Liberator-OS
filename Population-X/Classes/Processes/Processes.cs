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

        internal void RunProcess(string pathToExecutable, bool WaitForExit)
        {
            if (RunProcessLog != null) RunProcessLog("Running Process " + pathToExecutable);
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "\"" + pathToExecutable + "\"";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            
            Process proc = new Process();
            
            proc.StartInfo = startInfo;
            proc.Exited += proc_Exited;
            proc.ErrorDataReceived += proc_ErrorDataReceived;
            proc.Start();
            
            if (WaitForExit)
            {
                proc.WaitForExit();
                int eCode = proc.ExitCode;
            }

            
        }

        void proc_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void proc_Exited(object sender, EventArgs e)
        {
           if(RunProcessCompleted != null)  RunProcessCompleted(true);
        }

        internal void RunProcess(string pathToExecutable, string Options, bool WaitForExit)
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


        internal bool KillProcess(string processName)
        {
            if (RunProcessLog != null) RunProcessLog("Killing Process " + processName);
            Process[] processlist = Process.GetProcesses();

            int idx = 0;
            foreach (Process theprocess in processlist)
            {
                if (theprocess.ProcessName.ToLowerInvariant().Contains(processName))
                {
                    
                    processlist[idx].Kill();
                    return true;
                }
                idx++;
            }

            return false;
        }
    }
}
