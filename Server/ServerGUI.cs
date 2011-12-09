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
            bool castleChanges = false;
            bool flatChanges = false;
            bool houseChanges = false;
            this.Validate();
            this.propertiesBindingSource.MoveLast();
            this.propertiesBindingSource.EndEdit();
            DataTable recentChanges = ((Database1DataSet)this.propertiesBindingSource.DataSource).Properties.GetChanges(DataRowState.Added);
            String imageUrl = "";
            if (recentChanges != null)
            {
                for (int i = 0; i < recentChanges.Rows.Count; i++)
                {
                    String propType = recentChanges.Rows[i]["type"].ToString();
                    if (propType.Equals("Castle"))
                    {
                        castleChanges = true;
                        imageUrl = "castle.png";
                    }
                    else if (propType.Equals("Flat"))
                    {
                        flatChanges = true;
                         imageUrl = "flat.png";
                    }
                    else if (propType.Equals("House"))
                    {
                        houseChanges = true;
                        imageUrl = "house.png";
                    }
                    Console.WriteLine(propType);
                }
            }
            int changes = this.tableAdapterManager.UpdateAll(this.database1DataSet);
            //aceder ao tipo aqui, fazer isto para todas as alterações
           
            
            ImageService imgserv = new ImageService();
            byte[] notification = imgserv.PrepareTile(changes, "New notification",imageUrl);
            imgserv.mandavir(1, notification);
            Console.WriteLine("changes: " + changes);

        }

        private void ServerGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.Users);
            // TODO: This line of code loads data into the 'database1DataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.database1DataSet.Properties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.Filter = "PNG files|*.png";
            if (openf.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = openf.FileName;
                //.ImageLocation = openf.FileName;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bedroom_no_Label_Click(object sender, EventArgs e)
        {

        }

        private void bedroom_no_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bathroom_no_Label_Click(object sender, EventArgs e)
        {

        }

        private void bathroom_no_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void stateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void imageLabel_Click(object sender, EventArgs e)
        {

        }

        private void imageTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
