namespace InterfaceSegregationPrinciple.Example.Views
{
    public interface ICashMachine : IInsufficientFundsInformer
    {
        decimal RequestWithdrawalAmount();
    }
}