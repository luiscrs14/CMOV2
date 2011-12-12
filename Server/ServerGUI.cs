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
            this.propertiesBindingSource.MoveLast();
            this.propertiesBindingSource.EndEdit();
            DataTable recentChanges = ((Database1DataSet)this.propertiesBindingSource.DataSource).Properties.GetChanges(DataRowState.Added);
            String imageUrl = "";
            String city = "";
            String price = "";
            if (recentChanges != null)
            {
                for (int i = 0; i < recentChanges.Rows.Count; i++)
                {
                    String propType = recentChanges.Rows[i]["type"].ToString();
                    if (propType.Equals("Castle"))
                    {
                        
                        imageUrl = "castle.png";
                    }
                    else if (propType.Equals("Flat"))
                    {
                        
                         imageUrl = "flat.png";
                    }
                    else if (propType.Equals("House"))
                    {
                        
                        imageUrl = "house.png";
                    }
                    Console.WriteLine(propType);

                    city = recentChanges.Rows[i]["city"].ToString();
                    price = recentChanges.Rows[i]["price"].ToString();
                }
            }
            int changes = this.tableAdapterManager.UpdateAll(this.database1DataSet);

           
            Database1DataSetTableAdapters.UsersTableAdapter uta = new Database1DataSetTableAdapters.UsersTableAdapter();
            this.usersTableAdapter = new Database1DataSetTableAdapters.UsersTableAdapter();
            this.usersTableAdapter.Fill(database1DataSet.Users);
            foreach (DataRow row in database1DataSet.Users.Rows)
            {
                foreach(DataRow newHouse in recentChanges.Rows)
                {
                    int relInserted = users_PropertiesTableAdapter.Insert(Convert.ToInt32(row["id"]), Convert.ToInt32(newHouse["id"]));
                    Console.WriteLine("Relations created: " + relInserted);
                    this.database1DataSet.AcceptChanges();
                    this.users_PropertiesTableAdapter.Update(this.database1DataSet.Users_Properties);
                }
            }
            this.users_PropertiesTableAdapter = new Database1DataSetTableAdapters.Users_PropertiesTableAdapter();
            this.users_PropertiesTableAdapter.Fill(database1DataSet.Users_Properties);
            
            ImageService imgserv = new ImageService();
            byte[] tile = imgserv.PrepareTile(changes, city + " " + price + "€",imageUrl);
            byte[] toast = imgserv.PrepareToast(city, price+"€");
            imgserv.SendNotfication(1, tile);
            imgserv.SendNotfication(2, toast);
            Console.WriteLine("changes: " + changes);

        }

        private void ServerGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.Users);
            // TODO: This line of code loads data into the 'database1DataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.database1DataSet.Properties);
            // TODO: This line of code loads data into the 'database1DataSet.Users_Properties' table. You can move, or remove it, as needed.
            this.users_PropertiesTableAdapter.Fill(this.database1DataSet.Users_Properties);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openf = new OpenFileDialog();
            openf.Filter = "PNG files|*.png";
            if (openf.ShowDialog() == DialogResult.OK)
            {
                imageTextBox.Text = openf.FileName;
            }
        }
    }
}
