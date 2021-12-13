using RoomReservation_designPatterns.Data.DataAccess;
namespace RoomReservation_designPatterns
{
    partial class home_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
       
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_Form));
            this.img_book = new System.Windows.Forms.Panel();
            this.btn_book = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // img_book
            // 
            this.img_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
            this.img_book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("img_book.BackgroundImage")));
            this.img_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.img_book.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.img_book.Location = new System.Drawing.Point(113, 106);
            this.img_book.Name = "img_book";
            this.img_book.Size = new System.Drawing.Size(200, 173);
            this.img_book.TabIndex = 0;
            this.img_book.Paint += new System.Windows.Forms.PaintEventHandler(this.img_book_Paint);
            // 
            // btn_book
            // 
            this.btn_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.btn_book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_book.FlatAppearance.BorderSize = 0;
            this.btn_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_book.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_book.Location = new System.Drawing.Point(139, 285);
            this.btn_book.Name = "btn_book";
            this.btn_book.Size = new System.Drawing.Size(145, 32);
            this.btn_book.TabIndex = 17;
            this.btn_book.Text = "Reserver";
            this.btn_book.UseVisualStyleBackColor = false;
            this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(162)))), ((int)(((byte)(184)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(473, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Mes reservations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(223)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(447, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 173);
            this.panel1.TabIndex = 18;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // home_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_book);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.img_book);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "home_Form";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.panel_home);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel img_book;
        private System.Windows.Forms.Button btn_book;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}

