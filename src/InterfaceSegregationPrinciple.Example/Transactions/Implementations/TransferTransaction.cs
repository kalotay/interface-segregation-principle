using InterfaceSegregationPrinciple.Example.Views;
using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class TransferTransaction : ITransaction
	{
		private readonly Account account;
	    private readonly ITransferMachine _transferMachine;

	    public TransferTransaction(Account account, ITransferMachine transferMachine)
		{
		    this.account = account;
		    _transferMachine = transferMachine;
		}

	    public virtual void Execute()
	    {
	        decimal transferAmount = _transferMachine.RequestTransferAmount();

	        if (account.HasSufficientFundsForWithdrawal(transferAmount))
	            account.Withdraw(transferAmount);
	        else
	            _transferMachine.InformInsufficientFunds();
	    }
	}
}