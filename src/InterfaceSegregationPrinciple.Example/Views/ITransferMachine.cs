namespace InterfaceSegregationPrinciple.Example.Views
{
    public interface ITransferMachine : IInsufficientFundsInformer
    {
        decimal RequestTransferAmount();
    }
}