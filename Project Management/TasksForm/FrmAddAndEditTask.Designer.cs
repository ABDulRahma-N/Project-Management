namespace Project_Management.TasksForm
{
    partial class FrmAddAndEditTask
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
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.BtSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.TbDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.TbTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtpPlannedEndDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.DtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CbProjectId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CbUserId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.LStatus = new System.Windows.Forms.Label();
            this.LIdtitil = new System.Windows.Forms.Label();
            this.LTaskID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 15;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(172, 899);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(230, 79);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "Cancel";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.BtSubmit.Location = new System.Drawing.Point(787, 899);
            this.BtSubmit.Name = "BtSubmit";
            this.BtSubmit.Size = new System.Drawing.Size(230, 79);
            this.BtSubmit.TabIndex = 15;
            this.BtSubmit.Text = "Submit";
            this.BtSubmit.Click += new System.EventHandler(this.BtSubmit_Click);
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
            this.TbDescription.Location = new System.Drawing.Point(475, 234);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbDescription.Multiline = true;
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.PlaceholderText = "";
            this.TbDescription.SelectedText = "";
            this.TbDescription.Size = new System.Drawing.Size(542, 163);
            this.TbDescription.TabIndex = 13;
            // 
            // TbTitle
            // 
            this.TbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbTitle.DefaultText = "";
            this.TbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TbTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TbTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TbTitle.Location = new System.Drawing.Point(475, 123);
            this.TbTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.PlaceholderText = "";
            this.TbTitle.SelectedText = "";
            this.TbTitle.Size = new System.Drawing.Size(542, 55);
            this.TbTitle.TabIndex = 12;
            this.TbTitle.TextChanged += new System.EventHandler(this.TbTitle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title";
            // 
            // DtpPlannedEndDate
            // 
            this.DtpPlannedEndDate.Location = new System.Drawing.Point(475, 546);
            this.DtpPlannedEndDate.Name = "DtpPlannedEndDate";
            this.DtpPlannedEndDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpPlannedEndDate.Size = new System.Drawing.Size(542, 37);
            this.DtpPlannedEndDate.TabIndex = 20;
            // 
            // DtpStartDate
            // 
            this.DtpStartDate.Location = new System.Drawing.Point(475, 453);
            this.DtpStartDate.Name = "DtpStartDate";
            this.DtpStartDate.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DtpStartDate.Size = new System.Drawing.Size(542, 37);
            this.DtpStartDate.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 45);
            this.label4.TabIndex = 18;
            this.label4.Text = "Planned End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 45);
            this.label3.TabIndex = 21;
            this.label3.Text = "Project ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 731);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 45);
            this.label6.TabIndex = 23;
            this.label6.Text = "User ID";
            // 
            // CbProjectId
            // 
            this.CbProjectId.AutoRoundedCorners = true;
            this.CbProjectId.BackColor = System.Drawing.Color.Transparent;
            this.CbProjectId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbProjectId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbProjectId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbProjectId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbProjectId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbProjectId.ForeColor = System.Drawing.Color.Black;
            this.CbProjectId.ItemHeight = 30;
            this.CbProjectId.Items.AddRange(new object[] {
            "Select Project ID"});
            this.CbProjectId.Location = new System.Drawing.Point(475, 639);
            this.CbProjectId.Name = "CbProjectId";
            this.CbProjectId.Size = new System.Drawing.Size(542, 36);
            this.CbProjectId.StartIndex = 0;
            this.CbProjectId.TabIndex = 25;
            this.CbProjectId.SelectedIndexChanged += new System.EventHandler(this.CbProjectId_SelectedIndexChanged);
            // 
            // CbUserId
            // 
            this.CbUserId.AutoRoundedCorners = true;
            this.CbUserId.BackColor = System.Drawing.Color.Transparent;
            this.CbUserId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbUserId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbUserId.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbUserId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbUserId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CbUserId.ForeColor = System.Drawing.Color.Black;
            this.CbUserId.ItemHeight = 30;
            this.CbUserId.Items.AddRange(new object[] {
            "Select User ID"});
            this.CbUserId.Location = new System.Drawing.Point(475, 731);
            this.CbUserId.Name = "CbUserId";
            this.CbUserId.Size = new System.Drawing.Size(542, 36);
            this.CbUserId.StartIndex = 0;
            this.CbUserId.TabIndex = 26;
            this.CbUserId.SelectedIndexChanged += new System.EventHandler(this.CbUserId_SelectedIndexChanged);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CbStatus
            // 
            this.CbStatus.AutoRoundedCorners = true;
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
            this.CbStatus.Location = new System.Drawing.Point(475, 823);
            this.CbStatus.Name = "CbStatus";
            this.CbStatus.Size = new System.Drawing.Size(542, 36);
            this.CbStatus.StartIndex = 0;
            this.CbStatus.TabIndex = 28;
            this.CbStatus.Visible = false;
            this.CbStatus.SelectedIndexChanged += new System.EventHandler(this.CbStatus_SelectedIndexChanged);
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStatus.Location = new System.Drawing.Point(164, 823);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(105, 45);
            this.LStatus.TabIndex = 27;
            this.LStatus.Text = "Statu";
            this.LStatus.Visible = false;
            // 
            // LIdtitil
            // 
            this.LIdtitil.AutoSize = true;
            this.LIdtitil.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIdtitil.Location = new System.Drawing.Point(164, 36);
            this.LIdtitil.Name = "LIdtitil";
            this.LIdtitil.Size = new System.Drawing.Size(141, 45);
            this.LIdtitil.TabIndex = 29;
            this.LIdtitil.Text = "Task ID";
            this.LIdtitil.Visible = false;
            // 
            // LTaskID
            // 
            this.LTaskID.AutoSize = true;
            this.LTaskID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTaskID.Location = new System.Drawing.Point(467, 36);
            this.LTaskID.Name = "LTaskID";
            this.LTaskID.Size = new System.Drawing.Size(141, 45);
            this.LTaskID.TabIndex = 30;
            this.LTaskID.Text = "Task ID";
            this.LTaskID.Visible = false;
            // 
            // FrmAddAndEditTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1186, 1058);
            this.Controls.Add(this.LTaskID);
            this.Controls.Add(this.LIdtitil);
            this.Controls.Add(this.CbStatus);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.CbUserId);
            this.Controls.Add(this.CbProjectId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtpPlannedEndDate);
            this.Controls.Add(this.DtpStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.BtSubmit);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddAndEditTask";
            this.Text = "FrmAddTask";
            this.Load += new System.EventHandler(this.FrmAddTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button BtSubmit;
        private Guna.UI2.WinForms.Guna2TextBox TbDescription;
        private Guna.UI2.WinForms.Guna2TextBox TbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonDateTimePicker DtpPlannedEndDate;
        private Krypton.Toolkit.KryptonDateTimePicker DtpStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox CbProjectId;
        private Guna.UI2.WinForms.Guna2ComboBox CbUserId;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox CbStatus;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LTaskID;
        private System.Windows.Forms.Label LIdtitil;
    }
}