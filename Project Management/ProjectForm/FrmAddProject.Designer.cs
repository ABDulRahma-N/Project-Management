namespace Project_Management
{
    partial class FrmAddProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.DtpPlannedEndDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // TbName
            // 
            this.TbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbName.DefaultText = "";
            this.TbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbName.Location = new System.Drawing.Point(443, 108);
            this.TbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbName.Name = "TbName";
            this.TbName.PlaceholderText = "";
            this.TbName.SelectedText = "";
            this.TbName.Size = new System.Drawing.Size(495, 51);
            this.TbName.TabIndex = 2;
            // 
            // TbDescription
            // 
            this.TbDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbDescription.DefaultText = "";
            this.TbDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbDescription.Location = new System.Drawing.Point(443, 200);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.PlaceholderText = "";
            this.TbDescription.SelectedText = "";
            this.TbDescription.Size = new System.Drawing.Size(495, 141);
            this.TbDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Planned End Date";
            // 
            // BtSubmit
            // 
            this.BtSubmit.BorderRadius = 15;
            this.BtSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtSubmit.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.BtSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtSubmit.ForeColor = System.Drawing.Color.Black;
            this.BtSubmit.Location = new System.Drawing.Point(634, 639);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(304, 93);
            this.BtSubmit.TabIndex = 8;
            this.BtSubmit.Text = "Submit";
            this.BtSubmit.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 15;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.Location = new System.Drawing.Point(107, 639);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(304, 93);
            this.guna2Button3.TabIndex = 10;
            this.guna2Button3.Text = "Cancel";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(443, 388);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpStartDate.Size = new System.Drawing.Size(495, 37);
            this.DtpStartDate.TabIndex = 11;
            // 
            // DtpPlannedEndDate
            // 
            this.DtpPlannedEndDate.Location = new System.Drawing.Point(443, 524);
            this.DtpPlannedEndDate.Name = "DtpPlannedEndDate";
            this.DtpPlannedEndDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpPlannedEndDate.Size = new System.Drawing.Size(495, 37);
            this.DtpPlannedEndDate.TabIndex = 12;
            // 
            // FrmAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1008, 794);
            this.Controls.Add(this.DtpPlannedEndDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddProject";
            this.Text = "FrmAddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TbName;
        private Guna.UI2.WinForms.Guna2TextBox TbDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button BtSubmit;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Krypton.Toolkit.KryptonDateTimePicker DtpStartDate;
        private Krypton.Toolkit.KryptonDateTimePicker DtpPlannedEndDate;
    }
}