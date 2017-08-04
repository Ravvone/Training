using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class Package:Information
    {
        public string id;
        public string rep;
        public string Wghr;
        int DeliveryPrice = 5;
        


        

    }
    
    
    public class Information
    {
       
        public void ID()
        {
            string id = Console.ReadLine();
           
        }
        public void Rep()
        {
            string rep = Console.ReadLine();
        }
        public void Wght()
        {
            int Wghr = Convert.ToInt32(Console.ReadLine());
        }



    }
    
}
