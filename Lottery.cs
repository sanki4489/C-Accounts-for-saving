using System;

public class Lottery{

  private static Random rdm = 
          new Random(unchecked((int)DateTime.Now.Ticks));

  private int difficulty;
  private readonly int winningNumber;
  private readonly decimal amountWon;
  private static Lottery uniqueInstance = null;

  private Lottery(int difficulty){
    this.difficulty = difficulty;
    this.winningNumber = rdm.Next(difficulty);
    this.amountWon = 500000.00M;
  }

  public static Lottery Instance(int difficulty){
    if (uniqueInstance == null)
      uniqueInstance = new Lottery(difficulty);
    return uniqueInstance;
  }

  public int DrawLotteryNumber{
    get {return rdm.Next(difficulty);}
  }

  public decimal AmountWon(int luckyNumber){
    decimal res;
    if (WinningNumber(luckyNumber))
       res = amountWon;
    else
       res = 0.0M;
    return res;
  }

  private bool WinningNumber(int n){
    return n == winningNumber;
  }
}