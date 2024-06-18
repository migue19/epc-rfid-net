using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epc_rfid_net.Model.Repository
{
    internal interface ConnectRepository
    {
        void Connect(String ipReader);
    }
}
