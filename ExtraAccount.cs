using System;

public class ExtraAccount: BankAccount {

   private static Lottery lottery  = Lottery.Instance(20);

   public ExtraAccount(string o, decimal b): 
     base(o, b, 0.0) {
   }

   public override void AddInterests() {
      int luckyNumber = lottery.DrawLotteryNumber;
      balance = balance + lottery.AmountWon(luckyNumber);
   }    

   public override string ToString() {
      return owner + "'s lottery account holds " +
            + balance + " kroner";
   }
} 