namespace InterfaceSegregationPrinciple.Example
{
	public class Account
	{
		public decimal Balance { get; set; }

	    public bool HasSufficientFundsForWithdrawal(decimal transferAmount)
	    {
	        return transferAmount - Balance >= 0;
	    }

        public void Withdraw(decimal transferAmount)
        {
            if (HasSufficientFundsForWithdrawal(transferAmount)) Balance -= transferAmount;
        }
	}
}