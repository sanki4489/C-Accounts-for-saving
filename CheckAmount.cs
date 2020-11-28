using System;

public class CheckAccount: BankAccount {

   public CheckAccount(string o, double ir): 
     base(o, 0.0M, ir) {
   }

   public CheckAccount(string o, decimal b, double ir): 
     base(o, b, ir) {
   }

   public override void Withdraw (decimal amount) {
      balance -= amount;
      if (amount < balance)
         interestRate = -0.10;
   }

   public override string ToString() {
      return owner + "'s check account holds " +
            + balance + " kroner";
   }
} 