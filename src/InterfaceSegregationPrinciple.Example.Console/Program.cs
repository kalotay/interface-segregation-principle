using InterfaceSegregationPrinciple.Example.Transactions.Implementations;

namespace InterfaceSegregationPrinciple.Example.Console
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var account = new Account();

			var withdrawalTransaction = new WithdrawalTransaction(account);
			withdrawalTransaction.Execute();
		}
	}
}