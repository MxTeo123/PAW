namespace ProiectPaw
{
    partial class clientNou
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ms1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaODaunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtnume = new System.Windows.Forms.TextBox();
            this.txtprenume = new System.Windows.Forms.TextBox();
            this.txtmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms1,
            this.notificaODaunaToolStripMenuItem,
            this.inchidereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ms1
            // 
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(75, 20);
            this.ms1.Text = "&Despre noi";
            this.ms1.Click += new System.EventHandler(this.ms1_Click);
            // 
            // notificaODaunaToolStripMenuItem
            // 
            this.notificaODaunaToolStripMenuItem.Name = "notificaODaunaToolStripMenuItem";
            this.notificaODaunaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.notificaODaunaToolStripMenuItem.Text = "&Notifica o dauna";
            this.notificaODaunaToolStripMenuItem.Click += new System.EventHandler(this.notificaODaunaToolStripMenuItem_Click);
            // 
            // inchidereToolStripMenuItem
            // 
            this.inchidereToolStripMenuItem.Name = "inchidereToolStripMenuItem";
            this.inchidereToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.inchidereToolStripMenuItem.Text = "&Inchidere";
            this.inchidereToolStripMenuItem.Click += new System.EventHandler(this.inchidereToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Nume";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(59, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "email";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(59, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Text = "Prenume";
            // 
            // txtnume
            // 
            this.txtnume.Location = new System.Drawing.Point(111, 77);
            this.txtnume.Name = "txtnume";
            this.txtnume.Size = new System.Drawing.Size(100, 20);
            this.txtnume.TabIndex = 7;
            // 
            // txtprenume
            // 
            this.txtprenume.Location = new System.Drawing.Point(111, 127);
            this.txtprenume.Name = "txtprenume";
            this.txtprenume.Size = new System.Drawing.Size(100, 20);
            this.txtprenume.TabIndex = 8;
            // 
            // txtmail
            // 
            this.txtmail.Location = new System.Drawing.Point(111, 176);
            this.txtmail.Name = "txtmail";
            this.txtmail.Size = new System.Drawing.Size(100, 20);
            this.txtmail.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(111, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Inregistreaza-te";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtparola
            // 
            this.txtparola.Location = new System.Drawing.Point(111, 218);
            this.txtparola.Name = "txtparola";
            this.txtparola.PasswordChar = '*';
            this.txtparola.Size = new System.Drawing.Size(100, 20);
            this.txtparola.TabIndex = 12;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(27, 218);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(59, 20);
            this.textBox8.TabIndex = 11;
            this.textBox8.Text = "parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Creeare cont nou";
            // 
            // clientNou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtparola);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmail);
            this.Controls.Add(this.txtprenume);
            this.Controls.Add(this.txtnume);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "clientNou";
            this.Text = "clientNou";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ms1;
        private System.Windows.Forms.ToolStripMenuItem notificaODaunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchidereToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtnume;
        private System.Windows.Forms.TextBox txtprenume;
        private System.Windows.Forms.TextBox txtmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
    }
}