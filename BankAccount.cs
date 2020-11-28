using System;

public class BankAccount {

   protected double interestRate;
   protected string owner;
   protected decimal balance;

   public BankAccount(string o, decimal b, double ir) {
      this.interestRate = ir;
      this.owner = o; 
      this.balance = b;
   }

   public BankAccount(string o, double ir):
     this(o, 0.0M, ir) {
   }

   public virtual decimal Balance {
     get {return balance;}
   }

   public virtual void Withdraw (decimal amount) {
      balance -= amount;
   }

   public virtual void Deposit (decimal amount) {
      balance += amount;
   }

   public virtual void AddInterests() {
      balance += balance * (Decimal)interestRate;
   }    

   public override string ToString() {
      return owner + "'s account holds " +
            + balance + " kroner";
   }
} 