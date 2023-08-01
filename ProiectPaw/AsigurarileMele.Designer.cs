namespace ProiectPaw
{
    partial class AsigurarileMele
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
            this.despreNoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificaODaunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchidereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreNoiToolStripMenuItem,
            this.notificaODaunaToolStripMenuItem,
            this.inchidereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // despreNoiToolStripMenuItem
            // 
            this.despreNoiToolStripMenuItem.Name = "despreNoiToolStripMenuItem";
            this.despreNoiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.despreNoiToolStripMenuItem.Text = "Despre noi";
            this.despreNoiToolStripMenuItem.Click += new System.EventHandler(this.despreNoiToolStripMenuItem_Click);
            // 
            // notificaODaunaToolStripMenuItem
            // 
            this.notificaODaunaToolStripMenuItem.Name = "notificaODaunaToolStripMenuItem";
            this.notificaODaunaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.notificaODaunaToolStripMenuItem.Text = "Notifica o dauna";
            this.notificaODaunaToolStripMenuItem.Click += new System.EventHandler(this.notificaODaunaToolStripMenuItem_Click);
            // 
            // inchidereToolStripMenuItem
            // 
            this.inchidereToolStripMenuItem.Name = "inchidereToolStripMenuItem";
            this.inchidereToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.inchidereToolStripMenuItem.Text = "Inchidere";
            this.inchidereToolStripMenuItem.Click += new System.EventHandler(this.inchidereToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nu aveti nicio polita!";
            // 
            // AsigurarileMele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AsigurarileMele";
            this.Text = "AsigurarileMele";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem despreNoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificaODaunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchidereToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}