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
    public partial class notificare : Form
    {
        public notificare()
        {
            InitializeComponent();
        }

        private void notificaODaunaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            notificare f2 = new notificare();
            f2.ShowDialog();

        }

        private void inchidereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ms1_Click(object sender, EventArgs e)
        {
            despreNoi f2 = new despreNoi();
            f2.ShowDialog();
           
        }
    }
}
