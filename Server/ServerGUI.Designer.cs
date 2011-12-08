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
            System.Windows.Forms.Label ffffLabel;
            System.Windows.Forms.Label sfimfiosmdLabel;
            System.Windows.Forms.Label dddLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label idLabel;
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
            this.ffffTextBox = new System.Windows.Forms.TextBox();
            this.sfimfiosmdTextBox = new System.Windows.Forms.TextBox();
            this.dddTextBox = new System.Windows.Forms.TextBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxImage = new System.Windows.Forms.TextBox();
            ffffLabel = new System.Windows.Forms.Label();
            sfimfiosmdLabel = new System.Windows.Forms.Label();
            dddLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).BeginInit();
            this.propertiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ffffLabel
            // 
            ffffLabel.AutoSize = true;
            ffffLabel.Location = new System.Drawing.Point(94, 60);
            ffffLabel.Name = "ffffLabel";
            ffffLabel.Size = new System.Drawing.Size(28, 17);
            ffffLabel.TabIndex = 3;
            ffffLabel.Text = "ffff:";
            // 
            // sfimfiosmdLabel
            // 
            sfimfiosmdLabel.AutoSize = true;
            sfimfiosmdLabel.Location = new System.Drawing.Point(94, 88);
            sfimfiosmdLabel.Name = "sfimfiosmdLabel";
            sfimfiosmdLabel.Size = new System.Drawing.Size(78, 17);
            sfimfiosmdLabel.TabIndex = 5;
            sfimfiosmdLabel.Text = "sfimfiosmd:";
            // 
            // dddLabel
            // 
            dddLabel.AutoSize = true;
            dddLabel.Location = new System.Drawing.Point(94, 116);
            dddLabel.Name = "dddLabel";
            dddLabel.Size = new System.Drawing.Size(36, 17);
            dddLabel.TabIndex = 7;
            dddLabel.Text = "ddd:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(94, 145);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(40, 17);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "date:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(94, 32);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
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
            this.propertiesBindingNavigator.Size = new System.Drawing.Size(398, 27);
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
            // ffffTextBox
            // 
            this.ffffTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "ffff", true));
            this.ffffTextBox.Location = new System.Drawing.Point(178, 57);
            this.ffffTextBox.Name = "ffffTextBox";
            this.ffffTextBox.Size = new System.Drawing.Size(200, 22);
            this.ffffTextBox.TabIndex = 4;
            // 
            // sfimfiosmdTextBox
            // 
            this.sfimfiosmdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "sfimfiosmd", true));
            this.sfimfiosmdTextBox.Location = new System.Drawing.Point(178, 85);
            this.sfimfiosmdTextBox.Name = "sfimfiosmdTextBox";
            this.sfimfiosmdTextBox.Size = new System.Drawing.Size(200, 22);
            this.sfimfiosmdTextBox.TabIndex = 6;
            // 
            // dddTextBox
            // 
            this.dddTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "ddd", true));
            this.dddTextBox.Location = new System.Drawing.Point(178, 113);
            this.dddTextBox.Name = "dddTextBox";
            this.dddTextBox.Size = new System.Drawing.Size(200, 22);
            this.dddTextBox.TabIndex = 8;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.propertiesBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(178, 141);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 10;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.propertiesBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(178, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Image:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxImage
            // 
            this.textBoxImage.Location = new System.Drawing.Point(178, 177);
            this.textBoxImage.Name = "textBoxImage";
            this.textBoxImage.Size = new System.Drawing.Size(119, 22);
            this.textBoxImage.TabIndex = 13;
            // 
            // ServerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 255);
            this.Controls.Add(this.textBoxImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(ffffLabel);
            this.Controls.Add(this.ffffTextBox);
            this.Controls.Add(sfimfiosmdLabel);
            this.Controls.Add(this.sfimfiosmdTextBox);
            this.Controls.Add(dddLabel);
            this.Controls.Add(this.dddTextBox);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.propertiesBindingNavigator);
            this.Name = "ServerGUI";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingNavigator)).EndInit();
            this.propertiesBindingNavigator.ResumeLayout(false);
            this.propertiesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox ffffTextBox;
        private System.Windows.Forms.TextBox sfimfiosmdTextBox;
        private System.Windows.Forms.TextBox dddTextBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxImage;
    }
}