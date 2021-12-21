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
        private RoomRevervation_Facade rs;
        private Room chosenRoom;
        private DateTime debutDate;
        private DateTime endDate;
        public reserver_form()
        {
            rs = new RoomRevervation_Facade();
            InitializeComponent();
            initialRoomCheck();
        }

        private void reserver_form_Load(object sender, EventArgs e)
        {
            Hotel hotel=Hotel.GetInstance();
         /*   foreach (var item in hotel.getAvailableRooms().Select(r => r.state).ToArray())
            {
                this.chambres_combox.Items.Add(item);

            }*/
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
            List<Room> rooms = this.rs.getAvailableRooms(dateTimePickerDebut.Value, dateExpirePickerEnd.Value);
            if (rooms.Count == 0)
            {
                Ajouter.Enabled = false;
                lblRoomStatusAvail.Text = "Pas de chambres libre , Changer la date";
            }else
            {
                Ajouter.Enabled = true;
                this.chosenRoom = rooms[0];
                labelPrice.Text = this.chosenRoom.price * ((endDate - debutDate).Days +1 ) + "DH";
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Reservation res = new Reservation(this.chosenRoom, this.debutDate, this.endDate);
            this.rs.addReservation(res);
         /*   FormPayement fp = new FormPayement(res.getReservationPrice());
            fp.Show();
            this.Visible = false;*/

        } 

        private void initialRoomCheck()
        {
            List<Room> rooms = this.rs.getAvailableRooms(dateTimePickerDebut.Value, dateExpirePickerEnd.Value);
            if (rooms.Count > 0)
            {
                Ajouter.Enabled = true;
                this.chosenRoom = rooms[0];
                MessageBox.Show(this.chosenRoom.number+"");
                labelPrice.Text = rooms[0].price * ((dateExpirePickerEnd.Value - dateTimePickerDebut.Value).Days + 1) + "DH";
            }else
            {
                Ajouter.Enabled = false;
                labelPrice.Text = "";
                lblRoomStatusAvail.Text = "Pas de chambres libre , Changer la date";

            }
        }
    }
}
