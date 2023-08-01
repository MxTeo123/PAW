namespace ProiectPaw
{
    partial class Form1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 0;
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
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn1.Location = new System.Drawing.Point(152, 170);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(209, 112);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Intra in cont";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn2.Location = new System.Drawing.Point(412, 170);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(209, 112);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Client Nou";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Control;
            this.btn3.Location = new System.Drawing.Point(255, 353);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(271, 33);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "Bine ati venit!";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Guardian Shield Asigurari";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label1;
    }
}

