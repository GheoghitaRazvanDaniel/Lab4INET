namespace INET.Lab4.Refactored
{
    public enum BankTerminalModel
    {
        Brp,
        Dcp
    }
    public interface IBankTerminal
    {
    }
    interface IBankTerminalFactory
    {
        public abstract IBankTerminal CreateBankTerminal(BankTerminalModel model);
    }
}
