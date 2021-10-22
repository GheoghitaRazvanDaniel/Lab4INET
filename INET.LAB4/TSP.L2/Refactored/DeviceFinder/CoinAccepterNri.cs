using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    class CoinAccepterNri : IDeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 19200;
            port.Parity = Parity.Odd;
            port.Handshake = Handshake.XOnXOff;
            return IDeviceFinder.Find(port);
        }
    }
}
