using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProiectPaw
{
    public partial class clientNou : Form
    {

        string path = @"Data Source=DESKTOP-MLMHMB5;Initial Catalog=clientNou;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;

        public clientNou()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void ms1_Click(object sender, EventArgs e)
        {
            despreNoi f2 = new despreNoi();
            f2.ShowDialog();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            
           if(txtnume.Text==""||txtprenume.Text==""||txtmail.Text==""||txtparola.Text=="")
            {
                MessageBox.Show("Completati toate campurile!");
            }
           else
            {
                try
                {
                    con.Open();
                    cmd = new SqlCommand("insert into Clienti (nume,prenume,adresa,parola) values ('" + txtnume.Text + "','" + txtprenume.Text + "','" + txtmail.Text + "','" + txtparola.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Datele au fost salvate cu succes!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }
    }
}
