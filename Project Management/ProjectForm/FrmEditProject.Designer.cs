namespace Project_Management
{
    partial class FrmEditProject
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
            this.DtpPlannedEndDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.DtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.BSave = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // DtpPlannedEndDate
            // 
            this.DtpPlannedEndDate.Location = new System.Drawing.Point(520, 507);
            this.DtpPlannedEndDate.Name = "DtpPlannedEndDate";
            this.DtpPlannedEndDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpPlannedEndDate.Size = new System.Drawing.Size(596, 50);
            this.DtpPlannedEndDate.StateCommon.Content.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpPlannedEndDate.TabIndex = 22;
            this.DtpPlannedEndDate.ValueChanged += new System.EventHandler(this.DtpPlannedEndDate_ValueChanged);
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(520, 409);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpStartDate.Size = new System.Drawing.Size(596, 50);
            this.DtpStartDate.StateCommon.Content.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDate.TabIndex = 21;
            this.DtpStartDate.ValueChanged += new System.EventHandler(this.DtpStartDate_ValueChanged);
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
            this.guna2Button3.Location = new System.Drawing.Point(197, 653);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(304, 93);
            this.guna2Button3.TabIndex = 20;
            this.guna2Button3.Text = "Cancel";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // BSave
            // 
            this.BSave.BorderRadius = 15;
            this.BSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BSave.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.BSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BSave.ForeColor = System.Drawing.Color.Black;
            this.BSave.Location = new System.Drawing.Point(750, 653);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(304, 93);
            this.BSave.TabIndex = 19;
            this.BSave.Text = "Save";
            this.BSave.Click += new System.EventHandler(this.BSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Planned End Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 45);
            this.label3.TabIndex = 17;
            this.label3.Text = "Start Date";
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
            this.TbDescription.Location = new System.Drawing.Point(520, 132);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.PlaceholderText = "";
            this.TbDescription.SelectedText = "";
            this.TbDescription.Size = new System.Drawing.Size(596, 141);
            this.TbDescription.TabIndex = 16;
            this.TbDescription.TextChanged += new System.EventHandler(this.TbDescription_TextChanged);
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
            this.TbName.Location = new System.Drawing.Point(520, 40);
            this.TbName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbName.Name = "TbName";
            this.TbName.PlaceholderText = "";
            this.TbName.SelectedText = "";
            this.TbName.Size = new System.Drawing.Size(596, 51);
            this.TbName.TabIndex = 15;
            this.TbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(176, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Project Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 45);
            this.label6.TabIndex = 25;
            this.label6.Text = "Status";
            // 
            // CbStatus
            // 
            this.CbStatus.BackColor = System.Drawing.Color.Transparent;
            this.CbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbStatus.ForeColor = System.Drawing.Color.Black;
            this.CbStatus.ItemHeight = 30;
            this.CbStatus.Items.AddRange(new object[] {
            "On Hold",
            "In Progress",
            "Completed"});
            this.CbStatus.Location = new System.Drawing.Point(520, 311);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(596, 36);
            this.CbStatus.TabIndex = 27;
            this.CbStatus.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // FrmEditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 795);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtpPlannedEndDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditProject";
            this.Text = "FrmEditProject";
            this.Load += new System.EventHandler(this.FrmEditProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDateTimePicker DtpPlannedEndDate;
        private Krypton.Toolkit.KryptonDateTimePicker DtpStartDate;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button BSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TbDescription;
        private Guna.UI2.WinForms.Guna2TextBox TbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CbStatus;
    }
}