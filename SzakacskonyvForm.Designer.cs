namespace CSHARP25052101
{
    partial class SzakacskonyvForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEtelek = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            colElkeszites = new DataGridViewTextBoxColumn();
            lblUI001 = new Label();
            txtKereses = new TextBox();
            pnlElkeszites = new Panel();
            rtbElkeszites = new RichTextBox();
            lblUI002 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEtelek).BeginInit();
            pnlElkeszites.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEtelek
            // 
            dgvEtelek.AllowUserToAddRows = false;
            dgvEtelek.AllowUserToDeleteRows = false;
            dgvEtelek.AllowUserToResizeRows = false;
            dgvEtelek.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEtelek.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEtelek.BackgroundColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.PaleVioletRed;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEtelek.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEtelek.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtelek.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, colElkeszites });
            dgvEtelek.Location = new Point(24, 68);
            dgvEtelek.MultiSelect = false;
            dgvEtelek.Name = "dgvEtelek";
            dgvEtelek.RowHeadersVisible = false;
            dgvEtelek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtelek.Size = new Size(929, 275);
            dgvEtelek.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 5F;
            Column1.HeaderText = "étel megnevezése";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.FillWeight = 2F;
            Column2.HeaderText = "elkészítési idő";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 3F;
            Column3.HeaderText = "kategória";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 4F;
            Column4.HeaderText = "alapanyag megnevezése";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.FillWeight = 2F;
            Column5.HeaderText = "mennyiség";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.FillWeight = 2F;
            Column6.HeaderText = "mennyiség egység";
            Column6.Name = "Column6";
            // 
            // colElkeszites
            // 
            colElkeszites.HeaderText = "elkészítés";
            colElkeszites.Name = "colElkeszites";
            colElkeszites.Visible = false;
            // 
            // lblUI001
            // 
            lblUI001.AutoSize = true;
            lblUI001.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI001.Location = new Point(24, 24);
            lblUI001.Margin = new Padding(15);
            lblUI001.Name = "lblUI001";
            lblUI001.Size = new Size(70, 21);
            lblUI001.TabIndex = 1;
            lblUI001.Text = "keresés:";
            // 
            // txtKereses
            // 
            txtKereses.Location = new Point(115, 21);
            txtKereses.Margin = new Padding(15);
            txtKereses.Name = "txtKereses";
            txtKereses.Size = new Size(838, 29);
            txtKereses.TabIndex = 2;
            // 
            // pnlElkeszites
            // 
            pnlElkeszites.BackColor = Color.PaleVioletRed;
            pnlElkeszites.Controls.Add(rtbElkeszites);
            pnlElkeszites.Controls.Add(lblUI002);
            pnlElkeszites.Location = new Point(24, 361);
            pnlElkeszites.Margin = new Padding(15);
            pnlElkeszites.Name = "pnlElkeszites";
            pnlElkeszites.Size = new Size(929, 180);
            pnlElkeszites.TabIndex = 3;
            // 
            // rtbElkeszites
            // 
            rtbElkeszites.BackColor = Color.LightPink;
            rtbElkeszites.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rtbElkeszites.Location = new Point(123, 30);
            rtbElkeszites.Margin = new Padding(15, 30, 30, 30);
            rtbElkeszites.Name = "rtbElkeszites";
            rtbElkeszites.Size = new Size(776, 120);
            rtbElkeszites.TabIndex = 2;
            rtbElkeszites.Text = "";
            // 
            // lblUI002
            // 
            lblUI002.AutoSize = true;
            lblUI002.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUI002.Location = new Point(15, 30);
            lblUI002.Margin = new Padding(15, 5, 5, 5);
            lblUI002.Name = "lblUI002";
            lblUI002.Size = new Size(88, 21);
            lblUI002.TabIndex = 1;
            lblUI002.Text = "elkészítés:";
            // 
            // SzakacskonyvForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(977, 553);
            Controls.Add(pnlElkeszites);
            Controls.Add(txtKereses);
            Controls.Add(lblUI001);
            Controls.Add(dgvEtelek);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "SzakacskonyvForm";
            Text = "Szakácskönyv";
            ((System.ComponentModel.ISupportInitialize)dgvEtelek).EndInit();
            pnlElkeszites.ResumeLayout(false);
            pnlElkeszites.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEtelek;
        private Label lblUI001;
        private TextBox txtKereses;
        private Panel pnlElkeszites;
        private Label lblUI002;
        private RichTextBox rtbElkeszites;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn colElkeszites;
    }
}
