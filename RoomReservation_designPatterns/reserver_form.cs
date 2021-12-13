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
        public reserver_form()
        {
            InitializeComponent();
        }

        private void reserver_form_Load(object sender, EventArgs e)
        {
            Hotel hotel=Hotel.GetInstance();
            foreach (var item in hotel.getAvailableRooms().Select(r => r.state).ToArray())
            {
                this.chambres_combox.Items.Add(item);

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
