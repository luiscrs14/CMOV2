namespace CMOVServer
{
    partial class ServerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label bedroom_no_Label;
            System.Windows.Forms.Label bathroom_no_Label;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerGUI));
            this.database1DataSet = new CMOVServer.Database1DataSet();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.propertiesTableAdapter = new CMOVServer.Database1DataSetTableAdapters.PropertiesTableAdapter();
            this.tableAdapterManager = new CMOVServer.Database1DataSetTableAdapters.TableAdapterManager();
            this.propertiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.bedroom_no_TextBox = new System.Windows.Forms.TextBox();
            this.bathroom_no_TextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new CMOVServer.Database1DataSetTableAdapters.UsersTableAdapter();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            bedroom_no_Label = new System.Windows.Forms.Label();
            bathroom_no_Label = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).BeginInit();
            this.propertiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(44, 63);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 19;
            idLabel.Text = "id:";
            
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(44, 91);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(39, 17);
            typeLabel.TabIndex = 21;
            typeLabel.Text = "type:";
            
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(44, 122);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(63, 17);
            addressLabel.TabIndex = 23;
            addressLabel.Text = "address:";
            
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(44, 150);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(33, 17);
            cityLabel.TabIndex = 25;
            cityLabel.Text = "city:";
            
            // 
            // bedroom_no_Label
            // 
            bedroom_no_Label.AutoSize = true;
            bedroom_no_Label.Location = new System.Drawing.Point(44, 178);
            bedroom_no_Label.Name = "bedroom_no_Label";
            bedroom_no_Label.Size = new System.Drawing.Size(92, 17);
            bedroom_no_Label.TabIndex = 27;
            bedroom_no_Label.Text = "bedroom no :";
            
            // 
            // bathroom_no_Label
            // 
            bathroom_no_Label.AutoSize = true;
            bathroom_no_Label.Location = new System.Drawing.Point(44, 206);
            bathroom_no_Label.Name = "bathroom_no_Label";
            bathroom_no_Label.Size = new System.Drawing.Size(96, 17);
            bathroom_no_Label.TabIndex = 29;
            bathroom_no_Label.Text = "bathroom no :";
            
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(44, 234);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 17);
            priceLabel.TabIndex = 31;
            priceLabel.Text = "price:";
            
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(44, 262);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(43, 17);
            stateLabel.TabIndex = 33;
            stateLabel.Text = "state:";
            
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(44, 290);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(50, 17);
            imageLabel.TabIndex = 35;
            imageLabel.Text = "image:";
            
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.database1DataSet;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PropertiesTableAdapter = this.propertiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = CMOVServer.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // propertiesBindingNavigator
            // 
            this.propertiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.propertiesBindingNavigator.BindingSource = this.propertiesBindingSource;
            this.propertiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.propertiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.propertiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.propertiesBindingNavigatorSaveItem});
            this.propertiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.propertiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.propertiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.propertiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.propertiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.propertiesBindingNavigator.Name = "propertiesBindingNavigator";
            this.propertiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.propertiesBindingNavigator.Size = new System.Drawing.Size(882, 27);
            this.propertiesBindingNavigator.TabIndex = 0;
            this.propertiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // propertiesBindingNavigatorSaveItem
            // 
            this.propertiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.propertiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("propertiesBindingNavigatorSaveItem.Image")));
            this.propertiesBindingNavigatorSaveItem.Name = "propertiesBindingNavigatorSaveItem";
            this.propertiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.propertiesBindingNavigatorSaveItem.Text = "Save Data";
            this.propertiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.propertiesBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Image Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(146, 60);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 22);
            this.idTextBox.TabIndex = 20;
            
            // 
            // typeComboBox
            // 
            this.typeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "type", true));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "House",
            "Flat",
            "Castle"});
            this.typeComboBox.Location = new System.Drawing.Point(146, 88);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 24);
            this.typeComboBox.TabIndex = 22;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(146, 119);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(121, 22);
            this.addressTextBox.TabIndex = 24;
            
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(146, 147);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(121, 22);
            this.cityTextBox.TabIndex = 26;
            
            // 
            // bedroom_no_TextBox
            // 
            this.bedroom_no_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "bedroom no_", true));
            this.bedroom_no_TextBox.Location = new System.Drawing.Point(146, 175);
            this.bedroom_no_TextBox.Name = "bedroom_no_TextBox";
            this.bedroom_no_TextBox.Size = new System.Drawing.Size(121, 22);
            this.bedroom_no_TextBox.TabIndex = 28;
            
            // 
            // bathroom_no_TextBox
            // 
            this.bathroom_no_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "bathroom no_", true));
            this.bathroom_no_TextBox.Location = new System.Drawing.Point(146, 203);
            this.bathroom_no_TextBox.Name = "bathroom_no_TextBox";
            this.bathroom_no_TextBox.Size = new System.Drawing.Size(121, 22);
            this.bathroom_no_TextBox.TabIndex = 30;
           
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(146, 231);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 22);
            this.priceTextBox.TabIndex = 32;
            
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(146, 259);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(121, 22);
            this.stateTextBox.TabIndex = 34;
            
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "image", true));
            this.imageTextBox.Location = new System.Drawing.Point(146, 287);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(121, 22);
            this.imageTextBox.TabIndex = 36;
            
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.database1DataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(314, 105);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.usersDataGridView.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 392);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(bedroom_no_Label);
            this.Controls.Add(this.bedroom_no_TextBox);
            this.Controls.Add(bathroom_no_Label);
            this.Controls.Add(this.bathroom_no_TextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.propertiesBindingNavigator);
            this.Name = "ServerGUI";
            this.Text = "ServerGUI";
            this.Load += new System.EventHandler(this.ServerGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).EndInit();
            this.propertiesBindingNavigator.ResumeLayout(false);
            this.propertiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private Database1DataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator propertiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton propertiesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox bedroom_no_TextBox;
        private System.Windows.Forms.TextBox bathroom_no_TextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}