
namespace RoomReservation_designPatterns.Destop
{
    partial class LoginForm
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
            this.panelContainerInputs = new System.Windows.Forms.Panel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTele = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbNomComplet = new System.Windows.Forms.TextBox();
            this.panelContainerInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainerInputs
            // 
            this.panelContainerInputs.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelContainerInputs.Controls.Add(this.loginBtn);
            this.panelContainerInputs.Controls.Add(this.label3);
            this.panelContainerInputs.Controls.Add(this.label2);
            this.panelContainerInputs.Controls.Add(this.label1);
            this.panelContainerInputs.Controls.Add(this.tbTele);
            this.panelContainerInputs.Controls.Add(this.tbEmail);
            this.panelContainerInputs.Controls.Add(this.tbNomComplet);
            this.panelContainerInputs.Location = new System.Drawing.Point(253, 30);
            this.panelContainerInputs.Name = "panelContainerInputs";
            this.panelContainerInputs.Size = new System.Drawing.Size(325, 369);
            this.panelContainerInputs.TabIndex = 0;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(46, 276);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(242, 37);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "Connexion";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(120, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(137, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Complet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTele
            // 
            this.tbTele.Location = new System.Drawing.Point(68, 204);
            this.tbTele.Multiline = true;
            this.tbTele.Name = "tbTele";
            this.tbTele.Size = new System.Drawing.Size(202, 37);
            this.tbTele.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(68, 142);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(202, 37);
            this.tbEmail.TabIndex = 1;
            // 
            // tbNomComplet
            // 
            this.tbNomComplet.Location = new System.Drawing.Point(68, 75);
            this.tbNomComplet.Multiline = true;
            this.tbNomComplet.Name = "tbNomComplet";
            this.tbNomComplet.Size = new System.Drawing.Size(202, 37);
            this.tbNomComplet.TabIndex = 0;
            this.tbNomComplet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContainerInputs);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panelContainerInputs.ResumeLayout(false);
            this.panelContainerInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainerInputs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTele;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbNomComplet;
        private System.Windows.Forms.Button loginBtn;
    }
}