using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RoomReservation_designPatterns.Data.DataModels;
using RoomReservation_designPatterns.Data.DataAccess;
using System.Linq;

namespace RoomReservation_designPatterns.Destop
{
    public partial class reserver_form : Form
    {
        private DateTime debutDate;
        private DateTime endDate;
        public reserver_form()
        {
            InitializeComponent();
        }

        private void reserver_form_Load(object sender, EventArgs e)
        {
            Hotel hotel=Hotel.GetInstance();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateExpirePickEnd_ValueChanged(object sender, EventArgs e)
        {
            lblRoomStatusAvail.Text = "";
            this.debutDate = dateTimePickerDebut.Value;
            checkIfAroomAvailable();
        }

        private void dateTimePickerDebut_ValueChanged(object sender, EventArgs e)
        {
            lblRoomStatusAvail.Text = "";
            this.endDate = dateExpirePickerEnd.Value;
            checkIfAroomAvailable();

        }

        private Room checkIfAroomAvailable()
        {
            lblRoomStatusAvail.Text = "qsdkmqsd";
            return new Room();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            FormPayement fp = new FormPayement();
            fp.Show();
            this.Visible = false;


        }
    }
}
