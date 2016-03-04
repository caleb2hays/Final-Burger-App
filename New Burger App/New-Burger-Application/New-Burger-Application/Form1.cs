using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace New_Burger_Application
{
    public partial class Ordering : Form
    {

        public string[] optionsArray = new string[6];

        


        public Ordering()
        {
            InitializeComponent();
        }


        // Page load 
        private void Ordering_Load(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
            pnlStack.Visible = false;
            pnlHideNav.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlHideStack.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlStack.Visible = false;
            pnlFinished.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
            
                       
        }



        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlInOrOut.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlFinished.Visible = false;          
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }


        private void btnDineIn_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "Dining In";
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlInOrOut.Visible = false;
            pnlOrderType.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            buildOptions();
        }


        private void btnTakeOut_Click(object sender, EventArgs e)
        {
            optionsArray[0] = "Order is To Go";
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlInOrOut.Visible = false;
            pnlOrderType.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            buildOptions();
        }


        private void btnFavs_Click(object sender, EventArgs e)
        {
            pnlFavs.Visible = true;
            pnlInOrOut.Visible = false;
            pnlOrderType.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlNavi.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }


        private void btnFavsComplete_Click(object sender, EventArgs e)
        {
            pnlHidePrevNext.Visible = true;
            pnlFavs.Visible = false;
            pnlSummary.Visible = true;
            pnlHideStack.Visible = true;
            pnlStack.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            summaryExecution();
        }


        private void btnCustom_Click(object sender, EventArgs e)
        {
            optionsArray[5] = "Custom";

            pnlBuns.Visible = true;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false; 
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlStack.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = true;
            pnlHideStack.Visible = true;
            pnlHidePrevNext.Visible = true;
            pnlHideNav.Visible = true;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }


        private void btnStartOver_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = true;
            pnlStack.Visible = false;
            pnlHideNav.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideStack.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlStack.Visible = false;
            pnlFinished.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            //resets order summary
            optionsArray[0] = "Your Order Will Appear Here...";
            optionsArray[1] = "";
            optionsArray[2] = "";
            optionsArray[3] = "";
            optionsArray[4] = "";
            optionsArray[5] = "";
            buildOptions();

        }


        private void btnMakeChanges_Click(object sender, EventArgs e)
        {

            if (optionsArray[5] != "Custom")
            {
                pnlFavs.Visible = true;
                pnlInOrOut.Visible = false;
                pnlOrderType.Visible = false;
                pnlHidePrevNext.Visible = false;
                pnlHideStack.Visible = false;
                pnlStack.Visible = true;
                pnlNavi.Visible = false;
                pnlStart.Visible = false;
                pnlFinished.Visible = false;
                pnlHideNav.Visible = false;
                pnlSummary.Visible = false;
                pnlBuns.Visible = false;
                pnlCheese.Visible = false;
                pnlSauce.Visible = false;
                pnlToppings.Visible = false;
            }

            else
            {
                pnlBuns.Visible = true;
                pnlFavs.Visible = false;
                pnlInOrOut.Visible = false;
                pnlNavi.Visible = true;
                pnlOrderType.Visible = false;
                pnlStack.Visible = true;
                pnlStart.Visible = false;
                pnlFinished.Visible = false;
                pnlHideStack.Visible = false;
                pnlHidePrevNext.Visible = false;
                pnlHideNav.Visible = false;
                pnlSummary.Visible = false;
                pnlCheese.Visible = false;
                pnlSauce.Visible = false;
                pnlToppings.Visible = false;
            }
        }


        //Nav bar properties
        private void btnNavBun_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = true;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }

        private void btnNavCheese_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = true;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }

        private void btnNavToppings_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = true;
        }

        private void btnNavSauces_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = true;
            pnlToppings.Visible = false;
        }





        //properties for buns
        //radio buttons for bun choice
        private void rdioWhite_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: White";
            buildOptions();
        }

        private void rdioWheat_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: Wheat";
            buildOptions();
        }

        private void rdioPotato_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: Potato";
            buildOptions();
        }



        //properties for cheese section
        //radio buttons for cheese choice
        private void rdioAmerican_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[2] = "Cheese: American";
            buildOptions();
        }

        private void rdioCheddar_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[2] = "Cheese: Cheddar";
            buildOptions();
        }

        private void rdioSwiss_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[2] = "Cheese: Swiss";
            buildOptions();
        }

        

        //properties for Sauce section
        //radio buttons for sauce choices
        private void rbKetchup_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[4] = "Sauce: Ketchup";
            buildOptions();
        }

        private void rbMustard_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[4] = "Sauce: Mustard";
            buildOptions();
        }

        private void rbMayo_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[4] = "Sauce: Mayo";
            buildOptions();
        }

        private void rbBBQ_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[4] = "Sauce: BBQ";
            buildOptions();
        }


        //Properties for toppings section
        //radio buttons for toppings choices
        private void rbLettuce_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[3] = "Toppings: Lettuce";
            buildOptions();
        }

        private void rbTomatos_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[3] = "Toppings: Tomatos";
            buildOptions();
        }

        private void rbPickles_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[3] = "Toppings: Pickles";
            buildOptions();
        }

        private void rbOnions_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[3] = "Toppings: Onions";
            buildOptions();
        }


        //Stack options for premade orders
        private void rdioEveryones_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: Potato";
            optionsArray[2] = "Cheese: Cheddar";
            optionsArray[3] = "Toppings: Onions";
            optionsArray[4] = "Sauce: BBQ";
            optionsArray[5] = "Everyone's Favorite";
            buildOptions();
        }

        private void rdioAllAmerican_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: White";
            optionsArray[2] = "Cheese: American";
            optionsArray[3] = "Toppings: Lettuce";
            optionsArray[4] = "Sauce: Ketchup";
            optionsArray[5] = "All American";
            buildOptions();
        }

        private void rdioDeluxe_CheckedChanged(object sender, EventArgs e)
        {
            optionsArray[1] = "Bun: Wheat";
            optionsArray[2] = "Cheese: Swiss";
            optionsArray[3] = "Toppings: Pickles";
            optionsArray[4] = "Sauce: Mayo";
            optionsArray[5] = "Deluxe";
            buildOptions();
        }








        //Prev Next Options for different panels (Decided to build Prev-Next buttons into individual panels
        //ordertype panel
        private void btnOrderTypePrev_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlInOrOut.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            //resets all options
            optionsArray[0] = "Your Order Will Appear Here...";
            optionsArray[1] = "";
            optionsArray[2] = "";
            optionsArray[3] = "";
            optionsArray[4] = "";
            optionsArray[5] = "";
            buildOptions();
        }
        
        //favs panel
        private void btnFavsPrev_Click(object sender, EventArgs e)
        {
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlInOrOut.Visible = false;
            pnlOrderType.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;


            //resets order summary
            optionsArray[1] = "";
            optionsArray[2] = "";
            optionsArray[3] = "";
            optionsArray[4] = "";
            optionsArray[5] = "";
            buildOptions();
        }

        //buns panel
        private void btnBunsPrev_Click(object sender, EventArgs e)
        {
            pnlHideStack.Visible = false;
            pnlStack.Visible = true;
            pnlInOrOut.Visible = false;
            pnlOrderType.Visible = true;
            pnlHidePrevNext.Visible = false;
            pnlFavs.Visible = false;
            pnlNavi.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }
        private void btnBunsNext_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = true;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }

        //cheese panel
        private void btnCheesePrev_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = true;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }
        private void btnCheesesNext_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = true;
        }

        //toppings panel
        private void btnToppingsPrev_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = true;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;
        }
        private void btnToppingsNext_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = true;
            pnlToppings.Visible = false;
        }

        //sauces panel
        private void btnSaucePrev_Click(object sender, EventArgs e)
        {
            pnlBuns.Visible = false;
            pnlFavs.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = true;
            pnlOrderType.Visible = false;
            pnlStack.Visible = true;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideStack.Visible = false;
            pnlHidePrevNext.Visible = false;
            pnlHideNav.Visible = false;
            pnlSummary.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = true;
        }
        private void btnCustomComplete_Click(object sender, EventArgs e)
        {
            pnlHidePrevNext.Visible = true;
            pnlFavs.Visible = false;
            pnlSummary.Visible = true;
            pnlHideStack.Visible = true;
            pnlStack.Visible = false;
            pnlInOrOut.Visible = false;
            pnlNavi.Visible = false;
            pnlOrderType.Visible = false;
            pnlStart.Visible = false;
            pnlFinished.Visible = false;
            pnlHideNav.Visible = false;
            pnlBuns.Visible = false;
            pnlCheese.Visible = false;
            pnlSauce.Visible = false;
            pnlToppings.Visible = false;

            summaryExecution();
        }




        //Methods
        //Sets the Stack text
        private void buildOptions()
        {
            txtStack.Text = optionsArray[0] + "\r\n" +
                            optionsArray[1] + "\r\n" +
                            optionsArray[2] + "\r\n" +
                            optionsArray[3] + "\r\n" +
                            optionsArray[4];
        }

        //Sets the summary text
        private void summaryExecution()
        {
            txtSum.Text =
               "Your Order Summary \r\n" +
               "\r\n" +
               "----------------------------------\r\n" +
               "Eating Location: " + optionsArray[0] + "\r\n" +
               "----------------------------------\r\n" +
               "Burger Choice: " + optionsArray[5] + "\r\n" +
               "----------------------------------\r\n" +
               "Your Choice of " + optionsArray[1] + "\r\n" +
               "Your Choice of " + optionsArray[2] + "\r\n" +
               "Your Choice of " + optionsArray[3] + "\r\n" +
               "Your Choice of " + optionsArray[4] + "\r\n" +
               "----------------------------------";
        }

        

        

        

        

        

        

        

        

        

        

        

        

        

       

        

        

        

        

        

        

        



        



        

        

       

        

        

        

        


        
        


   
    

        



        
    }
}
