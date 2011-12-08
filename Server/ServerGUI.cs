using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMOVServer
{
    public partial class ServerGUI : Form
    {
        public ServerGUI()
        {
            InitializeComponent();
        }

        private void propertiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Server_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.database1DataSet.Properties);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dddTextBox.Text = openFileDialog1.FileName;
                //talvezno futuro se tenha que alterar para safefilename
            }
        }
    }
}
