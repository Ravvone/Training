using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPracticeAgain
{
    abstract class Rolex
    {

        public abstract string Mechanics();
        public abstract string Build();
        public abstract string Type();
    }
   
     class Swiss: Rolex
    {
        private string mechanism = "Automatic";
        private string build1 = "MC=srdtx2";
        private string watch = "Presidential";
        public  override string Mechanics()
        {
            
            return mechanism;


        }
        public  override string Build()
        {
             
            return build1;

        }
        public override string Type()
        {

            mechanism += watch;
            return watch;
        }


    }
    public class Audamar: Watches
    {
        string RO = "The Royal Oak";

        
        




    }
    public class Hublot : Watches
    {
        string BB = "Big Bang Evolution";


    }
}
