using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class DepositTransaction : Transaction
	{
		private readonly Account account;

		public DepositTransaction(Account account)
		{
			this.account = account;
		}

		public override void Execute()
		{
			var screen = new Screen();

			decimal depositAmount = screen.RequestDepositAmount();

			account.Balance += depositAmount;
		}
	}
}