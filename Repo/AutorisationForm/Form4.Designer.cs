namespace AutorisationForm
{
    partial class Form4
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAddInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textTicketsAdd = new System.Windows.Forms.TextBox();
            this.textAboutSpecAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNameSpecAdd = new System.Windows.Forms.TextBox();
            this.textIdSpecAdd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTicketsUp = new System.Windows.Forms.TextBox();
            this.textBoxAboutSpecUp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxNameSpecUp = new System.Windows.Forms.TextBox();
            this.textBoxIdSpecUp = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonDel = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxIdSpecDel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.logins_PasswordsDataSet2 = new AutorisationForm.Logins_PasswordsDataSet2();
            this.loginsPasswordsDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginpasswordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_passwordTableAdapter = new AutorisationForm.Logins_PasswordsDataSet2TableAdapters.login_passwordTableAdapter();
            this.spectacleinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spectacle_infoTableAdapter = new AutorisationForm.Logins_PasswordsDataSet2TableAdapters.spectacle_infoTableAdapter();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.idspectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namespectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aboutspectacleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountticketsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logins_PasswordsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsPasswordsDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpasswordBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleinfoBindingSource)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SELECT";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(786, 394);
            this.listBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчетToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьСтраницуToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьСтраницуToolStripMenuItem
            // 
            this.обновитьСтраницуToolStripMenuItem.Name = "обновитьСтраницуToolStripMenuItem";
            this.обновитьСтраницуToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.обновитьСтраницуToolStripMenuItem.Text = "Обновить страницу";
            this.обновитьСтраницуToolStripMenuItem.Click += new System.EventHandler(this.обновитьСтраницуToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddInfo);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textTicketsAdd);
            this.tabPage2.Controls.Add(this.textAboutSpecAdd);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textNameSpecAdd);
            this.tabPage2.Controls.Add(this.textIdSpecAdd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INSERT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAddInfo
            // 
            this.buttonAddInfo.Location = new System.Drawing.Point(349, 247);
            this.buttonAddInfo.Name = "buttonAddInfo";
            this.buttonAddInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddInfo.TabIndex = 9;
            this.buttonAddInfo.Text = "Добавить";
            this.buttonAddInfo.UseVisualStyleBackColor = true;
            this.buttonAddInfo.Click += new System.EventHandler(this.buttonAddInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Введите новые данные";
            // 
            // textTicketsAdd
            // 
            this.textTicketsAdd.Location = new System.Drawing.Point(388, 196);
            this.textTicketsAdd.Name = "textTicketsAdd";
            this.textTicketsAdd.Size = new System.Drawing.Size(100, 20);
            this.textTicketsAdd.TabIndex = 7;
            // 
            // textAboutSpecAdd
            // 
            this.textAboutSpecAdd.Location = new System.Drawing.Point(388, 163);
            this.textAboutSpecAdd.Name = "textAboutSpecAdd";
            this.textAboutSpecAdd.Size = new System.Drawing.Size(100, 20);
            this.textAboutSpecAdd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Билеты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Содержание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Код спектакля";
            // 
            // textNameSpecAdd
            // 
            this.textNameSpecAdd.Location = new System.Drawing.Point(388, 125);
            this.textNameSpecAdd.Name = "textNameSpecAdd";
            this.textNameSpecAdd.Size = new System.Drawing.Size(100, 20);
            this.textNameSpecAdd.TabIndex = 1;
            // 
            // textIdSpecAdd
            // 
            this.textIdSpecAdd.Location = new System.Drawing.Point(388, 89);
            this.textIdSpecAdd.Name = "textIdSpecAdd";
            this.textIdSpecAdd.Size = new System.Drawing.Size(100, 20);
            this.textIdSpecAdd.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonUpdate);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxTicketsUp);
            this.tabPage3.Controls.Add(this.textBoxAboutSpecUp);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textBoxNameSpecUp);
            this.tabPage3.Controls.Add(this.textBoxIdSpecUp);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "UPDATE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(110, 225);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Измените данные";
            // 
            // textBoxTicketsUp
            // 
            this.textBoxTicketsUp.Location = new System.Drawing.Point(149, 174);
            this.textBoxTicketsUp.Name = "textBoxTicketsUp";
            this.textBoxTicketsUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxTicketsUp.TabIndex = 17;
            // 
            // textBoxAboutSpecUp
            // 
            this.textBoxAboutSpecUp.Location = new System.Drawing.Point(149, 141);
            this.textBoxAboutSpecUp.Name = "textBoxAboutSpecUp";
            this.textBoxAboutSpecUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxAboutSpecUp.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Билеты";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Содержание";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Название";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Код спектакля";
            // 
            // textBoxNameSpecUp
            // 
            this.textBoxNameSpecUp.Location = new System.Drawing.Point(149, 103);
            this.textBoxNameSpecUp.Name = "textBoxNameSpecUp";
            this.textBoxNameSpecUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameSpecUp.TabIndex = 11;
            // 
            // textBoxIdSpecUp
            // 
            this.textBoxIdSpecUp.Location = new System.Drawing.Point(149, 67);
            this.textBoxIdSpecUp.Name = "textBoxIdSpecUp";
            this.textBoxIdSpecUp.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdSpecUp.TabIndex = 10;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonDel);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.textBoxIdSpecDel);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "DELEATE";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(99, 130);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Код спектакля";
            // 
            // textBoxIdSpecDel
            // 
            this.textBoxIdSpecDel.Location = new System.Drawing.Point(144, 74);
            this.textBoxIdSpecDel.Name = "textBoxIdSpecDel";
            this.textBoxIdSpecDel.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdSpecDel.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Выберите спектакль";
            // 
            // logins_PasswordsDataSet2
            // 
            this.logins_PasswordsDataSet2.DataSetName = "Logins_PasswordsDataSet2";
            this.logins_PasswordsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsPasswordsDataSet2BindingSource
            // 
            this.loginsPasswordsDataSet2BindingSource.DataSource = this.logins_PasswordsDataSet2;
            this.loginsPasswordsDataSet2BindingSource.Position = 0;
            // 
            // loginpasswordBindingSource
            // 
            this.loginpasswordBindingSource.DataMember = "login_password";
            this.loginpasswordBindingSource.DataSource = this.loginsPasswordsDataSet2BindingSource;
            // 
            // login_passwordTableAdapter
            // 
            this.login_passwordTableAdapter.ClearBeforeFill = true;
            // 
            // spectacleinfoBindingSource
            // 
            this.spectacleinfoBindingSource.DataMember = "spectacle_info";
            this.spectacleinfoBindingSource.DataSource = this.loginsPasswordsDataSet2BindingSource;
            // 
            // spectacle_infoTableAdapter
            // 
            this.spectacle_infoTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.advancedDataGridView1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "SEARCH";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToOrderColumns = true;
            this.advancedDataGridView1.AutoGenerateColumns = false;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idspectacleDataGridViewTextBoxColumn,
            this.namespectacleDataGridViewTextBoxColumn,
            this.aboutspectacleDataGridViewTextBoxColumn,
            this.amountticketsDataGridViewTextBoxColumn});
            this.advancedDataGridView1.DataSource = this.spectacleinfoBindingSource;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(3, 3);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.Size = new System.Drawing.Size(786, 418);
            this.advancedDataGridView1.TabIndex = 3;
            // 
            // idspectacleDataGridViewTextBoxColumn
            // 
            this.idspectacleDataGridViewTextBoxColumn.DataPropertyName = "id_spectacle";
            this.idspectacleDataGridViewTextBoxColumn.HeaderText = "id_spectacle";
            this.idspectacleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idspectacleDataGridViewTextBoxColumn.Name = "idspectacleDataGridViewTextBoxColumn";
            this.idspectacleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idspectacleDataGridViewTextBoxColumn.Width = 70;
            // 
            // namespectacleDataGridViewTextBoxColumn
            // 
            this.namespectacleDataGridViewTextBoxColumn.DataPropertyName = "name_spectacle";
            this.namespectacleDataGridViewTextBoxColumn.HeaderText = "name_spectacle";
            this.namespectacleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.namespectacleDataGridViewTextBoxColumn.Name = "namespectacleDataGridViewTextBoxColumn";
            this.namespectacleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // aboutspectacleDataGridViewTextBoxColumn
            // 
            this.aboutspectacleDataGridViewTextBoxColumn.DataPropertyName = "about_spectacle";
            this.aboutspectacleDataGridViewTextBoxColumn.HeaderText = "about_spectacle";
            this.aboutspectacleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.aboutspectacleDataGridViewTextBoxColumn.Name = "aboutspectacleDataGridViewTextBoxColumn";
            this.aboutspectacleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.aboutspectacleDataGridViewTextBoxColumn.Width = 300;
            // 
            // amountticketsDataGridViewTextBoxColumn
            // 
            this.amountticketsDataGridViewTextBoxColumn.DataPropertyName = "amount_tickets";
            this.amountticketsDataGridViewTextBoxColumn.HeaderText = "amount_tickets";
            this.amountticketsDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.amountticketsDataGridViewTextBoxColumn.Name = "amountticketsDataGridViewTextBoxColumn";
            this.amountticketsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.amountticketsDataGridViewTextBoxColumn.Width = 30;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logins_PasswordsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsPasswordsDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginpasswordBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spectacleinfoBindingSource)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textTicketsAdd;
        private System.Windows.Forms.TextBox textAboutSpecAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNameSpecAdd;
        private System.Windows.Forms.TextBox textIdSpecAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonAddInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTicketsUp;
        private System.Windows.Forms.TextBox textBoxAboutSpecUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxNameSpecUp;
        private System.Windows.Forms.TextBox textBoxIdSpecUp;
        private System.Windows.Forms.TextBox textBoxIdSpecDel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.BindingSource loginsPasswordsDataSet2BindingSource;
        private Logins_PasswordsDataSet2 logins_PasswordsDataSet2;
        private System.Windows.Forms.BindingSource loginpasswordBindingSource;
        private Logins_PasswordsDataSet2TableAdapters.login_passwordTableAdapter login_passwordTableAdapter;
        private System.Windows.Forms.BindingSource spectacleinfoBindingSource;
        private Logins_PasswordsDataSet2TableAdapters.spectacle_infoTableAdapter spectacle_infoTableAdapter;
        private System.Windows.Forms.TabPage tabPage5;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idspectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namespectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aboutspectacleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountticketsDataGridViewTextBoxColumn;
    }
}