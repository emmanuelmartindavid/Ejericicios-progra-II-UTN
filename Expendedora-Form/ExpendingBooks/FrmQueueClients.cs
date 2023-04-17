using Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine
{
    public partial class FrmQueueClients : Form
    {
        public Queue<string> clientQueue = new();
        ClientQueue client = new();
        public FrmQueueClients()
        {
            InitializeComponent();
        }

        private void btnLoadPeople_Click(object sender, EventArgs e)
        {
            clientQueue = client.LoadClientQueue(txtClienName.Text);
            lstClientQueue.Items.Clear();

            foreach (var client in clientQueue)
            {
                lstClientQueue.Items.Add(client);
            }
            txtClienName.Text = string.Empty;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
