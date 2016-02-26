using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Burger_Application
{
    class Sauces
    {

        static public string createSauce(string _sauceType)
        {
            var orderingApp = new Ordering();

            orderingApp.optionsArray[3] = _sauceType;

            var sauceType = _sauceType;
            return sauceType;
        }

    }
}
