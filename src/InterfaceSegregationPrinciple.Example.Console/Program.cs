using InterfaceSegregationPrinciple.Example.Transactions.Implementations;
using InterfaceSegregationPrinciple.Example.Views.Implementations;

namespace InterfaceSegregationPrinciple.Example.Console
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var account = new Account();
		    var cashMachine = new Screen();

		    var withdrawalTransaction = new WithdrawalTransaction(account, cashMachine);
			withdrawalTransaction.Execute();
		}
	}
}