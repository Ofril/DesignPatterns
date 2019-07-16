using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WebClientData
    {
        public string Name;
        public int ID;
        public string IP;
        public bool ssl;

        public WebClientData(string name, int iD, string iP, bool ssl)
        {
            Name = name;
            ID = iD;
            IP = iP;
            this.ssl = ssl;
        }

        public ClientData GetClientData()
        {
            return new ClientData(Name, ID);
        }

        public string ToString()
        {
            return $"name: {Name} ID: {ID} IP: {IP} ssl: {ssl}";
        }
    }
}
