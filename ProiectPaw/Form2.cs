using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectPaw
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void inchidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void notificaODaunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notificare f2 = new notificare();
            f2.ShowDialog();
        }

        private void despreNoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            despreNoi f2 = new despreNoi();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AsigurarileMele f2 = new AsigurarileMele();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PolitaNoua f2 = new PolitaNoua();
            f2.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panel1.BackColor = Color.Red;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
               panel1.BackColor = Color.Blue;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(files[0]);
        }
    }
}
