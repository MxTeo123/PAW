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
    public partial class ContulMeu : Form
    {SqlConnection con=new SqlConnection("Data Source=DESKTOP-MLMHMB5;Initial Catalog=clientNou;Integrated Security=True");
        public ContulMeu()
        {
            InitializeComponent();
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

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtmail.Text=="" && txtparola.Text=="")
                {
                    MessageBox.Show("completati tiate campurile!");
                }
                else 
                {
                    SqlCommand cmd = new SqlCommand("select * from Clienti where adresa=@adr and parola=@p", con);
                    cmd.Parameters.Add("@adr", txtmail.Text);
                    cmd.Parameters.Add("@p", txtparola.Text);
                    SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if(count ==1) 
                    {
                        MessageBox.Show("V-ati logat cu succes!");
                        Form2 f2 = new Form2();
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("username sau parola gresita!");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //SqlConnection con = new SqlConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientNou f1 = new clientNou();
            f1.ShowDialog();
        }
    }
}
