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

        public VPNs()
        {
            
        }

        public void CheckForOpenVPN()
        {
            Task t = new Task(() => OpenVPNCheck());
            t.Start();
        }

        private void OpenVPNCheck()
        {
            bool result = false;
            Processes.Processes procs = new Processes.Processes();
           result = procs.FindProcess("OpenVPNService");
            if(!result)
            {
             Services.Services Servs = new Services.Services();
             result = Servs.FindService("OpenVPNService");
            }
            Properties.Settings.Default.NetworkVPNRunning = result;
           if(VPNStatusCheck != null) VPNStatusCheck(result);
            Properties.Settings.Default.Save();
        }

    }
}
