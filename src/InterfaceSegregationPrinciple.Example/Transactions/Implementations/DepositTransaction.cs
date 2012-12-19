using InterfaceSegregationPrinciple.Example.Views;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class DepositTransaction : ITransaction
	{
		private readonly Account account;
	    private readonly IDepositMachine _depositMachine;

		public DepositTransaction(Account account, IDepositMachine _depositMachine)
		{
			this.account = account;
		    this._depositMachine = _depositMachine;
		}

		public virtual void Execute()
		{
			decimal depositAmount = _depositMachine.RequestDepositAmount();

			account.Balance += depositAmount;
		}
	}
}