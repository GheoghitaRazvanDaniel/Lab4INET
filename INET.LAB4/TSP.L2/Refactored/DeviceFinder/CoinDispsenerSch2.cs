using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    class CoinDispsenerSch2 : IDeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Even;
            port.Handshake = Handshake.None;
            return IDeviceFinder.Find(port);
        }
    }
}
