namespace INET.Lab4.Refactored
{
    class SingleChoice
    {
        public interface IBankTerminal
        {
        }

        public class BankTerminalFactory
        {
            public static IBankTerminal CreateBankTerminal(BrpTerminalModel model)
            {
                return new BrpTerminal();
            }
            public static IBankTerminal CreateBankTerminal(DcpTerminalModel model)
            {
                return new DcpTerminal();
            }
        }
        public class BrpTerminal : IBankTerminal
        {
        }

        public class DcpTerminal : IBankTerminal
        {
        }
    }
}
