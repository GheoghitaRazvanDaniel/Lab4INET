namespace INET.Lab4.Refactored
{
    class BrpTerminalFactory : IBankTerminalFactory
    {
        public IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            return new BrpTerminal();
        }
    }
    public class BrpTerminal : IBankTerminal
    {
    }
}
