namespace note_taking_app
{
    partial class note_taking
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new note_taking_app.classes.RoundedButton();
            this.roundedButton4 = new note_taking_app.classes.RoundedButton();
            this.roundedButton3 = new note_taking_app.classes.RoundedButton();
            this.roundedButton2 = new note_taking_app.classes.RoundedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addImageButton = new note_taking_app.classes.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 35);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(387, 136);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(467, 89);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TodayDate = new System.DateTime(2023, 8, 13, 0, 0, 0, 0);
            this.monthCalendar1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(387, 349);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aici scrieti notitele!";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(405, 336);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(358, 65);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.ForeColor = System.Drawing.Color.White;
            this.roundedButton4.Location = new System.Drawing.Point(405, 89);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(358, 65);
            this.roundedButton4.TabIndex = 5;
            this.roundedButton4.Text = "Sterge notite!";
            this.roundedButton4.UseVisualStyleBackColor = false;
            this.roundedButton4.Click += new System.EventHandler(this.roundedButton4_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.ForeColor = System.Drawing.Color.White;
            this.roundedButton3.Location = new System.Drawing.Point(588, 12);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(175, 65);
            this.roundedButton3.TabIndex = 3;
            this.roundedButton3.Text = "Arata Calendar";
            this.roundedButton3.UseVisualStyleBackColor = false;
            this.roundedButton3.Click += new System.EventHandler(this.roundedButton3_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(405, 12);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(177, 65);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.Text = "Salveaza Notita!";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(769, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 437);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // addImageButton
            // 
            this.addImageButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addImageButton.FlatAppearance.BorderSize = 0;
            this.addImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImageButton.ForeColor = System.Drawing.Color.White;
            this.addImageButton.Location = new System.Drawing.Point(769, 12);
            this.addImageButton.Name = "addImageButton";
            this.addImageButton.Size = new System.Drawing.Size(441, 65);
            this.addImageButton.TabIndex = 9;
            this.addImageButton.Text = "Adauga imagine!";
            this.addImageButton.UseVisualStyleBackColor = false;
            this.addImageButton.Click += new System.EventHandler(this.addImageButton_Click);
            // 
            // note_taking
            // 
            this.ClientSize = new System.Drawing.Size(1222, 538);
            this.Controls.Add(this.addImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roundedButton4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.roundedButton3);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.roundedButton2);
            this.Name = "note_taking";
            this.Load += new System.EventHandler(this.note_taking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private classes.RoundedButton roundedButton1;
        private classes.RoundedButton roundedButton2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private classes.RoundedButton roundedButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private classes.RoundedButton roundedButton4;
        private System.Windows.Forms.Label label1;
        private classes.RoundedButton editButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private classes.RoundedButton addImageButton;
    }
}

