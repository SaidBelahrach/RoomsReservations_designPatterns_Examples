using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RoomReservation_designPatterns.Destop
{
    public partial class reserver_form : Form
    {
        private RoomRevervation_Facade facade;
        private Room chosenRoom = null;
        private DateTime debutDate;
        private DateTime endDate;
        public reserver_form()
        {
            facade = new RoomRevervation_Facade();
            InitializeComponent();
            initialRoomCheck();
        }

        private void reserver_form_Load(object sender, EventArgs e)
        {
            Hotel hotel = Hotel.GetInstance();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateExpirePickEnd_ValueChanged(object sender, EventArgs e)
        {
            lblRoomStatusAvail.Text = "";
            checkIfAroomAvailable();
        }

        private void dateTimePickerDebut_ValueChanged(object sender, EventArgs e)
        {
            lblRoomStatusAvail.Text = "";
            checkIfAroomAvailable();

        }

        private void checkIfAroomAvailable()
        {
            this.debutDate = dateTimePickerDebut.Value;
            this.endDate = dateExpirePickerEnd.Value;
            List<Room> rooms = this.facade.getAvailableRooms(dateTimePickerDebut.Value, dateExpirePickerEnd.Value);
            chambres_combox.Items.Clear();
            foreach (var item in rooms)
            {
                chambres_combox.Items.Add(item.number);
                chambres_combox.SelectedIndex = 0;
            }

            if (rooms.Count == 0)
            {
                Ajouter.Enabled = false;
                lblRoomStatusAvail.Text = "Pas de chambres libre , Changer la date";
            }
            else
            {
                Ajouter.Enabled = true;
                this.chosenRoom = rooms[0];
                labelPrice.Text = (endDate.Subtract(debutDate).TotalDays * chosenRoom.price).ToString("N2");// this.chosenRoom.price * ((endDate.Date - debutDate.Date).Days) + "DH";
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (chosenRoom == null || this.debutDate == null || this.endDate == null || this.debutDate > this.endDate)
            {
                MessageBox.Show("Données saisies incorrectes!", "Error", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            Reservation res = new Reservation(this.chosenRoom, this.debutDate, this.endDate);
            this.facade.addReservation(res);
            FormPayement fp = new FormPayement(res.amount);
            fp.Show();
            this.Visible = false;
        }

        private void initialRoomCheck()
        {
            List<Room> rooms = this.facade.getAvailableRooms(dateTimePickerDebut.Value, dateExpirePickerEnd.Value);
            if (rooms.Count > 0)
            {
                Ajouter.Enabled = true;
                //   this.chosenRoom = rooms[0]; 
                labelPrice.Text = "0 DH";
            }
            else
            {
                Ajouter.Enabled = false;
                labelPrice.Text = "";
                lblRoomStatusAvail.Text = "Pas de chambres libre , Changer la date";

            }
        }

        private void chambres_combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chosenRoom = Hotel.GetInstance().rooms.FirstOrDefault(r => r.number == chambres_combox.SelectedIndex);
        }

        private void Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
