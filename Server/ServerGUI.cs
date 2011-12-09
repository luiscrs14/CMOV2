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
            int changes = this.tableAdapterManager.UpdateAll(this.database1DataSet);
            ImageService imgserv = new ImageService();
            byte[] notification = imgserv.PrepareTile(changes, "New notification");
            imgserv.mandavir(1, notification);
            Console.WriteLine("changes: " + changes);
        }

        private void ServerGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.database1DataSet.Properties);

        }
    }
}
