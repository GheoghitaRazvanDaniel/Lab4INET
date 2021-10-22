namespace INET.Lab4.Refactored
{
    class DcpTerminalFactory : IBankTerminalFactory
    {
        public IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            return new DcpTerminal();
        }
    }
    public class DcpTerminal : IBankTerminal
    {
    }
}
