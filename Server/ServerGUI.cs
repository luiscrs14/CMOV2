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
                }
            }
            int changes = this.tableAdapterManager.UpdateAll(this.database1DataSet);
            Database1DataSetTableAdapters.UsersTableAdapter usertb = new Database1DataSetTableAdapters.UsersTableAdapter();
            usertb.Fill(this.database1DataSet.Users);
            //aceder ao tipo aqui, fazer isto para todas as alterações
            
            foreach(DataRow row in this.database1DataSet.Users.Rows)
            {
                foreach(DataRow newHouse in recentChanges.Rows)
                {

                   // DataRow dt = this.database1DataSet.Users_Properties.NewUsers_PropertiesRow();   
                    int coiso = users_PropertiesTableAdapter.Insert(Convert.ToInt32(row["id"]), Convert.ToInt32(newHouse["id"]));
                  //  dt["idU"] = Convert.ToInt32(row["id"]);
                   // dt["idP"] = Convert.ToInt32(newHouse["id"]);
                    //this.database1DataSet.Users_Properties.Rows.Add(dt);
                    //upTA.Insert(Convert.ToInt32(row["id"]), Convert.ToInt32(newHouse["id"]));
                    Console.WriteLine("Cenas: " + coiso);
                    this.database1DataSet.AcceptChanges();
                    this.users_PropertiesTableAdapter.Update(this.database1DataSet.Users_Properties);
                    
                  // int dt =dataset.Users_Properties.GetChanges().Rows.Count;
                    //int usersc = this.database1DataSet.Users.GetChanges().Rows.Count;
                   // int propsc = this.database1DataSet.Properties.GetChanges().Rows.Count;
                     //   Console.WriteLine(" ola: " + "  " + usersc + "  " + propsc );
                }
            }
            
           //int asd= this.tableAdapterManager.UpdateAll(this.database1DataSet);
           //Console.WriteLine("as: " + asd);
            
            ImageService imgserv = new ImageService();
            byte[] notification = imgserv.PrepareTile(changes, "New notification",imageUrl);
            imgserv.SendNotfication(1, notification);
            Console.WriteLine("changes: " + changes);

        }

        private void ServerGUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users_Properties' table. You can move, or remove it, as needed.
            this.users_PropertiesTableAdapter.Fill(this.database1DataSet.Users_Properties);
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
