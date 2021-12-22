
using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;

namespace RoomReservation_designPatterns.Destop
{
    partial class reserver_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserver_form));
            this.Titre = new System.Windows.Forms.Label();
            this.DE = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateExpirePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lbl_chambre = new System.Windows.Forms.Label();
            this.chambres_combox = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRoomStatusAvail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.Titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titre.Location = new System.Drawing.Point(0, 0);
            this.Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(741, 59);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Reserver chambre";
            this.Titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DE
            // 
            this.DE.AutoSize = true;
            this.DE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DE.Location = new System.Drawing.Point(371, 158);
            this.DE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DE.Name = "DE";
            this.DE.Size = new System.Drawing.Size(73, 20);
            this.DE.TabIndex = 6;
            this.DE.Text = "Date fin :";
            // 
            // Annuler
            // 
            this.Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Annuler.FlatAppearance.BorderSize = 0;
            this.Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Annuler.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Annuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Annuler.Location = new System.Drawing.Point(485, 395);
            this.Annuler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(110, 37);
            this.Annuler.TabIndex = 13;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = false;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Ajouter.Enabled = false;
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ajouter.Location = new System.Drawing.Point(616, 395);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(110, 37);
            this.Ajouter.TabIndex = 16;
            this.Ajouter.Text = "Valider";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(13, 73);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // dateExpirePickerEnd
            // 
            this.dateExpirePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateExpirePickerEnd.Location = new System.Drawing.Point(545, 154);
            this.dateExpirePickerEnd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateExpirePickerEnd.MinimumSize = new System.Drawing.Size(4, 27);
            this.dateExpirePickerEnd.Name = "dateExpirePickerEnd";
            this.dateExpirePickerEnd.Size = new System.Drawing.Size(181, 27);
            this.dateExpirePickerEnd.TabIndex = 19;
            this.dateExpirePickerEnd.ValueChanged += new System.EventHandler(this.dateExpirePickEnd_ValueChanged);
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblQuantite.Location = new System.Drawing.Point(370, 215);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(164, 20);
            this.lblQuantite.TabIndex = 21;
            this.lblQuantite.Text = "nombre de personne :";
            // 
            // lbl_chambre
            // 
            this.lbl_chambre.AutoSize = true;
            this.lbl_chambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_chambre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_chambre.Location = new System.Drawing.Point(370, 76);
            this.lbl_chambre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_chambre.Name = "lbl_chambre";
            this.lbl_chambre.Size = new System.Drawing.Size(74, 20);
            this.lbl_chambre.TabIndex = 27;
            this.lbl_chambre.Text = "Chambre";
            // 
            // chambres_combox
            // 
            this.chambres_combox.BackColor = System.Drawing.Color.White;
            this.chambres_combox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chambres_combox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chambres_combox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chambres_combox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chambres_combox.ItemHeight = 18;
            this.chambres_combox.Location = new System.Drawing.Point(545, 69);
            this.chambres_combox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chambres_combox.Name = "chambres_combox";
            this.chambres_combox.Size = new System.Drawing.Size(181, 26);
            this.chambres_combox.TabIndex = 28;
            this.chambres_combox.SelectedIndexChanged += new System.EventHandler(this.chambres_combox_SelectedIndexChanged);
            // 
            // dateTimePickerDebut
            // 
            this.dateTimePickerDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDebut.Location = new System.Drawing.Point(545, 111);
            this.dateTimePickerDebut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerDebut.MinimumSize = new System.Drawing.Size(4, 27);
            this.dateTimePickerDebut.Name = "dateTimePickerDebut";
            this.dateTimePickerDebut.Size = new System.Drawing.Size(181, 27);
            this.dateTimePickerDebut.TabIndex = 30;
            this.dateTimePickerDebut.ValueChanged += new System.EventHandler(this.dateTimePickerDebut_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(370, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(370, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Coût:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelPrice.Location = new System.Drawing.Point(545, 314);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(84, 38);
            this.labelPrice.TabIndex = 32;
            this.labelPrice.Text = "0 DH";
            this.labelPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(541, 217);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(181, 23);
            this.numericUpDown1.TabIndex = 33;
            // 
            // lblRoomStatusAvail
            // 
            this.lblRoomStatusAvail.AutoSize = true;
            this.lblRoomStatusAvail.ForeColor = System.Drawing.Color.Maroon;
            this.lblRoomStatusAvail.Location = new System.Drawing.Point(392, 190);
            this.lblRoomStatusAvail.Name = "lblRoomStatusAvail";
            this.lblRoomStatusAvail.Size = new System.Drawing.Size(0, 15);
            this.lblRoomStatusAvail.TabIndex = 34;
            // 
            // reserver_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(741, 454);
            this.Controls.Add(this.lblRoomStatusAvail);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerDebut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chambres_combox);
            this.Controls.Add(this.lbl_chambre);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.dateExpirePickerEnd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.DE);
            this.Controls.Add(this.Titre);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "reserver_form";
            this.Text = "Ajouter Produit";
            this.Load += new System.EventHandler(this.reserver_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        } 

        #endregion
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label DE;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateExpirePickerEnd;
        private System.Windows.Forms.Label lblQuantite;
        private Label lbl_chambre;
        public ComboBox chambres_combox;
        private DateTimePicker dateTimePickerDebut;
        private Label label2;
        private Label label1;
        private Label labelPrice;
        private NumericUpDown numericUpDown1;
        private Label lblRoomStatusAvail;
    }
}