using System;

public class SavingsAccount: BankAccount {

   public SavingsAccount(string o, double ir): 
     base(o, 0.0M, ir) {
   }

   public SavingsAccount(string o, decimal b, double ir): 
     base(o, b, ir) {
   }

   public override void Withdraw (decimal amount) {
      if (amount < balance)
          balance -= amount;
      else
          throw new Exception("Cannot withdraw");
   }

   public override void AddInterests() {
      balance = balance + balance * (decimal)interestRate 
                        - 100.0M;
   }    

   public override string ToString() {
      return owner + "'s savings account holds " +
            + balance + " kroner";
   }
} 