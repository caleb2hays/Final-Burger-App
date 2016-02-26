using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final_Burger_Application
{
    class Cheese
    {

        static public string createCheese(string _cheeseType)
        {
            var orderingApp = new Ordering();

            orderingApp.optionsArray[1] = _cheeseType;

            var cheeseType = _cheeseType;
            return cheeseType;
        }
    }
}
