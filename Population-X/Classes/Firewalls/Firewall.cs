using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Management;
using NATUPNPLib;
using NETCONLib;
using NetFwTypeLib;


namespace Population_X.Classes.Firewalls
{
    class Firewall 
    {
        private const string CLSID_FIREWALL_MANAGER = "{304CE942-6E39-40D8-943A-B913C40C9CD4}";
        private static NetFwTypeLib.INetFwMgr GetFirewallManager()
        {
            Type objectType = Type.GetTypeFromCLSID(
                  new Guid(CLSID_FIREWALL_MANAGER));
            return Activator.CreateInstance(objectType)
                  as NetFwTypeLib.INetFwMgr;
        }

        internal bool FirewallEnabled()
        {
            INetFwMgr manager = GetFirewallManager();
            bool res = manager.LocalPolicy.CurrentProfile.FirewallEnabled;
            Properties.Settings.Default.FirewallRunning = res;
            return res;
        }
    }
}
