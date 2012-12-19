using InterfaceSegregationPrinciple.Example.Views;
using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class WithdrawalTransaction : ITransaction
	{
		private readonly Account account;
	    private readonly ICashMachine _cashMachine;

	    public WithdrawalTransaction(Account account, ICashMachine cashMachine)
		{
		    this.account = account;
		    _cashMachine = cashMachine;
		}

	    public virtual void Execute()
		{

			decimal withdrawalAmount = _cashMachine.RequestWithdrawalAmount();

	        if (account.HasSufficientFundsForWithdrawal(withdrawalAmount))
	            account.Balance -= withdrawalAmount;
	        else
	            _cashMachine.InformInsufficientFunds();

		}
	}
}