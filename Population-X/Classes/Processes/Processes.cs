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

        internal bool FindProcess(string processName)
        {
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

            if (RunProcessCompleted != null) RunProcessCompleted(true);
        }

        internal void RunProcess(string pathToExecutable, string Options)
        {

            if (RunProcessCompleted != null) RunProcessCompleted(true);
        }
    }
}
