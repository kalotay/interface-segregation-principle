namespace InterfaceSegregationPrinciple.Example.Views
{
	public interface IAutomatedTellerMachine
	{
		decimal RequestDepositAmount();

		decimal RequestWithdrawalAmount();

		decimal RequestTransferAmount();

		void InformInsufficientFunds();
	}
}