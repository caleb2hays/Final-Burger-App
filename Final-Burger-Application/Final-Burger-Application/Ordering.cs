using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Final_Burger_Application
{
    public partial class Ordering : Form
    {
        string message = "Button Pressed!";
        //Declarations
        bool takeOut;
        
        string orderStep; // keeps track of current panel

        public string[] optionsArray = new string[4];
        string bunType;
        string cheeseType;
        string[] toppings = new string[] {};
        string[] sauce = new string[] {};
        



        public Ordering()
        {
            InitializeComponent();
        }
        

        //Application Load
        private void Ordering_Load(object sender, EventArgs e)
        {

            pnlStart.Visible = true;

            //Hide the rest of the panels
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialties.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = false;
            pnlStack.Visible = false;

            lblStack.Text = "";

        }


      


        //Panel Visible Changed Events

        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }
        }


        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }
        }


        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "ordertype";
            }
        }


        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
                btnNext.Visible = false;
            }
        }


        private void pnlBun_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBun.Visible == true)
            {
                orderStep = "bun";
            }
        }

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
            }
        }

        private void pnlCheese_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlCheese.Visible == true)
            {
                orderStep = "cheese";
            }
        }




        // Button Click Events
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = false;
            pnlPrevNext.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlToppings.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialties.Visible = false;
            pnlSummary.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = false;
            pnlStack.Visible = false;
        }




        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;
            pnlLocation.Visible = false;
            pnlOrderType.Visible = true;
            pnlPrevNext.Visible = true;

        }


        private void btnOut_Click(object sender, EventArgs e)
        {
            takeOut = true;
            pnlLocation.Visible = false;
            pnlPrevNext.Visible = true;
            pnlOrderType.Visible = true;

        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
            pnlBuild.Visible = true;
        }


        private void btnSpecialty_Click(object sender, EventArgs e)
        {
            pnlOrderType.Visible = false;
        }






        private void btnPrev_Click(object sender, EventArgs e)
        {

            switch (orderStep)
            {
                case "ordertype":
                    pnlOrderType.Visible = false;
                    pnlLocation.Visible = true;
                    break;

                case "build":
                    pnlBuild.Visible = false;
                    pnlLocation.Visible = true;
                    break;

                case "bun":
                    pnlBun.Visible = false;
                    pnlBuild.Visible = true;
                    break;

                default:
                    pnlStart.Visible = true;
                    break;
            }
        }
     


        private void btnNext_Click(object sender, EventArgs e)
        {
            switch (orderStep)
            {
                case "build":
                    pnlBuild.Visible = false;
                    pnlBun.Visible = true;
                    break;

                case "bun":
                    pnlBun.Visible = false;
                    pnlCheese.Visible = true;
                    break;

                default:
                    pnlStart.Visible = true;
                    break;
            }
        }




        private void btnBuildStart_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = false;
            pnlBun.Visible = true;
            pnlNav.Visible = true;
            pnlStack.Visible = true;
        }


        private void btnWhiteBun_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[0] = Bun.createBun("White Bun");
            buildOptions();
        }


        private void btnWheatBun_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[0] = Bun.createBun("Wheat Bun");
            buildOptions();
        }

        private void btnPotatoBun_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[0] = Bun.createBun("Potato Bun");
            buildOptions();
        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[1] = Cheese.createCheese("American Cheese");
            buildOptions();
        }

        private void btnCheddar_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[1] = Cheese.createCheese("Cheddar Cheese");
            buildOptions();
        }

        private void btnSwiss_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[1] = Cheese.createCheese("Swiss Cheese");
            buildOptions();
        }

        private void btnNoCheese_Click(object sender, EventArgs e)
        {
            btnNext.Enabled = true;
            optionsArray[1] = Cheese.createCheese("No Cheese");
            buildOptions();
        }

        private void buildOptions()
        {
            lblStack.Text = optionsArray[0] + "\n" +
                            optionsArray[1] + "\n" +
                            optionsArray[2] + "\n" +
                            optionsArray[3] + "\n";
        }
        

      

        
        
    }
}
