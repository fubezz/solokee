using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using HidLibrary;
using Newtonsoft.Json.Linq;

namespace CTAP
{
    class CTAPClient
    {
        //self.origin = "https://example.org"
        //self.host = "example.org"
        //self.user_id = b"they"
        //self.exchange = self.exchange_hid
        //self.do_reboot = True
        private string Origin = "SoloKee Keypass Plugin";
        private static HidDevice soloKey = null;

        private enum CMD
        {
             TYPE_INIT = 0x80,
             PING= 0x01,
             MSG= 0x03,
             LOCK = 0x04,
             INIT = 0x06,
             WINK = 0x08,
             CBOR = 0x10,
             CANCEL = 0x11,
             ERROR = 0x3F,
             KEEPALIVE = 0x3B,
             VENDOR_FIRST = 0x4
        }
       


        //private void call(int cmd, byte[] data)
        //{
        //    int finalCMD = ((int)CMD.TYPE_INIT) | cmd;

        //    int msgLength = data.Length;

        //    maxPacketSize = SoloKey.

        //    //max_payload = self.packet_size - 7
        //    //first_frame = payload[0:max_payload]
        //    //first_packet = UsbHidTransport.InitPacket(self.packet_size, self.cid, cmd,
        //    //                                          len(payload), first_frame)
        //    //del payload[0:max_payload]
        //    //length_to_send -= len(first_frame)
        //    //self.InternalSendPacket(first_packet)

        //    //seq = 0
        //    //while length_to_send > 0:
        //    //  max_payload = self.packet_size - 5
        //    //  next_frame = payload[0:max_payload]
        //    //  del payload[0:max_payload]
        //    //  length_to_send -= len(next_frame)
        //    //  next_packet = UsbHidTransport.ContPacket(self.packet_size, self.cid, seq,
        //    //                                           next_frame)
        //    //  self.InternalSendPacket(next_packet)
        //    //  seq += 1


        ////    def call(self, cmd, data= b"", event=None, on_keepalive=None):
        ////event = event or Event()
        ////self._dev.InternalSend(TYPE_INIT | cmd, bytearray(data))
        ////last_ka = None
        ////while not event.is_set():
        ////    status, resp = self._dev.InternalRecv()
        ////    status ^= TYPE_INIT
        ////    if status == cmd:
        ////        return bytes(resp)
        ////    elif status == CTAPHID.ERROR:
        ////        raise CtapError(resp[0])
        ////    elif status == CTAPHID.KEEPALIVE:
        ////        ka_status = resp[0]
        ////        if on_keepalive and last_ka != ka_status:
        ////            try:
        ////                ka_status = STATUS(ka_status)
        ////            except ValueError:
        ////                pass  # Unknown status value
        ////            last_ka = ka_status
        ////            on_keepalive(ka_status)
        ////        continue
        ////    else:
        ////        raise CtapError(CtapError.ERR.INVALID_COMMAND)

        //    //# Cancel the request.
        //    //self._dev.InternalSend(TYPE_INIT | CTAPHID.CANCEL, bytearray())
        //    //self._dev.InternalRecv()
        //    //raise CtapError(CtapError.ERR.KEEPALIVE_CANCEL)
        //}

        private static void OnReadReport(HidReport report)
        {
            if (!soloKey.IsConnected) {
                Console.WriteLine("Solokey not connected");
                return;
            }

            Console.WriteLine(Encoding.ASCII.GetString(report.Data));
            soloKey.ReadReport(OnReadReport);
        }


        public void FindSoloKey(string dev, string solo_serial)
        {
            //Defined IDs of Solo Key
            int VendorId = 1155;
            int ProductId = 41674;
         
            HidDevice _device = HidDevices.Enumerate(VendorId, ProductId).FirstOrDefault();

            if (_device != null)
            {
                soloKey = _device;
                soloKey.OpenDevice();
                Console.WriteLine("Found Solokey");
                soloKey.ReadReport(OnReadReport);
                soloKey.CloseDevice();
                
            }
            else
            {
                Console.WriteLine("Could not find Found Solokey.");
            }   
        }

    }
}
