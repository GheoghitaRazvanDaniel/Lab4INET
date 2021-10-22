using System.IO.Ports;

namespace INET.Lab4.Refactored.DeviceFinder
{
    class BillDispenserEcdm : IDeviceFinder
    {
        public string FindDevice(DeviceModel model)
        {
            SerialPort port = new SerialPort();
            port.BaudRate = 4800;
            port.Parity = Parity.Mark;
            port.Handshake = Handshake.RequestToSendXOnXOff;
            return IDeviceFinder.Find(port);
        }
    }
}
