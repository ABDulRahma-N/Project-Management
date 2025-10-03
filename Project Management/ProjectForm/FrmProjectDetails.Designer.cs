namespace Project_Management
{
    partial class FrmProjectDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LProjectName = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShapStatus = new Guna.UI2.WinForms.Guna2Shapes();
            this.guna2ShapesTool1 = new Guna.UI2.WinForms.Guna2ShapesTool(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LStartDate = new System.Windows.Forms.Label();
            this.LPlannedEndDAte = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.LActualEndDate = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.LDescription = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.DgvProjectDetails = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // LProjectName
            // 
            this.LProjectName.AutoSize = true;
            this.LProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LProjectName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LProjectName.Location = new System.Drawing.Point(266, 62);
            this.LProjectName.Name = "LProjectName";
            this.LProjectName.Size = new System.Drawing.Size(105, 45);
            this.LProjectName.TabIndex = 1;
            this.LProjectName.Text = "Name";
            // 
            // LStatus
            // 
            this.LStatus.AutoSize = true;
            this.LStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStatus.Location = new System.Drawing.Point(1627, 62);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(105, 45);
            this.LStatus.TabIndex = 2;
            this.LStatus.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Project Name :";
            // 
            // ShapStatus
            // 
            this.ShapStatus.BorderColor = System.Drawing.Color.Yellow;
            this.ShapStatus.FillColor = System.Drawing.Color.Yellow;
            this.ShapStatus.LineStartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            this.ShapStatus.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.ShapStatus.Location = new System.Drawing.Point(1821, 62);
            this.ShapStatus.Margin = new System.Windows.Forms.Padding(6);
            this.ShapStatus.Name = "ShapStatus";
            this.ShapStatus.PolygonSides = 3;
            this.ShapStatus.PolygonSkip = 1;
            this.ShapStatus.Rotate = 0F;
            this.ShapStatus.Shape = Guna.UI2.WinForms.Enums.ShapeType.Ellipse;
            this.ShapStatus.Size = new System.Drawing.Size(41, 40);
            this.ShapStatus.TabIndex = 6;
            this.ShapStatus.Text = "guna2Shapes1";
            this.ShapStatus.Zoom = 80;
            this.ShapStatus.Click += new System.EventHandler(this.guna2Shapes1_Click);
            // 
            // guna2ShapesTool1
            // 
            this.guna2ShapesTool1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ShapesTool1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShapesTool1.PolygonSkip = 1;
            this.guna2ShapesTool1.Rotate = 0F;
            this.guna2ShapesTool1.Size = new System.Drawing.Size(200, 200);
            this.guna2ShapesTool1.TargetControl = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(619, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Date :";
            // 
            // LStartDate
            // 
            this.LStartDate.AutoSize = true;
            this.LStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LStartDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStartDate.Location = new System.Drawing.Point(812, 62);
            this.LStartDate.Name = "LStartDate";
            this.LStartDate.Size = new System.Drawing.Size(175, 45);
            this.LStartDate.TabIndex = 10;
            this.LStartDate.Text = "StartDate";
            // 
            // LPlannedEndDAte
            // 
            this.LPlannedEndDAte.AutoSize = true;
            this.LPlannedEndDAte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LPlannedEndDAte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPlannedEndDAte.Location = new System.Drawing.Point(926, 142);
            this.LPlannedEndDAte.Name = "LPlannedEndDAte";
            this.LPlannedEndDAte.Size = new System.Drawing.Size(286, 45);
            this.LPlannedEndDAte.TabIndex = 11;
            this.LPlannedEndDAte.Text = "LPlannedEndDAte";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Black;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(619, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(301, 45);
            this.label5.TabIndex = 7;
            this.label5.Text = "Planned End Date :";
            // 
            // LActualEndDate
            // 
            this.LActualEndDate.AutoSize = true;
            this.LActualEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LActualEndDate.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LActualEndDate.Location = new System.Drawing.Point(1417, 142);
            this.LActualEndDate.Name = "LActualEndDate";
            this.LActualEndDate.Size = new System.Drawing.Size(294, 45);
            this.LActualEndDate.TabIndex = 12;
            this.LActualEndDate.Text = "Actual End Date : ";
            this.LActualEndDate.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoRoundedCorners = true;
            this.guna2Panel1.Controls.Add(this.LDescription);
            this.guna2Panel1.Location = new System.Drawing.Point(28, 203);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(576, 249);
            this.guna2Panel1.TabIndex = 13;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // LDescription
            // 
            this.LDescription.AutoSize = true;
            this.LDescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LDescription.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescription.Location = new System.Drawing.Point(3, 15);
            this.LDescription.Name = "LDescription";
            this.LDescription.Size = new System.Drawing.Size(105, 45);
            this.LDescription.TabIndex = 10;
            this.LDescription.Text = "Name";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1585, 203);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(302, 91);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Edit Project";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // DgvProjectDetails
            // 
            this.DgvProjectDetails.AllowUserToAddRows = false;
            this.DgvProjectDetails.AllowUserToDeleteRows = false;
            this.DgvProjectDetails.AllowUserToOrderColumns = true;
            this.DgvProjectDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.DgvProjectDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.DgvProjectDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.DgvProjectDetails.ColumnHeadersHeight = 34;
            this.DgvProjectDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProjectDetails.DefaultCellStyle = dataGridViewCellStyle23;
            this.DgvProjectDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvProjectDetails.Location = new System.Drawing.Point(28, 488);
            this.DgvProjectDetails.Name = "DgvProjectDetails";
            this.DgvProjectDetails.ReadOnly = true;
            this.DgvProjectDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DgvProjectDetails.RowHeadersVisible = false;
            this.DgvProjectDetails.RowHeadersWidth = 82;
            this.DgvProjectDetails.RowTemplate.Height = 33;
            this.DgvProjectDetails.Size = new System.Drawing.Size(1884, 445);
            this.DgvProjectDetails.TabIndex = 15;
            this.DgvProjectDetails.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvProjectDetails.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProjectDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DgvProjectDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            this.DgvProjectDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DgvProjectDetails.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgvProjectDetails.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgvProjectDetails.ThemeStyle.HeaderStyle.Height = 34;
            this.DgvProjectDetails.ThemeStyle.ReadOnly = true;
            this.DgvProjectDetails.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgvProjectDetails.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProjectDetails.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgvProjectDetails.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgvProjectDetails.ThemeStyle.RowsStyle.Height = 33;
            this.DgvProjectDetails.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            this.DgvProjectDetails.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // FrmProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(2065, 956);
            this.Controls.Add(this.DgvProjectDetails);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.LActualEndDate);
            this.Controls.Add(this.LPlannedEndDAte);
            this.Controls.Add(this.LStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ShapStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LProjectName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProjectDetails";
            this.Text = "FrmProjectDetails";
            this.Load += new System.EventHandler(this.FrmProjectDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LProjectName;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Shapes ShapStatus;
        private Guna.UI2.WinForms.Guna2ShapesTool guna2ShapesTool1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LStartDate;
        private System.Windows.Forms.Label LPlannedEndDAte;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label LActualEndDate;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label LDescription;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView DgvProjectDetails;
    }
}