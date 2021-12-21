using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoomReservation_designPatterns.Destop
{
    public enum PayMethod
    {
        PAYPAL,
        VISA,
        MASTER_CARD
    }
    public partial class FormPayement : Form
    {
        PayMethod chosenMethode = PayMethod.VISA;
        private float amount = 0;
        public FormPayement(float amount)
        {
            this.amount = amount;
            InitializeComponent();
            labelAmount.Text = amount + " DH";
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
                this.chosenMethode = PayMethod.MASTER_CARD;
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;
            }
            else if (panelName.Contains("Paypal"))
            {
                this.chosenMethode = PayMethod.PAYPAL;
                panelPaypalFormContainer.Visible = true;
                panelForumCards.Visible = false;
            }
            else  //Visa Panel Chosen 
            {
                this.chosenMethode = PayMethod.VISA;
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;
            }

        }

        private void Chekout_click(object sender, EventArgs e)
        {
            if(this.chosenMethode == PayMethod.MASTER_CARD)
            {

            }else if(this.chosenMethode == PayMethod.PAYPAL)
            {

            }else // Visa Methode is Chosen
            {

            }

        }
    }
}
