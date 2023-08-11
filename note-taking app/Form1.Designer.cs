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
            this.roundedButton2 = new note_taking_app.classes.RoundedButton();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.ForeColor = System.Drawing.Color.White;
            this.roundedButton2.Location = new System.Drawing.Point(405, 12);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(358, 65);
            this.roundedButton2.TabIndex = 0;
            this.roundedButton2.Text = "Salveaza Notita!";
            this.roundedButton2.UseVisualStyleBackColor = false;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(12, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(387, 514);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // note_taking
            // 
            this.ClientSize = new System.Drawing.Size(775, 538);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.roundedButton2);
            this.Name = "note_taking";
            this.Load += new System.EventHandler(this.note_taking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private classes.RoundedButton roundedButton1;
        private classes.RoundedButton roundedButton2;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

