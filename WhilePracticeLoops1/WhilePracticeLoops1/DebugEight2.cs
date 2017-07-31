// Overloaded method gives bonus points
// whether grade is a number or letter
using static System.Console;
class DebugEight2
{
   static void eighttwo()
   {
      int testScore = 82;
      string letterScore = "B";
      Write("Score was {0}. ", testScore);
      GiveBonus(ref testScore);
      WriteLine("Now it is {0}.", testScore);
        GiveBonus(ref letterScore);
        Write("Grade was {0}. ", letterScore);
      GiveBonus(ref letterScore);
      WriteLine("Now it is {0}. ", letterScore);
        ReadLine();
   }
   private static void GiveBonus(ref int testScore)
   {
      const int BONUS = 5;
      testScore = BONUS;
   }
   private static void GiveBonus(ref string letterScore)
   {
      const string BONUS = "+";
      letterScore = BONUS;
   }
}

