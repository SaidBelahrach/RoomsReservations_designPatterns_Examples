using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoomReservation_designPatterns.Destop
{
    public partial class FormPayement : Form
    {
        public FormPayement()
        {
            InitializeComponent();
        }

        private void card_Click(object sender, EventArgs e)
        {
            String panelName = (sender as Panel).Name;
            if (panelName.Contains("Mc"))
            {

            }
            else if (panelName.Contains("Paypal"))
            {

            }
            else  //Vise Panel Chosen 
            {

            }
            panelCardsContainer.Visible = false;
            paneMethodePayement.Visible = true;
        }

     
    }
}
