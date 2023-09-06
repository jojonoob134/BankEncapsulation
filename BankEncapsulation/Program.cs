namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            bool isInATM = false;
            while (!isInATM)
            {
                Console.WriteLine("press 1 to see your balence, press 2 to deposet some money, press 3 to Withdrawal some money, press 4 to leave");
                int chose = int.Parse(Console.ReadLine());
                if (chose == 1)
                {
                    Console.WriteLine($"You have {account.GetBalance()} in your bank account");
                }
                if (chose == 2)
                {
                    Console.WriteLine("how much money do you want to depost");
                    double addingNum = double.Parse(Console.ReadLine());
                    account.Deposet(addingNum);
                }
                if (chose == 3)
                {
                    Console.WriteLine("how much money do you want to depost");
                    double subtractNum = double.Parse(Console.ReadLine());
                    account.Deposet(subtractNum);
                }
                if (chose == 4)
                {
                    isInATM = true;
                }
            }
        }
    }
}
