using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class TransferTransaction : Transaction
	{
		private readonly Account account;

		public TransferTransaction(Account account)
		{
			this.account = account;
		}

		public override void Execute()
		{
			var screen = new Screen();

			decimal transferAmount = screen.RequestTransferAmount();

			if (account.Balance - transferAmount < 0)
				screen.InformInsufficientFunds();
			else
				account.Balance -= transferAmount;
		}
	}
}