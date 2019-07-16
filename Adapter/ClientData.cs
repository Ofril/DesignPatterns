using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientData
    {
        public string Name;
        public int ID;

        public ClientData(string name, int id)
        {
            Name = name;
            ID = id;
        }

        public string ToString()
        {
            return $"name: {Name} ID: {ID}";
        }
    }
}
