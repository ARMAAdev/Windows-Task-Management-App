namespace taskManager
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new FontAwesome.Sharp.IconButton();
            this.buttonClose = new FontAwesome.Sharp.IconButton();
            this.buttonCalender = new FontAwesome.Sharp.IconButton();
            this.buttonFilter = new FontAwesome.Sharp.IconButton();
            this.cmsFilter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateFilterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeFilterItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSort = new FontAwesome.Sharp.IconButton();
            this.cmsSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateAddedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alphabeticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSelect = new FontAwesome.Sharp.IconButton();
            this.buttonDelete = new FontAwesome.Sharp.IconButton();
            this.filterationTwoUC1 = new UI_v3.FilterationTwoUC();
            this.filterationUC1 = new UI_v3.FilterationUC();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new FontAwesome.Sharp.IconButton();
            this.searchCancel = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.notifymainForm = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panelMain = new System.Windows.Forms.Panel();
            this.calenderDropdown = new System.Windows.Forms.MonthCalendar();
            this.filterationUCDate = new UI_v3.FilterationUC();
            this.viewTask = new taskManager.viewTasks();
            this.lowerRightUC1 = new UI_v3.LowerRightUC();
            this.panelTop.SuspendLayout();
            this.cmsFilter.SuspendLayout();
            this.cmsSort.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.notifyMenuStrip.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.panelTop.Controls.Add(this.filterationUC1);
            this.panelTop.Controls.Add(this.searchCancel);
            this.panelTop.Controls.Add(this.filterationTwoUC1);
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Controls.Add(this.buttonCalender);
            this.panelTop.Controls.Add(this.buttonFilter);
            this.panelTop.Controls.Add(this.buttonSort);
            this.panelTop.Controls.Add(this.buttonSelect);
            this.panelTop.Controls.Add(this.buttonDelete);
            this.panelTop.Controls.Add(this.buttonSearch);
            this.panelTop.Controls.Add(this.textBoxSearch);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1231, 100);
            this.panelTop.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.buttonMinimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(54)))));
            this.buttonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMinimize.IconSize = 32;
            this.buttonMinimize.Location = new System.Drawing.Point(1157, 7);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Padding = new System.Windows.Forms.Padding(1);
            this.buttonMinimize.Size = new System.Drawing.Size(45, 33);
            this.buttonMinimize.TabIndex = 10;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            this.buttonMinimize.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonMinimize.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.buttonClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(171)))), ((int)(((byte)(54)))));
            this.buttonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonClose.IconSize = 32;
            this.buttonClose.Location = new System.Drawing.Point(1203, 10);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Padding = new System.Windows.Forms.Padding(1);
            this.buttonClose.Size = new System.Drawing.Size(45, 33);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            this.buttonClose.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonClose.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // buttonCalender
            // 
            this.buttonCalender.BackColor = System.Drawing.Color.Transparent;
            this.buttonCalender.FlatAppearance.BorderSize = 0;
            this.buttonCalender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalender.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.buttonCalender.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonCalender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCalender.Location = new System.Drawing.Point(824, 21);
            this.buttonCalender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalender.Name = "buttonCalender";
            this.buttonCalender.Size = new System.Drawing.Size(83, 60);
            this.buttonCalender.TabIndex = 5;
            this.buttonCalender.UseVisualStyleBackColor = false;
            this.buttonCalender.Click += new System.EventHandler(this.buttonCalender_Click);
            this.buttonCalender.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonCalender.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilter.ContextMenuStrip = this.cmsFilter;
            this.buttonFilter.FlatAppearance.BorderSize = 0;
            this.buttonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.buttonFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFilter.Location = new System.Drawing.Point(139, 22);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(83, 60);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            this.buttonFilter.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonFilter.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // cmsFilter
            // 
            this.cmsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.cmsFilter.BackgroundImage = global::UI_v3.Properties.Resources.Teal;
            this.cmsFilter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateFilterItem,
            this.timeFilterItem});
            this.cmsFilter.Name = "cmsSort";
            this.cmsFilter.Size = new System.Drawing.Size(112, 52);
            // 
            // dateFilterItem
            // 
            this.dateFilterItem.BackgroundImage = global::UI_v3.Properties.Resources.Teal2;
            this.dateFilterItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateFilterItem.Name = "dateFilterItem";
            this.dateFilterItem.Size = new System.Drawing.Size(111, 24);
            this.dateFilterItem.Text = "Date";
            this.dateFilterItem.Click += new System.EventHandler(this.dateFilterItem_Click);
            // 
            // timeFilterItem
            // 
            this.timeFilterItem.BackgroundImage = global::UI_v3.Properties.Resources.Teal2;
            this.timeFilterItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeFilterItem.Name = "timeFilterItem";
            this.timeFilterItem.Size = new System.Drawing.Size(111, 24);
            this.timeFilterItem.Text = "Time";
            this.timeFilterItem.Click += new System.EventHandler(this.timeFilterItem_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.Transparent;
            this.buttonSort.ContextMenuStrip = this.cmsSort;
            this.buttonSort.FlatAppearance.BorderSize = 0;
            this.buttonSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSort.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            this.buttonSort.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonSort.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSort.Location = new System.Drawing.Point(37, 22);
            this.buttonSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(83, 60);
            this.buttonSort.TabIndex = 3;
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            this.buttonSort.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonSort.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // cmsSort
            // 
            this.cmsSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.cmsSort.BackgroundImage = global::UI_v3.Properties.Resources.Teal;
            this.cmsSort.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateAddedToolStripMenuItem,
            this.alphabeticalToolStripMenuItem,
            this.dueDateToolStripMenuItem});
            this.cmsSort.Name = "cmsSort";
            this.cmsSort.Size = new System.Drawing.Size(163, 76);
            // 
            // dateAddedToolStripMenuItem
            // 
            this.dateAddedToolStripMenuItem.BackgroundImage = global::UI_v3.Properties.Resources.Teal2;
            this.dateAddedToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateAddedToolStripMenuItem.Name = "dateAddedToolStripMenuItem";
            this.dateAddedToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.dateAddedToolStripMenuItem.Text = "Date Added";
            this.dateAddedToolStripMenuItem.Click += new System.EventHandler(this.dateAddedToolStripMenuItem_Click);
            // 
            // alphabeticalToolStripMenuItem
            // 
            this.alphabeticalToolStripMenuItem.BackgroundImage = global::UI_v3.Properties.Resources.Teal2;
            this.alphabeticalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.alphabeticalToolStripMenuItem.Name = "alphabeticalToolStripMenuItem";
            this.alphabeticalToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.alphabeticalToolStripMenuItem.Text = "Alphabetical";
            this.alphabeticalToolStripMenuItem.Click += new System.EventHandler(this.alphabeticalToolStripMenuItem_Click);
            // 
            // dueDateToolStripMenuItem
            // 
            this.dueDateToolStripMenuItem.BackgroundImage = global::UI_v3.Properties.Resources.Teal2;
            this.dueDateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dueDateToolStripMenuItem.Name = "dueDateToolStripMenuItem";
            this.dueDateToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.dueDateToolStripMenuItem.Text = "Due Date";
            this.dueDateToolStripMenuItem.Click += new System.EventHandler(this.dueDateToolStripMenuItem_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.buttonSelect.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonSelect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSelect.Location = new System.Drawing.Point(931, 21);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(83, 60);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            this.buttonSelect.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonSelect.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDelete.Location = new System.Drawing.Point(1035, 22);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(1);
            this.buttonDelete.Size = new System.Drawing.Size(83, 60);
            this.buttonDelete.TabIndex = 0;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            this.buttonDelete.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonDelete.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // filterationTwoUC1
            // 
            this.filterationTwoUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.filterationTwoUC1.Location = new System.Drawing.Point(272, 13);
            this.filterationTwoUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterationTwoUC1.Name = "filterationTwoUC1";
            this.filterationTwoUC1.Size = new System.Drawing.Size(549, 82);
            this.filterationTwoUC1.TabIndex = 13;
            this.filterationTwoUC1.Visible = false;
            // 
            // filterationUC1
            // 
            this.filterationUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.filterationUC1.FromDate = new System.DateTime(2021, 12, 29, 16, 43, 5, 963);
            this.filterationUC1.Location = new System.Drawing.Point(284, 13);
            this.filterationUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterationUC1.Name = "filterationUC1";
            this.filterationUC1.Size = new System.Drawing.Size(549, 82);
            this.filterationUC1.TabIndex = 12;
            this.filterationUC1.ToDate = new System.DateTime(2021, 12, 29, 16, 43, 5, 958);
            this.filterationUC1.Visible = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AcceptsTab = true;
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxSearch.Location = new System.Drawing.Point(357, 31);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(447, 43);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSearch.Location = new System.Drawing.Point(271, 22);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(83, 60);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.buttonTopPanel_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonTopPanel_MouseLeave);
            // 
            // searchCancel
            // 
            this.searchCancel.AutoSize = true;
            this.searchCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.searchCancel.Location = new System.Drawing.Point(777, 39);
            this.searchCancel.Name = "searchCancel";
            this.searchCancel.Size = new System.Drawing.Size(22, 22);
            this.searchCancel.TabIndex = 11;
            this.searchCancel.Text = "X";
            this.searchCancel.Visible = false;
            this.searchCancel.Click += new System.EventHandler(this.searchCancel_Click);
            this.searchCancel.MouseEnter += new System.EventHandler(this.searchCancel_MouseEnter);
            this.searchCancel.MouseLeave += new System.EventHandler(this.searchCancel_MouseLeave);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(131)))));
            this.panelLeft.Controls.Add(this.listBoxTasks);
            this.panelLeft.Controls.Add(this.buttonAdd);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 100);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(311, 588);
            this.panelLeft.TabIndex = 1;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(131)))));
            this.listBoxTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxTasks.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTasks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.HorizontalScrollbar = true;
            this.listBoxTasks.ItemHeight = 30;
            this.listBoxTasks.Location = new System.Drawing.Point(0, 0);
            this.listBoxTasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxTasks.Size = new System.Drawing.Size(292, 531);
            this.listBoxTasks.TabIndex = 0;
            this.listBoxTasks.Click += new System.EventHandler(this.listBoxTasks_Click);
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            this.listBoxTasks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxTasks_KeyDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAdd.IconColor = System.Drawing.Color.White;
            this.buttonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.Location = new System.Drawing.Point(0, 531);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(311, 57);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add task";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.MouseEnter += new System.EventHandler(this.buttonAdd_MouseEnter);
            this.buttonAdd.MouseLeave += new System.EventHandler(this.buttonAdd_MouseLeave);
            // 
            // notifymainForm
            // 
            this.notifymainForm.ContextMenuStrip = this.notifyMenuStrip;
            this.notifymainForm.Icon = ((System.Drawing.Icon)(resources.GetObject("notifymainForm.Icon")));
            this.notifymainForm.Text = "Task Manager";
            this.notifymainForm.Visible = true;
            this.notifymainForm.DoubleClick += new System.EventHandler(this.notifymainForm_DoubleClick);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.BackColor = System.Drawing.SystemColors.InfoText;
            this.notifyMenuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("notifyMenuStrip.BackgroundImage")));
            this.notifyMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.notifyMenuStrip.Name = "contextMenuStrip1";
            this.notifyMenuStrip.Size = new System.Drawing.Size(129, 52);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.BackColor = System.Drawing.SystemColors.InfoText;
            this.restoreToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restoreToolStripMenuItem.BackgroundImage")));
            this.restoreToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.InfoText;
            this.exitToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.BackgroundImage")));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMain.Controls.Add(this.calenderDropdown);
            this.panelMain.Controls.Add(this.filterationUCDate);
            this.panelMain.Controls.Add(this.viewTask);
            this.panelMain.Controls.Add(this.lowerRightUC1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(268, 100);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(963, 588);
            this.panelMain.TabIndex = 2;
            // 
            // calenderDropdown
            // 
            this.calenderDropdown.Location = new System.Drawing.Point(452, 0);
            this.calenderDropdown.Name = "calenderDropdown";
            this.calenderDropdown.TabIndex = 13;
            this.calenderDropdown.Visible = false;
            this.calenderDropdown.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calenderDropdown_DateChanged);
            // 
            // filterationUCDate
            // 
            this.filterationUCDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterationUCDate.FromDate = new System.DateTime(2021, 12, 29, 16, 43, 5, 901);
            this.filterationUCDate.Location = new System.Drawing.Point(0, -73);
            this.filterationUCDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.filterationUCDate.Name = "filterationUCDate";
            this.filterationUCDate.Size = new System.Drawing.Size(410, 67);
            this.filterationUCDate.TabIndex = 12;
            this.filterationUCDate.ToDate = new System.DateTime(2021, 12, 29, 16, 43, 5, 894);
            // 
            // viewTask
            // 
            this.viewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewTask.Location = new System.Drawing.Point(0, 0);
            this.viewTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewTask.Name = "viewTask";
            this.viewTask.Size = new System.Drawing.Size(963, 588);
            this.viewTask.TabIndex = 0;
            this.viewTask.Visible = false;
            // 
            // lowerRightUC1
            // 
            this.lowerRightUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.lowerRightUC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerRightUC1.Location = new System.Drawing.Point(0, 0);
            this.lowerRightUC1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowerRightUC1.Name = "lowerRightUC1";
            this.lowerRightUC1.Size = new System.Drawing.Size(963, 588);
            this.lowerRightUC1.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1231, 688);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1253, 773);
            this.MinimumSize = new System.Drawing.Size(1253, 719);
            this.Name = "mainForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskManager";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.cmsFilter.ResumeLayout(false);
            this.cmsSort.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.notifyMenuStrip.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private FontAwesome.Sharp.IconButton buttonCalender;
        private FontAwesome.Sharp.IconButton buttonFilter;
        private FontAwesome.Sharp.IconButton buttonSort;
        private FontAwesome.Sharp.IconButton buttonSelect;
        private FontAwesome.Sharp.IconButton buttonDelete;
        private FontAwesome.Sharp.IconButton buttonSearch;
        private FontAwesome.Sharp.IconButton buttonAdd;
        public System.Windows.Forms.ListBox listBoxTasks;
        public System.Windows.Forms.NotifyIcon notifymainForm;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.FontDialog fontDialog1;
        private FontAwesome.Sharp.IconButton buttonMinimize;
        private FontAwesome.Sharp.IconButton buttonClose;
        private System.Windows.Forms.ContextMenuStrip cmsSort;
        private System.Windows.Forms.ToolStripMenuItem alphabeticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateAddedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueDateToolStripMenuItem;
        private System.Windows.Forms.Label searchCancel;
        private System.Windows.Forms.Panel panelMain;
        private viewTasks viewTask;
        private UI_v3.LowerRightUC lowerRightUC1;
        private UI_v3.FilterationUC filterationUCDate;
        private UI_v3.FilterationUC filterationUC1;
        private System.Windows.Forms.ContextMenuStrip cmsFilter;
        private System.Windows.Forms.ToolStripMenuItem dateFilterItem;
        private System.Windows.Forms.ToolStripMenuItem timeFilterItem;
        private UI_v3.FilterationTwoUC filterationTwoUC1;
        private System.Windows.Forms.MonthCalendar calenderDropdown;
    }
}

