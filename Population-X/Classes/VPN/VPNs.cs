using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population_X.Classes.VPN
{
    class VPNs
    {

        public delegate void VPNStatusCheckHandler(bool result);
        public event VPNStatusCheckHandler VPNStatusCheck;
        public delegate void VPNLogHandler(string Message);
        public event VPNLogHandler VPNLog;

        public VPNs()
        {

        }

        public void CheckForOpenVPN()
        {
            if (VPNLog != null) VPNLog("Checking for Open VPN");
            Task t = new Task(() => OpenVPNCheck());
            t.Start();
        }

        private void OpenVPNCheck()
        {
            bool result = false;
            Processes.Processes procs = new Processes.Processes();
            result = procs.FindProcess("OpenVPNService");
           
            if (!result)
            {
                if (VPNLog != null) VPNLog("VPN Not Running");
                Services.Services Servs = new Services.Services();
                result = Servs.FindService("OpenVPNService");
            }

            if (VPNLog != null) VPNLog("VPN Result = " + result);
            Properties.Settings.Default.NetworkVPNRunning = result;
            if (VPNStatusCheck != null) VPNStatusCheck(result);
            Properties.Settings.Default.Save();
        }

    }
}
