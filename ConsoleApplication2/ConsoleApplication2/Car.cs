using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Car
    {

        public int Mileage = 60;
        public string color = "Red";
        private string fourmula = "a + b";


        public int GetMileage()
        {
            return Mileage;

        }
        public string GetColor()
        {

            return color;
        }
        private string GetEngineFormula()
        {
            return fourmula;
        }
        public string DisplayEngineFourmula()
        {

            return GetEngineFormula();
        }


    }
   
}
