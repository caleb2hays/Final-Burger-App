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
        public Ordering()
        {
            InitializeComponent();
        }

        private void appStartPage_Load(object sender, EventArgs e)
        {
           
        }



        private void btnOne_Click(object sender, EventArgs e)
        {
            lblOutput.Text = message;
            
        }



        private void lblOutput_TextChanged(object sender, EventArgs e)
        {
            lblOne.Text = "Changed";
        }

        
    }
}
