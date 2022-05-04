
namespace LibraryManagement
{
    partial class ReturnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IssueDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.Bookcb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StdCb = new System.Windows.Forms.ComboBox();
            this.PhoneTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stddepmntTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.stdnameTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReturnNumTb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.IssueBookDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.ReturnBookDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BurlyWood;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 763);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 12);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 89);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1025, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(347, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "RETURN BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(184, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // IssueDate
            // 
            this.IssueDate.Checked = true;
            this.IssueDate.FillColor = System.Drawing.Color.White;
            this.IssueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.IssueDate.Location = new System.Drawing.Point(171, 428);
            this.IssueDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.IssueDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(209, 30);
            this.IssueDate.TabIndex = 66;
            this.IssueDate.Value = new System.DateTime(2022, 4, 29, 22, 21, 10, 923);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label9.Location = new System.Drawing.Point(32, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 65;
            this.label9.Text = "Issue";
            // 
            // Bookcb
            // 
            this.Bookcb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookcb.FormattingEnabled = true;
            this.Bookcb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Bookcb.Location = new System.Drawing.Point(169, 377);
            this.Bookcb.Name = "Bookcb";
            this.Bookcb.Size = new System.Drawing.Size(205, 29);
            this.Bookcb.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label8.Location = new System.Drawing.Point(28, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 23);
            this.label8.TabIndex = 63;
            this.label8.Text = "Book";
            // 
            // StdCb
            // 
            this.StdCb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdCb.FormattingEnabled = true;
            this.StdCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.StdCb.Location = new System.Drawing.Point(169, 176);
            this.StdCb.Name = "StdCb";
            this.StdCb.Size = new System.Drawing.Size(209, 29);
            this.StdCb.TabIndex = 62;
            // 
            // PhoneTb
            // 
            this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneTb.DefaultText = "";
            this.PhoneTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneTb.Location = new System.Drawing.Point(169, 327);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.PasswordChar = '\0';
            this.PhoneTb.PlaceholderText = "";
            this.PhoneTb.SelectedText = "";
            this.PhoneTb.Size = new System.Drawing.Size(209, 30);
            this.PhoneTb.TabIndex = 61;
            this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Location = new System.Drawing.Point(28, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Phone";
            // 
            // stddepmntTb
            // 
            this.stddepmntTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stddepmntTb.DefaultText = "";
            this.stddepmntTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stddepmntTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stddepmntTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stddepmntTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stddepmntTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stddepmntTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stddepmntTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stddepmntTb.Location = new System.Drawing.Point(169, 278);
            this.stddepmntTb.Name = "stddepmntTb";
            this.stddepmntTb.PasswordChar = '\0';
            this.stddepmntTb.PlaceholderText = "";
            this.stddepmntTb.SelectedText = "";
            this.stddepmntTb.Size = new System.Drawing.Size(209, 30);
            this.stddepmntTb.TabIndex = 59;
            this.stddepmntTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label7.Location = new System.Drawing.Point(28, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Department";
            // 
            // stdnameTb
            // 
            this.stdnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stdnameTb.DefaultText = "";
            this.stdnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stdnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stdnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stdnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdnameTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stdnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stdnameTb.Location = new System.Drawing.Point(169, 225);
            this.stdnameTb.Name = "stdnameTb";
            this.stdnameTb.PasswordChar = '\0';
            this.stdnameTb.PlaceholderText = "";
            this.stdnameTb.SelectedText = "";
            this.stdnameTb.Size = new System.Drawing.Size(209, 30);
            this.stdnameTb.TabIndex = 57;
            this.stdnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Location = new System.Drawing.Point(28, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 56;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(28, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "NUM";
            // 
            // ReturnNumTb
            // 
            this.ReturnNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReturnNumTb.DefaultText = "";
            this.ReturnNumTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReturnNumTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReturnNumTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReturnNumTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReturnNumTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReturnNumTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnNumTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReturnNumTb.Location = new System.Drawing.Point(169, 129);
            this.ReturnNumTb.Name = "ReturnNumTb";
            this.ReturnNumTb.PasswordChar = '\0';
            this.ReturnNumTb.PlaceholderText = "";
            this.ReturnNumTb.SelectedText = "";
            this.ReturnNumTb.Size = new System.Drawing.Size(209, 30);
            this.ReturnNumTb.TabIndex = 54;
            this.ReturnNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Location = new System.Drawing.Point(28, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "USN";
            // 
            // ReturnDate
            // 
            this.ReturnDate.Checked = true;
            this.ReturnDate.FillColor = System.Drawing.Color.White;
            this.ReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ReturnDate.Location = new System.Drawing.Point(171, 477);
            this.ReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.Size = new System.Drawing.Size(209, 30);
            this.ReturnDate.TabIndex = 68;
            this.ReturnDate.Value = new System.DateTime(2022, 4, 29, 22, 21, 10, 923);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label10.Location = new System.Drawing.Point(32, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Return";
            // 
            // IssueBookDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.IssueBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssueBookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssueBookDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.IssueBookDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IssueBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.IssueBookDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IssueBookDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.IssueBookDataGridView.EnableHeadersVisualStyles = false;
            this.IssueBookDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDataGridView.Location = new System.Drawing.Point(414, 135);
            this.IssueBookDataGridView.Name = "IssueBookDataGridView";
            this.IssueBookDataGridView.RowHeadersVisible = false;
            this.IssueBookDataGridView.RowHeadersWidth = 62;
            this.IssueBookDataGridView.RowTemplate.Height = 30;
            this.IssueBookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IssueBookDataGridView.Size = new System.Drawing.Size(646, 256);
            this.IssueBookDataGridView.TabIndex = 69;
            this.IssueBookDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.IssueBookDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.IssueBookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.IssueBookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.IssueBookDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.BurlyWood;
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.IssueBookDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.IssueBookDataGridView.ThemeStyle.ReadOnly = false;
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.IssueBookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IssueBookDataGridView_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Location = new System.Drawing.Point(596, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 28);
            this.label11.TabIndex = 70;
            this.label11.Text = "Books Issued";
            // 
            // ReturnBookDataGridView
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ReturnBookDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnBookDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnBookDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnBookDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnBookDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ReturnBookDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnBookDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.ReturnBookDataGridView.EnableHeadersVisualStyles = false;
            this.ReturnBookDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookDataGridView.Location = new System.Drawing.Point(414, 448);
            this.ReturnBookDataGridView.Name = "ReturnBookDataGridView";
            this.ReturnBookDataGridView.RowHeadersVisible = false;
            this.ReturnBookDataGridView.RowHeadersWidth = 62;
            this.ReturnBookDataGridView.RowTemplate.Height = 30;
            this.ReturnBookDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnBookDataGridView.Size = new System.Drawing.Size(646, 256);
            this.ReturnBookDataGridView.TabIndex = 71;
            this.ReturnBookDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReturnBookDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReturnBookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReturnBookDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReturnBookDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.BurlyWood;
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReturnBookDataGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.ReturnBookDataGridView.ThemeStyle.ReadOnly = false;
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnBookDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label12.Location = new System.Drawing.Point(596, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 28);
            this.label12.TabIndex = 72;
            this.label12.Text = "Books Returned";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.BurlyWood;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(150, 670);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 37);
            this.button4.TabIndex = 76;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.BurlyWood;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(651, 718);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 37);
            this.button2.TabIndex = 74;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BurlyWood;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(96, 607);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 37);
            this.button1.TabIndex = 73;
            this.button1.Text = "Return Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 775);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ReturnBookDataGridView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IssueBookDataGridView);
            this.Controls.Add(this.ReturnDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Bookcb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StdCb);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stddepmntTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stdnameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnNumTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnForm";
            this.Load += new System.EventHandler(this.ReturnForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnBookDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker IssueDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Bookcb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StdCb;
        private Guna.UI2.WinForms.Guna2TextBox PhoneTb;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox stddepmntTb;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox stdnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ReturnNumTb;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker ReturnDate;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView IssueBookDataGridView;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DataGridView ReturnBookDataGridView;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}