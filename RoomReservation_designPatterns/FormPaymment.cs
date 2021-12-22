using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Windows.Forms;

namespace RoomReservation_designPatterns.Destop
{
    public partial class FormPayement : Form
    {
        IPayment payment;
        private float amount = 0;
        public FormPayement(float amount)
        {
            this.amount = amount;
            InitializeComponent();
            labelAmount.Text = amount.ToString("N2") + " DH";
        }

        private void card_Click(object sender, EventArgs e)
        {
            String panelName = (sender as Panel).Name;
            Panel panel = (sender as Panel);
            panel.BorderStyle = BorderStyle.Fixed3D;
            foreach (Panel item in panelMethohdsContianer.Controls)
            {
                if (item.Name == panel.Name)
                {
                    continue;
                }
                item.BorderStyle = BorderStyle.None;
            }
            if (panelName.Contains("Paypal"))
            {
                payment = new CardFactory().getCard("Visa");
                panelPaypalFormContainer.Visible = true;
                panelForumCards.Visible = false;
            }
            else if (panelName.Contains("Mc"))
            {
                payment = new CardFactory().getCard("MasterCard");
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;
            }
            else //Paypal
            {
                payment = new Paypal();
                panelForumCards.Visible = true;
                panelPaypalFormContainer.Visible = false;
            }

        }

        private void Chekout_click(object sender, EventArgs e)
        {
            if (payment == null)
            {
                MessageBox.Show("Données incorrectes", "Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            Payment_Stategy ps = new Payment_Stategy(payment);
            if (ps.pay(amount))
            {
                MessageBox.Show("Reservation effectué!", "Reservation", MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                this.Close();
            }
            else MessageBox.Show("Reservation échouée!", "Reservation", MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);

        }
    }
}
