using System;

namespace BankingAPPConsole_GeromeAzemar
{
    class Program
    {
       static public String menu = ("Please select one of the following options\n\n1. Create New Account\n2. Check Balance\n3. Withdrawal");
            static public bool active = false;
        static void Main(string[] args)
        { 
            Accounts accObj = new Accounts();
            
              Console.WriteLine("--------------Welcome to Revature Bank---------------\n\n");
                do
                    { 
         
            System.Console.WriteLine(menu);
                int accountNumber = 100;


             
                        int choice = Convert.ToInt32(System.Console.ReadLine());
                      
    
                        switch(choice){

                            case 1:
                            active = true;
                            accObj.setAccNo(++accountNumber);
                            System.Console.Write("Enter Account holder name:  ");
                            String name = System.Console.ReadLine();
                            accObj.setAccName(name);
                            System.Console.Write("What type of account does the holder want to open\n1. Savings\t2. Checking\t3. Merchant:\t4. Get Account Details\t0. Exit ");
                                int AccountChoice = Convert.ToInt32(System.Console.ReadLine());
                                #region Account Coice
                                    switch(AccountChoice){
                                        case 1:
                                        accObj.setAccType("Savings");
                                        break;

                                        case 2:
                                        accObj.setAccType("Checking");
                                        break;

                                        case 3:
                                        accObj.setAccType("Merchant");
                                        break;

                                        default:
                                        accObj.setAccType("Checking");
                                        break;
                                        }
                                #endregion
                            System.Console.Write("Enter User Email address: ");
                                String email = (System.Console.ReadLine());
                                accObj.setAccEmail(email);
                            
                            System.Console.Write("\nEnter inital deposit: ");
                            double deposit = Convert.ToDouble(System.Console.ReadLine());
                            accObj.setAccBalance(deposit);
                            break;

                            case 2:
                            double getBalance = accObj.getAccBalance();
                            System.Console.WriteLine("Your current Balance is " + getBalance);
                            break;

                            case 3:
                            System.Console.WriteLine("\n Enter amount you would like to withdrawal: ");
                             double withdrawal = Convert.ToDouble(System.Console.ReadLine());
                            accObj.withdrawal(withdrawal);
                            getBalance = accObj.getAccBalance();
                            System.Console.WriteLine("Your current Balance is " + getBalance);
                            break;

                            

                            default:
                            active = false;
                            System.Console.WriteLine("Thank you!");
                            break;
                            
                            

                        }

                    } while(active);


        }

    }
}