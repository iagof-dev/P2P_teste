using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P2P_teste
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profile_Load(object sender, EventArgs e)
        {
            if(preferencias.user_name != null)
                lbl_actualname.Text = "Nome atual: " + preferencias.user_name;
            txtbox_ip.Text = preferencias.server_ip;
            num_port.Value = preferencias.server_port;
        }

        private void btn_Saveall_Click(object sender, EventArgs e)
        {
            preferencias.user_name = txtbox_username.Text;
            preferencias.server_ip = txtbox_ip.Text;
            preferencias.server_port = (int)num_port.Value;
            MessageBox.Show("Salvo!");
        }
    }
}
