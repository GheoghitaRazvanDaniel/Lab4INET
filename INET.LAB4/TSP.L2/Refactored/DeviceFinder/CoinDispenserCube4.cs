using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    class CoinDispenserCube4 : IDeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 9600;
            port.Parity = Parity.Space;
            port.Handshake = Handshake.None;
            return IDeviceFinder.Find(port);
        }
    }
}
