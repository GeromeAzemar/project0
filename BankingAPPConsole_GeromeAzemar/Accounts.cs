using System;


public class Accounts {
#region Properties
 int accNo = 0;

 string accName = null;

 string accType = null; 

 double accBalance = 0;

 bool accIsActive = false;

 string accEmail = null;
#endregion
#region Getters
public int getAccNo(){
    return accNo;
}
public String getAccName(){
    return accName;
}
public String getAccType(){
    return accType;
}

public double getAccBalance(){
    return accBalance;
}

public String getEmail(){
    return accEmail;
}
#endregion

#region Setters

public void setAccNo(int accNo) {
    this.accNo = accNo;
}
public void setAccName(string accName) {
    this.accName = accName;
}

public void setAccType(string accType) {
    this.accType = accType;
}

public void setAccBalance(double accBalance) {
    this.accBalance = accBalance;
}

public void setAccIsActive(bool accIsActive) {
    this.accIsActive = accIsActive;
}

public void setAccEmail(string accEmail) {
    this.accEmail = accEmail;
}
#endregion

#region Methods

#region Withdrawal 
public void withdrawal(double amount){
    System.Console.WriteLine("Starting Balance ----------- " + this.accBalance);
    if(amount < this.accBalance){;
    this.accBalance = this.accBalance - amount;
    System.Console.WriteLine("Current Balace ---------- " + this.accBalance);
    }
    else
    System.Console.WriteLine("Insufficient Funds");
}

#endregion

#region Deposit
public void Deposit(double amount){
    System.Console.WriteLine("Starting Balance ----------- " + this.accBalance);
    if(amount > 0){;
    this.accBalance = this.accBalance + amount;
    System.Console.WriteLine("Current Balace ---------- " + this.accBalance);
    }
    else
    System.Console.WriteLine("Please try to Withdrawal option");
}
#endregion

#region AccountDetails

public void getAccountDetails(){
    System.Console.WriteLine("Account No: " + this.accNo);
    System.Console.WriteLine("\tName: " + this.accName);
    System.Console.WriteLine("\tType: " + this.accType);
    System.Console.WriteLine("\tBalance: " + this.accBalance);
    System.Console.WriteLine("\tEmail: " + this.accEmail);
}

#endregion

#endregion

}