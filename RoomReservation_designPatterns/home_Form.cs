﻿using RoomReservation_designPatterns.Data.DataModels;
using RoomReservation_designPatterns.Destop;
using RoomReservation_designPatterns.Destop.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomReservation_designPatterns
{
    public partial class home_Form : Form
    {
        RoomRevervation_Facade facade = new RoomRevervation_Facade();
        public home_Form()
        {
            InitializeComponent();
            labelClientName.Text ="Bonjour "+ Hotel.GetInstance().CurrentClient.fullname;
        }

        private void img_book_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_home(object sender, EventArgs e)
        {

        }

        private void btn_book_Click(object sender, EventArgs e)
        { 
            reserver_form bookForm = new reserver_form();
            bookForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservations myreser = new Reservations(facade.getClientReservations());
            myreser.Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }
    }
}
