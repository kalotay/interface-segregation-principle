using System;

namespace InterfaceSegregationPrinciple.Example.Views.Implementations
{
	public class Speech : IAutomatedTellerMachine
	{
		#region IAutomatedTellerMachine Members

		public decimal RequestDepositAmount()
		{
			throw new NotImplementedException();
		}

		public decimal RequestWithdrawalAmount()
		{
			throw new NotImplementedException();
		}

		public decimal RequestTransferAmount()
		{
			throw new NotImplementedException();
		}

		public void InformInsufficientFunds()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}