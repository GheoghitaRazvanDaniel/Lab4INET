using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    class BillAccepterCashCode : IDeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.RequestToSend;
            return IDeviceFinder.Find(port);
        }
    }
}
