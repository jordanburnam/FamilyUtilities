using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyUtilities.Types
{
    public class MappedPort
    {
        int _iExternalPort;
        int _iInternalPort;
        Protocol _eProtocol;
        string _sInternalIP;
        string _sDescription;
        bool _bEnabled;


        public int ExternalPort {
            get { return this._iExternalPort; }    
        }

        public int InternalPort
        {
            get { return this._iInternalPort; }
        }

        public string Protocol
        {
            get { return this._eProtocol.ToString(); }
        }

        public string Description
        {
            get { return this._sDescription; }
        }

        public bool Enabled
        {
            get { return this._bEnabled; }
        }

        public MappedPort(NATUPNPLib.IStaticPortMapping oPortMapping)
        {
             _eProtocol = (Protocol)Enum.Parse(typeof(Protocol), oPortMapping.Protocol);
            _iExternalPort = oPortMapping.ExternalPort;
            _iInternalPort = oPortMapping.InternalPort;
            _sInternalIP = oPortMapping.InternalClient;
          
            _sDescription = oPortMapping.Description;
            _bEnabled = oPortMapping.Enabled;
        }
        public MappedPort(string sInternalIP, int iExternalPort, int iInternalPort, Protocol eProtocol, string sDescription, bool bEnabled)
        {
            _iExternalPort = iExternalPort;
            _iInternalPort = iInternalPort;
            _sInternalIP = sInternalIP;
            _eProtocol = eProtocol;
            _sDescription = sDescription;
            _bEnabled = bEnabled;
        }

        public override string ToString()
        {
            string sString = "";
            sString = this._sDescription;

            return sString;
        }
    }
}
