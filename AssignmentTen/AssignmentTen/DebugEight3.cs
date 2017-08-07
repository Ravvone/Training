// Program demonstrates method that can be called
// with one, two, or three arguments
// Tuition is $80 per credit
// Default district code is I.
// If student is in-district (code I), then there is no
// out-of-district fee, which is $300
// Default scholarship status is false.
// If student is on scholarship, tuition is free
using static System.Console;
class DebugEight3
{
   public static void  EightTHree()
   {
        WriteLine("Tuition is {0}", CalculateTuition(15));
        WriteLine("Tuition is {0}", CalculateTuition(15,'O'));
        WriteLine("Tuition is {0}", CalculateTuition(15, 'O', true));
   }
    private static double CalculateTuition(double credits, char code = 'I', bool scholarship = false)
   {
      double tuition;
      const double RATE = 80.00;
      const double OUT_DISTRICT_FEE = 300.00;
      tuition = credits * RATE;

        if (code != 'I')
        {
            tuition += OUT_DISTRICT_FEE;
        }
        if(scholarship== true)
        {
            tuition = 0;
            
        }
        return tuition;
      
   }
}
