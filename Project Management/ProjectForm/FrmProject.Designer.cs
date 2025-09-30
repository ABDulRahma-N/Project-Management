namespace Project_Management
{
    partial class FrmProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.ProjectDataView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataView)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.BorderRadius = 9;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.guna2TileButton2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Location = new System.Drawing.Point(1545, 32);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(295, 99);
            this.guna2TileButton2.TabIndex = 2;
            this.guna2TileButton2.Text = "Add new project";
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // ProjectDataView
            // 
            this.ProjectDataView.AllowUserToAddRows = false;
            this.ProjectDataView.AllowUserToDeleteRows = false;
            this.ProjectDataView.AllowUserToOrderColumns = true;
            this.ProjectDataView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ProjectDataView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProjectDataView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDataView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProjectDataView.ColumnHeadersHeight = 34;
            this.ProjectDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProjectDataView.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProjectDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProjectDataView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProjectDataView.Location = new System.Drawing.Point(12, 234);
            this.ProjectDataView.Name = "ProjectDataView";
            this.ProjectDataView.ReadOnly = true;
            this.ProjectDataView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProjectDataView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProjectDataView.RowHeadersVisible = false;
            this.ProjectDataView.RowHeadersWidth = 82;
            this.ProjectDataView.RowTemplate.Height = 33;
            this.ProjectDataView.Size = new System.Drawing.Size(1884, 445);
            this.ProjectDataView.TabIndex = 3;
            this.ProjectDataView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProjectDataView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDataView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ProjectDataView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            this.ProjectDataView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ProjectDataView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProjectDataView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProjectDataView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ProjectDataView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProjectDataView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDataView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProjectDataView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProjectDataView.ThemeStyle.HeaderStyle.Height = 34;
            this.ProjectDataView.ThemeStyle.ReadOnly = true;
            this.ProjectDataView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProjectDataView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProjectDataView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDataView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProjectDataView.ThemeStyle.RowsStyle.Height = 33;
            this.ProjectDataView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(202)))), ((int)(((byte)(245)))));
            this.ProjectDataView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ProjectDataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectDataView_CellContentClick);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.deToolStripMenuItem});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(301, 162);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(300, 38);
            this.deToolStripMenuItem.Text = "Details";
            this.deToolStripMenuItem.Click += new System.EventHandler(this.deToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 60);
            this.label1.TabIndex = 4;
            this.label1.Text = "Projects";
            // 
            // FrmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1940, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProjectDataView);
            this.Controls.Add(this.guna2TileButton2);
            this.Name = "FrmProject";
            this.Text = "FrmProject";
            this.Load += new System.EventHandler(this.FrmProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectDataView)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private Guna.UI2.WinForms.Guna2DataGridView ProjectDataView;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}