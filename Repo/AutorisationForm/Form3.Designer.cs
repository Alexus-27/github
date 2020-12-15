namespace AutorisationForm
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.spectacle_infoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.spectacle_infoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.spectacle_infoDataGridView = new System.Windows.Forms.DataGridView();
            this.Action_add = new System.Windows.Forms.Label();
            this.add_spectacle = new System.Windows.Forms.Button();
            this.id_spectacle = new System.Windows.Forms.Label();
            this.name_spectacle = new System.Windows.Forms.Label();
            this.about_spectacle = new System.Windows.Forms.Label();
            this.amount_tickets = new System.Windows.Forms.Label();
            this.textIdSpec = new System.Windows.Forms.TextBox();
            this.textNameSpec = new System.Windows.Forms.TextBox();
            this.textAboutSpec = new System.Windows.Forms.TextBox();
            this.textTicketsSpec = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spectacle_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logins_PasswordsDataSet1 = new AutorisationForm.Logins_PasswordsDataSet1();
            this.spectacle_infoTableAdapter = new AutorisationForm.Logins_PasswordsDataSet1TableAdapters.spectacle_infoTableAdapter();
            this.tableAdapterManager = new AutorisationForm.Logins_PasswordsDataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoBindingNavigator)).BeginInit();
            this.spectacle_infoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logins_PasswordsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // spectacle_infoBindingNavigator
            // 
            this.spectacle_infoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.spectacle_infoBindingNavigator.BindingSource = this.spectacle_infoBindingSource;
            this.spectacle_infoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.spectacle_infoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.spectacle_infoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.spectacle_infoBindingNavigatorSaveItem});
            this.spectacle_infoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.spectacle_infoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.spectacle_infoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.spectacle_infoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.spectacle_infoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.spectacle_infoBindingNavigator.Name = "spectacle_infoBindingNavigator";
            this.spectacle_infoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.spectacle_infoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.spectacle_infoBindingNavigator.TabIndex = 0;
            this.spectacle_infoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // spectacle_infoBindingNavigatorSaveItem
            // 
            this.spectacle_infoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.spectacle_infoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("spectacle_infoBindingNavigatorSaveItem.Image")));
            this.spectacle_infoBindingNavigatorSaveItem.Name = "spectacle_infoBindingNavigatorSaveItem";
            this.spectacle_infoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.spectacle_infoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.spectacle_infoBindingNavigatorSaveItem.Click += new System.EventHandler(this.spectacle_infoBindingNavigatorSaveItem_Click);
            // 
            // spectacle_infoDataGridView
            // 
            this.spectacle_infoDataGridView.AutoGenerateColumns = false;
            this.spectacle_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spectacle_infoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.spectacle_infoDataGridView.DataSource = this.spectacle_infoBindingSource;
            this.spectacle_infoDataGridView.Location = new System.Drawing.Point(0, 55);
            this.spectacle_infoDataGridView.Name = "spectacle_infoDataGridView";
            this.spectacle_infoDataGridView.Size = new System.Drawing.Size(445, 223);
            this.spectacle_infoDataGridView.TabIndex = 1;
            // 
            // Action_add
            // 
            this.Action_add.AutoSize = true;
            this.Action_add.Location = new System.Drawing.Point(588, 55);
            this.Action_add.Name = "Action_add";
            this.Action_add.Size = new System.Drawing.Size(113, 13);
            this.Action_add.TabIndex = 2;
            this.Action_add.Text = "Добавьте спектакль";
            // 
            // add_spectacle
            // 
            this.add_spectacle.Location = new System.Drawing.Point(591, 252);
            this.add_spectacle.Name = "add_spectacle";
            this.add_spectacle.Size = new System.Drawing.Size(100, 26);
            this.add_spectacle.TabIndex = 3;
            this.add_spectacle.Text = "Добавить";
            this.add_spectacle.UseVisualStyleBackColor = true;
            this.add_spectacle.Click += new System.EventHandler(this.add_spectacle_Click);
            // 
            // id_spectacle
            // 
            this.id_spectacle.AutoSize = true;
            this.id_spectacle.Location = new System.Drawing.Point(504, 85);
            this.id_spectacle.Name = "id_spectacle";
            this.id_spectacle.Size = new System.Drawing.Size(85, 13);
            this.id_spectacle.TabIndex = 4;
            this.id_spectacle.Text = "Код спектакля:";
            // 
            // name_spectacle
            // 
            this.name_spectacle.AutoSize = true;
            this.name_spectacle.Location = new System.Drawing.Point(504, 119);
            this.name_spectacle.Name = "name_spectacle";
            this.name_spectacle.Size = new System.Drawing.Size(60, 13);
            this.name_spectacle.TabIndex = 5;
            this.name_spectacle.Text = "Название:";
            // 
            // about_spectacle
            // 
            this.about_spectacle.AutoSize = true;
            this.about_spectacle.Location = new System.Drawing.Point(504, 154);
            this.about_spectacle.Name = "about_spectacle";
            this.about_spectacle.Size = new System.Drawing.Size(74, 13);
            this.about_spectacle.TabIndex = 6;
            this.about_spectacle.Text = "О спектакле:";
            // 
            // amount_tickets
            // 
            this.amount_tickets.AutoSize = true;
            this.amount_tickets.Location = new System.Drawing.Point(504, 221);
            this.amount_tickets.Name = "amount_tickets";
            this.amount_tickets.Size = new System.Drawing.Size(113, 13);
            this.amount_tickets.TabIndex = 7;
            this.amount_tickets.Text = "Количество билетов:";
            // 
            // textIdSpec
            // 
            this.textIdSpec.Location = new System.Drawing.Point(616, 85);
            this.textIdSpec.Name = "textIdSpec";
            this.textIdSpec.Size = new System.Drawing.Size(143, 20);
            this.textIdSpec.TabIndex = 8;
            // 
            // textNameSpec
            // 
            this.textNameSpec.Location = new System.Drawing.Point(616, 119);
            this.textNameSpec.Name = "textNameSpec";
            this.textNameSpec.Size = new System.Drawing.Size(143, 20);
            this.textNameSpec.TabIndex = 9;
            // 
            // textAboutSpec
            // 
            this.textAboutSpec.Location = new System.Drawing.Point(616, 154);
            this.textAboutSpec.Multiline = true;
            this.textAboutSpec.Name = "textAboutSpec";
            this.textAboutSpec.Size = new System.Drawing.Size(143, 44);
            this.textAboutSpec.TabIndex = 10;
            // 
            // textTicketsSpec
            // 
            this.textTicketsSpec.Location = new System.Drawing.Point(616, 214);
            this.textTicketsSpec.Name = "textTicketsSpec";
            this.textTicketsSpec.Size = new System.Drawing.Size(143, 20);
            this.textTicketsSpec.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_spectacle";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_spectacle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_spectacle";
            this.dataGridViewTextBoxColumn2.HeaderText = "name_spectacle";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "about_spectacle";
            this.dataGridViewTextBoxColumn3.HeaderText = "about_spectacle";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "amount_tickets";
            this.dataGridViewTextBoxColumn4.HeaderText = "amount_tickets";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // spectacle_infoBindingSource
            // 
            this.spectacle_infoBindingSource.DataMember = "spectacle_info";
            this.spectacle_infoBindingSource.DataSource = this.logins_PasswordsDataSet1;
            // 
            // logins_PasswordsDataSet1
            // 
            this.logins_PasswordsDataSet1.DataSetName = "Logins_PasswordsDataSet1";
            this.logins_PasswordsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spectacle_infoTableAdapter
            // 
            this.spectacle_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.login_passwordTableAdapter = null;
            this.tableAdapterManager.spectacle_infoTableAdapter = this.spectacle_infoTableAdapter;
            this.tableAdapterManager.UpdateOrder = AutorisationForm.Logins_PasswordsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTicketsSpec);
            this.Controls.Add(this.textAboutSpec);
            this.Controls.Add(this.textNameSpec);
            this.Controls.Add(this.textIdSpec);
            this.Controls.Add(this.amount_tickets);
            this.Controls.Add(this.about_spectacle);
            this.Controls.Add(this.name_spectacle);
            this.Controls.Add(this.id_spectacle);
            this.Controls.Add(this.add_spectacle);
            this.Controls.Add(this.Action_add);
            this.Controls.Add(this.spectacle_infoDataGridView);
            this.Controls.Add(this.spectacle_infoBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoBindingNavigator)).EndInit();
            this.spectacle_infoBindingNavigator.ResumeLayout(false);
            this.spectacle_infoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacle_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logins_PasswordsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Logins_PasswordsDataSet1 logins_PasswordsDataSet1;
        private System.Windows.Forms.BindingSource spectacle_infoBindingSource;
        private Logins_PasswordsDataSet1TableAdapters.spectacle_infoTableAdapter spectacle_infoTableAdapter;
        private Logins_PasswordsDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator spectacle_infoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton spectacle_infoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView spectacle_infoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label Action_add;
        private System.Windows.Forms.Button add_spectacle;
        private System.Windows.Forms.Label id_spectacle;
        private System.Windows.Forms.Label name_spectacle;
        private System.Windows.Forms.Label about_spectacle;
        private System.Windows.Forms.Label amount_tickets;
        private System.Windows.Forms.TextBox textIdSpec;
        private System.Windows.Forms.TextBox textNameSpec;
        private System.Windows.Forms.TextBox textAboutSpec;
        private System.Windows.Forms.TextBox textTicketsSpec;
    }
}