using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidSharp;

namespace HIDInterfaceAPP
{
    class HID
    {
        public string Gethid()
        {

                try
                {
                    var loader = new HidDeviceLoader();
                    var device = loader.GetDevices(0X0EB8,0XF000).First();
                    HidStream stream;
                    device.TryOpen(out stream);
                string sendme = "<STX>'W'<ETX>";
                System.Text.Encoding enc = System.Text.Encoding.ASCII;
                byte[] messagebyte = enc.GetBytes(sendme);
                stream.Write(messagebyte);
                byte[] fromscale = stream.Read();
                string returnedmessage = enc.GetString(fromscale);
                return returnedmessage;
            }
                catch (Exception e)
                {
                    return "false";
                }
        }
    }
}
