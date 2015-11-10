using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NATUPNPLib;
using FamilyUtilities.Types;


namespace FamilyUtilities.Networking
{
    public class Router
    {
        NATUPNPLib.UPnPNAT upnpnat;
        NATUPNPLib.IStaticPortMappingCollection mappings;

        

        public Router()
        {
            upnpnat = new NATUPNPLib.UPnPNAT();
            mappings = upnpnat.StaticPortMappingCollection;
        }

        public bool AddMapping(int iExternalPort, Protocol eProtocol, int iInternalPort, string sInternalClientIP, string sDescription)
        {
            bool bResult = false;
            IStaticPortMapping oPortMapping = null;
            oPortMapping = mappings.Add(iExternalPort, eProtocol.ToString(), iInternalPort, sInternalClientIP, true, sDescription);
            if (oPortMapping != null)
            {
                
            }
            return bResult;
        }

        public bool RemoveMapping(int iExternalPort, Protocol eProtocol)
        {
            bool bResult = false;
          
            mappings.Remove(iExternalPort, eProtocol.ToString());
         
            return bResult;
        }


        public IList<MappedPort> GetMappedPorts()
        {
            List<MappedPort> oList = new List<MappedPort>();

            foreach (NATUPNPLib.IStaticPortMapping portMapping in mappings)
            {
                oList.Add(new MappedPort(portMapping));
            }

            return oList;
        }

    }
}
