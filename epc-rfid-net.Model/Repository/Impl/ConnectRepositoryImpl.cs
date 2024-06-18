using CSLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epc_rfid_net.Model.Repository.Impl
{
    public class ConnectRepositoryImpl : ConnectRepository
    {
        public static List<HighLevelInterface> ReaderList = new List<HighLevelInterface>();

        public void Connect(string ipReader)
        {
            List<HighLevelInterface> ReaderList = new List<HighLevelInterface>();

            ReaderList.Add(new HighLevelInterface());
        //CSLibrary.Constants.Result ret;
        //HighLevelInterface Reader = new HighLevelInterface();
        //Console.WriteLine(String.Format("Start to connect reader,  IP <" + ipReader + ">"));
        //if ((ret = Reader.Connect(ipReader, 30000)) != CSLibrary.Constants.Result.OK)
        //{
        //    Reader.Disconnect();
        //}
        //else
        //{
        //    Console.WriteLine(String.Format("Reader connect success,  IP <" + ipReader + ">"));
        //    Reader.OnStateChanged += new EventHandler<CSLibrary.Events.OnStateChangedEventArgs>(ReaderXP_StateChangedEvent);
        //    Reader.OnAsyncCallback += new EventHandler<CSLibrary.Events.OnAsyncCallbackEventArgs>(ReaderXP_TagInventoryEvent);

        //                ReaderList.Add(Reader);
        //            }
        //throw new NotImplementedException();
        }
    }
}

