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
    public partial class PolitaNoua : Form
    {
        public PolitaNoua()
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
            if(rbtn1.Checked==false && rbtn2.Checked==false)
            {
                    MessageBox.Show("Alegeti tipul asigurarii!");
            }
            else if (rbtn1.Checked == true && rbtn2.Checked == true)
            {
                MessageBox.Show("Alegeti tipul asigurarii!");
            }
            else if (rbtn1.Checked == true && rbtn2.Checked == false)
            { int sumaAuto;
                sumaAuto = 400 + Int32.Parse(tb1.Text) * 10;
                MessageBox.Show("Suma platita: "+sumaAuto);
                ok = 1;
            }
            else
            {
                int sumaViata;
                sumaViata = 700 + Int32.Parse(tb1.Text)*12;
                MessageBox.Show("Suma platita: "+sumaViata);
                ok = 1;

            }
        }
        int ok = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Tranzactie confirmata!",new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(10, 10));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ok==1)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
    }
}
