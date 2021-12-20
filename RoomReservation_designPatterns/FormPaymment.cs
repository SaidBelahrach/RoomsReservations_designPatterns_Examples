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
            Panel panel = (sender as Panel);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            foreach (Panel item in panelMethohdsContianer.Controls)
            {
                if (item.Name == panel.Name)
                {
                    continue;
                }
                item.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            if (panelName.Contains("Mc"))
            {
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;
                Console.WriteLine("Mc");
            }
            else if (panelName.Contains("Paypal"))
            {
                panelPaypalFormContainer.Visible = true;
                panelForumCards.Visible = false;

                Console.WriteLine("Paypal");
            }
            else  //Vise Panel Chosen 
            {
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;

                Console.WriteLine("Visa");
            }

        }

       
    }
}
