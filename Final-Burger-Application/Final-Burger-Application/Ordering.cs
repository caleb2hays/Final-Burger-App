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
        string bunType = "";
        int pattyNum;
        string orderStep; // keeps track of current panel

        Array[] cheeseType;
        Array[] toppings;
        Array[] sauce;
        Array[] optionsArray;



        public Ordering()
        {
            InitializeComponent();
        }


        //Application Load
        private void Ordering_Load(object sender, EventArgs e)
        {

            pnlStart.Visible = true;
            pnlLocation.Visible = false;
            pnlPrevNext.Visible = false;
            pnlOrderType.Visible = false;
            pnlBuild.Visible = false;
            pnlBun.Visible = false;
            pnlCheese.Visible = false;
            pnlComplete.Visible = false;
            pnlNav.Visible = false;
            pnlOrderDisplay.Visible = false;
            pnlSauce.Visible = false;
            pnlSpecialties.Visible = false;
            pnlSummary.Visible = false;
            pnlToppings.Visible = false;

        }


        // Button Click Events
        private void btnStart_Click(object sender, EventArgs e)
        {
            pnlStart.Visible = false;
            pnlLocation.Visible = true;
        }




        private void btnIn_Click(object sender, EventArgs e)
        {
            takeOut = false;

            pnlLocation.Visible = false;
            pnlPrevNext.Visible = true;
            pnlOrderType.Visible = true;

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

                default:
                    pnlStart.Visible = true;
                    break;
            }
        }


        //Panel Visible Changed Events
        private void pnlOrderType_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlOrderType.Visible == true)
            {
                orderStep = "ordertype";
            }
        }

        private void pnlLocation_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlLocation.Visible == true)
            {
                orderStep = "location";
            }
        }


        private void pnlStart_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlStart.Visible == true)
            {
                orderStep = "start";
            }
        }


        private void pnlBuild_VisibleChanged(object sender, EventArgs e)
        {
            if (pnlBuild.Visible == true)
            {
                orderStep = "build";
            }

        }

        

        
    }
}
