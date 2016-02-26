using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Final_Burger_Application;

namespace Final_Burger_Application
{
    class Bun
    {
       static public string createBun(string _bunType)
        {
            var orderingApp = new Ordering();

            orderingApp.optionsArray[0] = _bunType;

            var bunType = _bunType;
            return bunType;
        }
    }
}
