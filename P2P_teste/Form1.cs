using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace P2P_teste
{
    public partial class Form1 : Form
    {
        
        StreamReader sr;
        StreamWriter sw;
        TcpClient client;
        NetworkStream stream;
        TcpListener listener;

        public Form1()
        {
            InitializeComponent();
            preferencias.user_name = "User";
            preferencias.server_ip = "0.tcp.sa.ngrok.io";
            preferencias.server_port = 8080;
        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f_profile = new profile();
            f_profile.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (preferencias.server_ip == null || preferencias.server_port == null)
                return;
            if (preferencias.server_started)
            {
                txtbox_chat.AppendText($"{Environment.NewLine}Server stopped...");
                startToolStripMenuItem.Text = "Start";
                preferencias.server_started = false;
                connectToolStripMenuItem.Enabled = true;
            }
            else
            {
                connectToolStripMenuItem.Enabled = false;
                startToolStripMenuItem.Text = "Stop";
                TcpListener server = new TcpListener(IPAddress.Any, preferencias.server_port);
                txtbox_chat.AppendText($"Server started ({IPAddress.Any}:{preferencias.server_port})");
                preferencias.server_started = true;
            }
       
            
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtbox_chat.Clear();
            txtbox_chat.AppendText($"Connecting on ({preferencias.server_ip}:{preferencias.server_port})");
            try
            {
                client = new TcpClient(preferencias.server_ip, preferencias.server_port);
                stream = client.GetStream();
                sw = new StreamWriter(stream);
                sr = new StreamReader(stream);

                txtbox_chat.AppendText(Environment.NewLine);
                txtbox_chat.AppendText("Connected!\n");

            }
            catch (Exception ex)
            {
                txtbox_chat.AppendText(Environment.NewLine);
                txtbox_chat.AppendText("Unable to connect");
                txtbox_chat.AppendText(Environment.NewLine + ex.Message);
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txtbox_message.Text == null) return;
            if (!client.Connected) return;

            try
            {
                // Translate the passed message into ASCII and store it as a Byte array.
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(txtbox_message.Text);

                // Get a client stream for reading and writing.
                NetworkStream stream = client.GetStream();

                // Send the message to the connected TcpServer.
                stream.Write(data, 0, data.Length);
                txtbox_chat.AppendText(Environment.NewLine + $"{preferencias.user_name} : {txtbox_message.Text}");
                sw.Flush();
                txtbox_message.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
