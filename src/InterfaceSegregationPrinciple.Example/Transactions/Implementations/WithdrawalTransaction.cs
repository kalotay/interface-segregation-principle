using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Transactions.Implementations
{
	public class WithdrawalTransaction : Transaction
	{
		private readonly Account account;

		public WithdrawalTransaction(Account account)
		{
			this.account = account;
		}

		public override void Execute()
		{
			var screen = new Screen();

			decimal withdrawalAmount = screen.RequestWithdrawalAmount();

			if (account.Balance - withdrawalAmount < 0)
				screen.InformInsufficientFunds();
			else
				account.Balance -= withdrawalAmount;
		}
	}
}