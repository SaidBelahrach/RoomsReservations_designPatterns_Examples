
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
            this.panelPaypal = new System.Windows.Forms.Panel();
            this.panelMc = new System.Windows.Forms.Panel();
            this.panelVisa = new System.Windows.Forms.Panel();
            this.paneMethodePayement = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCardsContainer.SuspendLayout();
            this.paneMethodePayement.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCardsContainer
            // 
            this.panelCardsContainer.Controls.Add(this.paneMethodePayement);
            this.panelCardsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelCardsContainer.Name = "panelCardsContainer";
            this.panelCardsContainer.Size = new System.Drawing.Size(800, 450);
            this.panelCardsContainer.TabIndex = 0;
            // 
            // panelPaypal
            // 
            this.panelPaypal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPaypal.BackgroundImage")));
            this.panelPaypal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPaypal.Location = new System.Drawing.Point(596, 277);
            this.panelPaypal.Name = "panelPaypal";
            this.panelPaypal.Size = new System.Drawing.Size(192, 150);
            this.panelPaypal.TabIndex = 2;
            this.panelPaypal.Click += new System.EventHandler(this.card_Click);
            // 
            // panelMc
            // 
            this.panelMc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMc.BackgroundImage")));
            this.panelMc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMc.Location = new System.Drawing.Point(55, 238);
            this.panelMc.Name = "panelMc";
            this.panelMc.Size = new System.Drawing.Size(192, 150);
            this.panelMc.TabIndex = 1;
            this.panelMc.Click += new System.EventHandler(this.card_Click);
            // 
            // panelVisa
            // 
            this.panelVisa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelVisa.BackgroundImage")));
            this.panelVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelVisa.Location = new System.Drawing.Point(55, 41);
            this.panelVisa.Name = "panelVisa";
            this.panelVisa.Size = new System.Drawing.Size(192, 150);
            this.panelVisa.TabIndex = 0;
            this.panelVisa.Click += new System.EventHandler(this.card_Click);
            // 
            // paneMethodePayement
            // 
            this.paneMethodePayement.Controls.Add(this.panelPaypal);
            this.paneMethodePayement.Controls.Add(this.panel1);
            this.paneMethodePayement.Controls.Add(this.panelMc);
            this.paneMethodePayement.Controls.Add(this.panelVisa);
            this.paneMethodePayement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneMethodePayement.Location = new System.Drawing.Point(0, 0);
            this.paneMethodePayement.Name = "paneMethodePayement";
            this.paneMethodePayement.Size = new System.Drawing.Size(800, 450);
            this.paneMethodePayement.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(127, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(269, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 347);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
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
            this.paneMethodePayement.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCardsContainer;
        private System.Windows.Forms.Panel paneMethodePayement;
        private System.Windows.Forms.Panel panelPaypal;
        private System.Windows.Forms.Panel panelMc;
        private System.Windows.Forms.Panel panelVisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}