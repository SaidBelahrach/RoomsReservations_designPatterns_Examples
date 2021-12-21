
namespace RoomReservation_designPatterns.Destop
{
    partial class FormPayement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayement));
            this.panelCardsContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPaypalFormContainer = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.panelMethohdsContianer = new System.Windows.Forms.Panel();
            this.panelPaypal = new System.Windows.Forms.Panel();
            this.panelMc = new System.Windows.Forms.Panel();
            this.panelVisa = new System.Windows.Forms.Panel();
            this.panelForumCards = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.tbDe = new System.Windows.Forms.TextBox();
            this.tbCvv = new System.Windows.Forms.TextBox();
            this.tbNc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panelCardsContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelPaypalFormContainer.SuspendLayout();
            this.panelMethohdsContianer.SuspendLayout();
            this.panelForumCards.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCardsContainer
            // 
            this.panelCardsContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelCardsContainer.Controls.Add(this.panel1);
            this.panelCardsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelCardsContainer.Name = "panelCardsContainer";
            this.panelCardsContainer.Size = new System.Drawing.Size(800, 450);
            this.panelCardsContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.labelAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panelPaypalFormContainer);
            this.panel1.Controls.Add(this.Ajouter);
            this.panel1.Controls.Add(this.panelMethohdsContianer);
            this.panel1.Controls.Add(this.panelForumCards);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(156, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 339);
            this.panel1.TabIndex = 0;
            // 
            // panelPaypalFormContainer
            // 
            this.panelPaypalFormContainer.Controls.Add(this.label8);
            this.panelPaypalFormContainer.Controls.Add(this.label7);
            this.panelPaypalFormContainer.Controls.Add(this.textBox2);
            this.panelPaypalFormContainer.Controls.Add(this.textBox4);
            this.panelPaypalFormContainer.Location = new System.Drawing.Point(35, 52);
            this.panelPaypalFormContainer.Name = "panelPaypalFormContainer";
            this.panelPaypalFormContainer.Size = new System.Drawing.Size(414, 183);
            this.panelPaypalFormContainer.TabIndex = 11;
            this.panelPaypalFormContainer.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Mot de Passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(350, 23);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 23);
            this.textBox4.TabIndex = 5;
            // 
            // Ajouter
            // 
            this.Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.Ajouter.FlatAppearance.BorderSize = 0;
            this.Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ajouter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ajouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ajouter.Location = new System.Drawing.Point(35, 289);
            this.Ajouter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(414, 37);
            this.Ajouter.TabIndex = 17;
            this.Ajouter.Text = "Confirmer";
            this.Ajouter.UseVisualStyleBackColor = false;
            this.Ajouter.Click += new System.EventHandler(this.Chekout_click);
            // 
            // panelMethohdsContianer
            // 
            this.panelMethohdsContianer.Controls.Add(this.panelPaypal);
            this.panelMethohdsContianer.Controls.Add(this.panelMc);
            this.panelMethohdsContianer.Controls.Add(this.panelVisa);
            this.panelMethohdsContianer.Location = new System.Drawing.Point(296, 241);
            this.panelMethohdsContianer.Name = "panelMethohdsContianer";
            this.panelMethohdsContianer.Size = new System.Drawing.Size(153, 42);
            this.panelMethohdsContianer.TabIndex = 10;
            // 
            // panelPaypal
            // 
            this.panelPaypal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPaypal.BackgroundImage")));
            this.panelPaypal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPaypal.Location = new System.Drawing.Point(110, 7);
            this.panelPaypal.Name = "panelPaypal";
            this.panelPaypal.Size = new System.Drawing.Size(39, 28);
            this.panelPaypal.TabIndex = 2;
            this.panelPaypal.Click += new System.EventHandler(this.card_Click);
            // 
            // panelMc
            // 
            this.panelMc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMc.BackgroundImage")));
            this.panelMc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMc.Location = new System.Drawing.Point(58, 7);
            this.panelMc.Name = "panelMc";
            this.panelMc.Size = new System.Drawing.Size(46, 28);
            this.panelMc.TabIndex = 1;
            this.panelMc.Click += new System.EventHandler(this.card_Click);
            // 
            // panelVisa
            // 
            this.panelVisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVisa.BackgroundImage")));
            this.panelVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelVisa.Location = new System.Drawing.Point(10, 7);
            this.panelVisa.Name = "panelVisa";
            this.panelVisa.Size = new System.Drawing.Size(42, 28);
            this.panelVisa.TabIndex = 0;
            this.panelVisa.Click += new System.EventHandler(this.card_Click);
            // 
            // panelForumCards
            // 
            this.panelForumCards.Controls.Add(this.label5);
            this.panelForumCards.Controls.Add(this.label4);
            this.panelForumCards.Controls.Add(this.label3);
            this.panelForumCards.Controls.Add(this.label2);
            this.panelForumCards.Controls.Add(this.tbOwner);
            this.panelForumCards.Controls.Add(this.tbDe);
            this.panelForumCards.Controls.Add(this.tbCvv);
            this.panelForumCards.Controls.Add(this.tbNc);
            this.panelForumCards.Location = new System.Drawing.Point(35, 52);
            this.panelForumCards.Name = "panelForumCards";
            this.panelForumCards.Size = new System.Drawing.Size(414, 183);
            this.panelForumCards.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date d\'expiration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Numéro de carte";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "CVV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Propriétaire";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(38, 46);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(218, 23);
            this.tbOwner.TabIndex = 3;
            // 
            // tbDe
            // 
            this.tbDe.Location = new System.Drawing.Point(38, 148);
            this.tbDe.Name = "tbDe";
            this.tbDe.Size = new System.Drawing.Size(115, 23);
            this.tbDe.TabIndex = 6;
            // 
            // tbCvv
            // 
            this.tbCvv.Location = new System.Drawing.Point(273, 46);
            this.tbCvv.Name = "tbCvv";
            this.tbCvv.Size = new System.Drawing.Size(115, 23);
            this.tbCvv.TabIndex = 4;
            // 
            // tbNc
            // 
            this.tbNc.Location = new System.Drawing.Point(38, 97);
            this.tbNc.Name = "tbNc";
            this.tbNc.Size = new System.Drawing.Size(350, 23);
            this.tbNc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirmer le Payment ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(35, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Montant a payé";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.ForeColor = System.Drawing.Color.Green;
            this.labelAmount.Location = new System.Drawing.Point(141, 263);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(15, 17);
            this.labelAmount.TabIndex = 19;
            this.labelAmount.Text = "0";
            // 
            // FormPayement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelCardsContainer);
            this.Name = "FormPayement";
            this.Text = "Payment";
            this.panelCardsContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPaypalFormContainer.ResumeLayout(false);
            this.panelPaypalFormContainer.PerformLayout();
            this.panelMethohdsContianer.ResumeLayout(false);
            this.panelForumCards.ResumeLayout(false);
            this.panelForumCards.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCardsContainer;
        private System.Windows.Forms.Panel panelPaypal;
        private System.Windows.Forms.Panel panelMc;
        private System.Windows.Forms.Panel panelVisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelForumCards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.TextBox tbDe;
        private System.Windows.Forms.TextBox tbCvv;
        private System.Windows.Forms.TextBox tbNc;
        private System.Windows.Forms.Panel panelMethohdsContianer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Panel panelPaypalFormContainer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label label6;
    }
}