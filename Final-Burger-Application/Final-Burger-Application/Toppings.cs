using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Burger_Application
{
    class Toppings
    {

        public string[] toppings = new string[] { };
       

        static public string createToppings(string _toppingsType)
        {
            
            string toppingsType = _toppingsType;

            toppings.Add(toppingsType);

            return toppingsType;
        }
    }
}
