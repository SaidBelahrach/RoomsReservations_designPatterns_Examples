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
    public partial class Reservations : Form
    {

        List<Reservation> reservations;
        public Reservations()
        {
            InitializeComponent();
        }
        public Reservations(List<Reservation> res)
        {
            this.reservations = res;
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            var i = 0;
            foreach(Reservation res in this.reservations)
            {
                dataGridView1.Rows[i].Cells[0].Value = res.id;
                dataGridView1.Rows[i].Cells[1].Value = res.dateDebut.Date + "-" + res.dateFin.Date;
                dataGridView1.Rows[i].Cells[2].Value = res.room.number;
                dataGridView1.Rows[i].Cells[3].Value = res.getReservationPrice();
                i++;
            }
        }
    }
}
