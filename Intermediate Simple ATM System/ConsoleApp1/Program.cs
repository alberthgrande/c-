int balance = 0;

do{

    Console.WriteLine("\n\n1. Check Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");

    Console.Write("Choose: ");
    int choose = Convert.ToInt32(Console.ReadLine());

    if(choose == 1)
    {
        Console.WriteLine("\n\nBalance: " + balance);
    }
    
    else if(choose == 2)
    {
        Console.WriteLine("\n\nDeposit");
        Console.Write("\n\nEnter Deposit Amount: ");
        int deposit = Convert.ToInt32(Console.ReadLine());
        
        if(deposit > 0)
        {
            balance += deposit;
            Console.Write("\n\nNew Balance:: " + balance); 
        }
       
    }
    
    else if(choose == 3)
    {
        Console.WriteLine("\n\nWithdraw");
        Console.Write("\n\nEnter Withdraw Amount: ");
        int withdraw = Convert.ToInt32(Console.ReadLine());

        

        if(withdraw <= balance && withdraw > 0)
        {
            balance -= withdraw;
            Console.Write("\n\nNew Balance: " + balance);
        } else
        {
            Console.WriteLine("Invalid or insufficient balance.");
        }

    }

    else if (choose == 4)
    {
        break;
    }
    
    else
    {
        Console.WriteLine("Invalid choice.");
    }

}while(true);

Console.WriteLine("Thank you for using ATM.");

