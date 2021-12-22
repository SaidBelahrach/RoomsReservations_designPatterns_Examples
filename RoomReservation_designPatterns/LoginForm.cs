using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RoomReservation_designPatterns.Destop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Client currentClient = new Client(tbNomComplet.Text, tbTele.Text, tbEmail.Text);
            Hotel.GetInstance().addCurrrentClient(currentClient);
            new home_Form().Show();
            this.Visible = false;
        }
    }
}
