using System;

namespace lab02_unit_testing
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("*********Hello!**** Welcome to Piggy Bank!******");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");
            Console.WriteLine("************************************************");

          //declare a boolean to run the program
            bool run = true;
            //declare balance for original amount exsits in my account
            Decimal myBalance = 5000;

            //starts
            while (run)
            {
                Console.WriteLine("Press a number:");
                Console.WriteLine("1:Deposit");
                Console.WriteLine("2:Withdraw");
                Console.WriteLine("3:View balance");
                Console.WriteLine("4:Exit");
                try
                {

                    string input = Console.ReadLine();
                    //int caseNumber = Int32.Parse(input);

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("How much money you want to deposit?");
                            Console.Write("$");
                            String input1 = Console.ReadLine();
                            Decimal money = Decimal.Parse(input1);
                            //call DoDeposit method here and return a new balance from that method 
                            Decimal newBalance = DoDeposit(myBalance, money);
                            //update the original balance
                            myBalance = newBalance;
                            //let users choose to continue or exit
                            Console.WriteLine("1.continue 2.Exit");
                            string input2 = Console.ReadLine();
                            int ans = Int32.Parse(input2);
                            //if continue run is true do the while loop
                            if (ans == 1)
                            {
                                run = true;
                                break;
                            }
                            else goto case "4";


                        case "2":
                            Console.WriteLine("How much money you want to withdraw?");
                            Console.Write("$");
                            String input3 = Console.ReadLine();
                            Decimal money2 = Decimal.Parse(input3);
                            //call the DoWithdraw method here and return a new balance
                            Decimal newBalance2 = DoWithdraw(myBalance, money2);
                            //update the bank balance
                            myBalance = newBalance2;
                            Console.WriteLine("1.continue 2.Exit");
                            string input4 = Console.ReadLine();
                            int ans2 = Int32.Parse(input4);
                            if (ans2 == 1)
                            {
                                run = true;
                                break;
                            }
                            else goto case "4";



                        case "3":
                            Console.WriteLine($"Your current balance is ${myBalance}");
                            Console.WriteLine("1.continue 2.Exit");
                            string input5 = Console.ReadLine();
                            int ans3 = Int32.Parse(input5);
                            if (ans3 == 1)
                            {
                                run = true;
                                break;
                            }
                            else goto case "4";

                       

                        case "4":
                            Console.WriteLine();
                            Console.WriteLine("Thank you ! See you next time!");

                            Environment.Exit(0);
                            break;

                            //if users  not choose 1,2,3,4 it will run this
                        default:
                            throw new Exception("please choose one from here");

                    }
                }

                //catch errors happen in the try block,display a message
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }




        public static Decimal DoDeposit(Decimal myBalance,Decimal money)
        {
           //you cannot deposit negative amount of money
            if (money == 0 || money < 0)
            {
                Console.WriteLine("invalide number!");
            }
            else
            {   
                myBalance = myBalance + money;
               
            }
            return myBalance;

        }


        public static Decimal DoWithdraw(Decimal myBalance,Decimal money)
        {
            //you cannot take away more than the amount of your account
            if (money < 0 || money > myBalance)
            {
                Console.WriteLine("Invalid Number! Can't continue this transaction.");
            }
            else
            {
                myBalance = myBalance - money;
            }
            return myBalance;
        }

    }
}
