namespace Store_1
{
    partial class StoreForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowStartPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoreExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OperationExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPositionButton = new System.Windows.Forms.Button();
            this.ChangePositionButton = new System.Windows.Forms.Button();
            this.DeletePositionButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.WriteOffButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SaleButton = new System.Windows.Forms.Button();
            this.CurrentQuantityLabel = new System.Windows.Forms.Label();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.CurrentQuantityTextBox = new System.Windows.Forms.TextBox();
            this.StoreGrid = new DevExpress.XtraGrid.GridControl();
            this.StoreGridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OperationsGrid = new DevExpress.XtraGrid.GridControl();
            this.OperationsGridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ShowOperationsForInterval = new System.Windows.Forms.Button();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuToolStripMenuItem,
            this.UserMenuToolStripMenuItem,
            this.ExportlToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1314, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "Главное меню";
            // 
            // MainMenuToolStripMenuItem
            // 
            this.MainMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowStartPriceToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem";
            this.MainMenuToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.MainMenuToolStripMenuItem.Text = "Главное меню";
            // 
            // ShowStartPriceToolStripMenuItem
            // 
            this.ShowStartPriceToolStripMenuItem.Name = "ShowStartPriceToolStripMenuItem";
            this.ShowStartPriceToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ShowStartPriceToolStripMenuItem.Text = "Показать закупочную цену";
            this.ShowStartPriceToolStripMenuItem.Click += new System.EventHandler(this.ShowStartPriceToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // UserMenuToolStripMenuItem
            // 
            this.UserMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeUserToolStripMenuItem});
            this.UserMenuToolStripMenuItem.Name = "UserMenuToolStripMenuItem";
            this.UserMenuToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.UserMenuToolStripMenuItem.Text = "Пользователи";
            // 
            // ChangeUserToolStripMenuItem
            // 
            this.ChangeUserToolStripMenuItem.Name = "ChangeUserToolStripMenuItem";
            this.ChangeUserToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.ChangeUserToolStripMenuItem.Text = "Сменить пользователя";
            this.ChangeUserToolStripMenuItem.Click += new System.EventHandler(this.ChangeUserToolStripMenuItem_Click);
            // 
            // ExportlToolStripMenuItem
            // 
            this.ExportlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StoreExportToolStripMenuItem,
            this.OperationExportToolStripMenuItem});
            this.ExportlToolStripMenuItem.Name = "ExportlToolStripMenuItem";
            this.ExportlToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.ExportlToolStripMenuItem.Text = "Экспорт в Excel";
            // 
            // StoreExportToolStripMenuItem
            // 
            this.StoreExportToolStripMenuItem.Name = "StoreExportToolStripMenuItem";
            this.StoreExportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.StoreExportToolStripMenuItem.Text = "Экспорт склада";
            this.StoreExportToolStripMenuItem.Click += new System.EventHandler(this.StoreExportToolStripMenuItem_Click);
            // 
            // OperationExportToolStripMenuItem
            // 
            this.OperationExportToolStripMenuItem.Name = "OperationExportToolStripMenuItem";
            this.OperationExportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.OperationExportToolStripMenuItem.Text = "Экспорт операций";
            this.OperationExportToolStripMenuItem.Click += new System.EventHandler(this.OperationExportToolStripMenuItem_Click);
            // 
            // AddPositionButton
            // 
            this.AddPositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPositionButton.Enabled = false;
            this.AddPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPositionButton.Location = new System.Drawing.Point(12, 432);
            this.AddPositionButton.Name = "AddPositionButton";
            this.AddPositionButton.Size = new System.Drawing.Size(119, 44);
            this.AddPositionButton.TabIndex = 14;
            this.AddPositionButton.Text = "ДОБАВИТЬ\r\nТОВАР";
            this.AddPositionButton.UseVisualStyleBackColor = true;
            this.AddPositionButton.Click += new System.EventHandler(this.AddPositionButton_Click);
            // 
            // ChangePositionButton
            // 
            this.ChangePositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChangePositionButton.Enabled = false;
            this.ChangePositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangePositionButton.Location = new System.Drawing.Point(137, 432);
            this.ChangePositionButton.Name = "ChangePositionButton";
            this.ChangePositionButton.Size = new System.Drawing.Size(119, 44);
            this.ChangePositionButton.TabIndex = 15;
            this.ChangePositionButton.Tag = "not_admin";
            this.ChangePositionButton.Text = "ИЗМЕНИТЬ\r\nТОВАР";
            this.ChangePositionButton.UseVisualStyleBackColor = true;
            this.ChangePositionButton.Click += new System.EventHandler(this.ChangePositionButton_Click);
            // 
            // DeletePositionButton
            // 
            this.DeletePositionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DeletePositionButton.Enabled = false;
            this.DeletePositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePositionButton.Location = new System.Drawing.Point(262, 432);
            this.DeletePositionButton.Name = "DeletePositionButton";
            this.DeletePositionButton.Size = new System.Drawing.Size(119, 44);
            this.DeletePositionButton.TabIndex = 16;
            this.DeletePositionButton.Tag = "not_admin";
            this.DeletePositionButton.Text = "УДАЛИТЬ\r\nТОВАР";
            this.DeletePositionButton.UseVisualStyleBackColor = true;
            this.DeletePositionButton.Click += new System.EventHandler(this.DeletePositionButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(201, 24);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(111, 17);
            this.UserLabel.TabIndex = 18;
            this.UserLabel.Text = "пользователь";
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentUserLabel.Location = new System.Drawing.Point(9, 24);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(186, 17);
            this.CurrentUserLabel.TabIndex = 17;
            this.CurrentUserLabel.Text = "Текущий пользователь:";
            // 
            // WriteOffButton
            // 
            this.WriteOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteOffButton.Location = new System.Drawing.Point(401, 322);
            this.WriteOffButton.Name = "WriteOffButton";
            this.WriteOffButton.Size = new System.Drawing.Size(191, 44);
            this.WriteOffButton.TabIndex = 24;
            this.WriteOffButton.Tag = "NotEnabled";
            this.WriteOffButton.Text = "СПИСАНИЕ";
            this.WriteOffButton.UseVisualStyleBackColor = true;
            this.WriteOffButton.Click += new System.EventHandler(this.WriteOffButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(401, 272);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(191, 44);
            this.AddButton.TabIndex = 23;
            this.AddButton.Tag = "NotEnabled";
            this.AddButton.Text = "ДОБАВЛЕНИЕ\r\n(ПРИЕМ ОТ ПОСТАВЩИКА)";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnButton.Location = new System.Drawing.Point(402, 222);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(191, 44);
            this.ReturnButton.TabIndex = 22;
            this.ReturnButton.Tag = "NotEnabled";
            this.ReturnButton.Text = "ВОЗВРАТ";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // SaleButton
            // 
            this.SaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaleButton.Location = new System.Drawing.Point(401, 172);
            this.SaleButton.Name = "SaleButton";
            this.SaleButton.Size = new System.Drawing.Size(192, 44);
            this.SaleButton.TabIndex = 21;
            this.SaleButton.Tag = "NotEnabled";
            this.SaleButton.Text = "ПРОДАЖА";
            this.SaleButton.UseVisualStyleBackColor = true;
            this.SaleButton.Click += new System.EventHandler(this.SaleButton_Click);
            // 
            // CurrentQuantityLabel
            // 
            this.CurrentQuantityLabel.AutoSize = true;
            this.CurrentQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentQuantityLabel.Location = new System.Drawing.Point(401, 121);
            this.CurrentQuantityLabel.Name = "CurrentQuantityLabel";
            this.CurrentQuantityLabel.Size = new System.Drawing.Size(115, 20);
            this.CurrentQuantityLabel.TabIndex = 20;
            this.CurrentQuantityLabel.Text = "Количество:";
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentPositionLabel.Location = new System.Drawing.Point(399, 63);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(212, 20);
            this.CurrentPositionLabel.TabIndex = 19;
            this.CurrentPositionLabel.Text = "Текущее наименование:";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateLabel.Location = new System.Drawing.Point(880, 53);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(164, 17);
            this.EndDateLabel.TabIndex = 30;
            this.EndDateLabel.Text = "Окончание периода:";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartDateLabel.Location = new System.Drawing.Point(621, 50);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(137, 17);
            this.StartDateLabel.TabIndex = 29;
            this.StartDateLabel.Text = "Начало периода:";
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntervalLabel.Location = new System.Drawing.Point(620, 24);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(177, 20);
            this.IntervalLabel.TabIndex = 28;
            this.IntervalLabel.Text = "Интервал операций";
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(1041, 50);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.EndDateTimePicker.TabIndex = 27;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(752, 50);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(122, 20);
            this.StartDateTimePicker.TabIndex = 26;
            // 
            // CurrentPositionTextBox
            // 
            this.CurrentPositionTextBox.Location = new System.Drawing.Point(407, 89);
            this.CurrentPositionTextBox.Name = "CurrentPositionTextBox";
            this.CurrentPositionTextBox.ReadOnly = true;
            this.CurrentPositionTextBox.Size = new System.Drawing.Size(194, 20);
            this.CurrentPositionTextBox.TabIndex = 31;
            // 
            // CurrentQuantityTextBox
            // 
            this.CurrentQuantityTextBox.Location = new System.Drawing.Point(407, 146);
            this.CurrentQuantityTextBox.MaxLength = 5;
            this.CurrentQuantityTextBox.Name = "CurrentQuantityTextBox";
            this.CurrentQuantityTextBox.ReadOnly = true;
            this.CurrentQuantityTextBox.Size = new System.Drawing.Size(194, 20);
            this.CurrentQuantityTextBox.TabIndex = 32;
            this.CurrentQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentQuantityTextBox_KeyPress);
            // 
            // StoreGrid
            // 
            this.StoreGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StoreGrid.Location = new System.Drawing.Point(13, 52);
            this.StoreGrid.MainView = this.StoreGridView1;
            this.StoreGrid.Name = "StoreGrid";
            this.StoreGrid.Size = new System.Drawing.Size(379, 371);
            this.StoreGrid.TabIndex = 33;
            this.StoreGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StoreGridView1});
            this.StoreGrid.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // StoreGridView1
            // 
            this.StoreGridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.StoreGridView1.GridControl = this.StoreGrid;
            this.StoreGridView1.Name = "StoreGridView1";
            this.StoreGridView1.OptionsBehavior.Editable = false;
            this.StoreGridView1.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Cancel;
            this.StoreGridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Наименование";
            this.gridColumn1.FieldName = "position";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 50;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Количество";
            this.gridColumn2.FieldName = "quantity";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 45;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Цена";
            this.gridColumn3.FieldName = "price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 46;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Закупочная цена";
            this.gridColumn4.FieldName = "first_price";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Width = 50;
            // 
            // OperationsGrid
            // 
            this.OperationsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperationsGrid.Location = new System.Drawing.Point(624, 73);
            this.OperationsGrid.MainView = this.OperationsGridView2;
            this.OperationsGrid.Name = "OperationsGrid";
            this.OperationsGrid.Size = new System.Drawing.Size(678, 402);
            this.OperationsGrid.TabIndex = 34;
            this.OperationsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OperationsGridView2});
            // 
            // OperationsGridView2
            // 
            this.OperationsGridView2.GridControl = this.OperationsGrid;
            this.OperationsGridView2.Name = "OperationsGridView2";
            this.OperationsGridView2.OptionsBehavior.Editable = false;
            // 
            // ShowOperationsForInterval
            // 
            this.ShowOperationsForInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowOperationsForInterval.Location = new System.Drawing.Point(1169, 38);
            this.ShowOperationsForInterval.Name = "ShowOperationsForInterval";
            this.ShowOperationsForInterval.Size = new System.Drawing.Size(118, 29);
            this.ShowOperationsForInterval.TabIndex = 35;
            this.ShowOperationsForInterval.Tag = "NotEnabled";
            this.ShowOperationsForInterval.Text = "Показать";
            this.ShowOperationsForInterval.UseVisualStyleBackColor = true;
            this.ShowOperationsForInterval.Click += new System.EventHandler(this.ShowOperationsForInterval_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1314, 488);
            this.Controls.Add(this.ShowOperationsForInterval);
            this.Controls.Add(this.OperationsGrid);
            this.Controls.Add(this.StoreGrid);
            this.Controls.Add(this.CurrentQuantityTextBox);
            this.Controls.Add(this.CurrentPositionTextBox);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.WriteOffButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaleButton);
            this.Controls.Add(this.CurrentQuantityLabel);
            this.Controls.Add(this.CurrentPositionLabel);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.CurrentUserLabel);
            this.Controls.Add(this.DeletePositionButton);
            this.Controls.Add(this.ChangePositionButton);
            this.Controls.Add(this.AddPositionButton);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "StoreForm";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowStartPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UserMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoreExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OperationExportToolStripMenuItem;
        private System.Windows.Forms.Button AddPositionButton;
        private System.Windows.Forms.Button ChangePositionButton;
        private System.Windows.Forms.Button DeletePositionButton;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label CurrentUserLabel;
        private System.Windows.Forms.Button WriteOffButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Button SaleButton;
        private System.Windows.Forms.Label CurrentQuantityLabel;
        private System.Windows.Forms.Label CurrentPositionLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.TextBox CurrentPositionTextBox;
        private System.Windows.Forms.TextBox CurrentQuantityTextBox;
        private DevExpress.XtraGrid.GridControl StoreGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView StoreGridView1;
        private DevExpress.XtraGrid.GridControl OperationsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView OperationsGridView2;
        private System.Windows.Forms.Button ShowOperationsForInterval;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}

