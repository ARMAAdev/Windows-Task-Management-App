namespace taskManager
{
    partial class addTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAddTask = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.pickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.pickerTime = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            this.buttonCancel = new FontAwesome.Sharp.IconButton();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.labelAddTask);
            this.panel1.Controls.Add(this.panelSeparator);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 62);
            this.panel1.TabIndex = 1;
            // 
            // labelAddTask
            // 
            this.labelAddTask.AutoSize = true;
            this.labelAddTask.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.labelAddTask.Location = new System.Drawing.Point(2, 12);
            this.labelAddTask.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddTask.Name = "labelAddTask";
            this.labelAddTask.Size = new System.Drawing.Size(91, 27);
            this.labelAddTask.TabIndex = 1;
            this.labelAddTask.Text = "Add task";
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelSeparator.Location = new System.Drawing.Point(0, 54);
            this.panelSeparator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(482, 8);
            this.panelSeparator.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.labelTitle.Location = new System.Drawing.Point(2, 72);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(51, 27);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // textboxTitle
            // 
            this.textboxTitle.BackColor = System.Drawing.Color.White;
            this.textboxTitle.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxTitle.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxTitle.Location = new System.Drawing.Point(9, 102);
            this.textboxTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(467, 32);
            this.textboxTitle.TabIndex = 3;
            this.textboxTitle.Text = "Enter the title here...";
            this.textboxTitle.Click += new System.EventHandler(this.textboxTitle_Click);
            this.textboxTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxTitle_KeyDown);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.labelDescription.Location = new System.Drawing.Point(4, 148);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(116, 27);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // textboxDescription
            // 
            this.textboxDescription.BackColor = System.Drawing.Color.White;
            this.textboxDescription.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDescription.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textboxDescription.Location = new System.Drawing.Point(7, 179);
            this.textboxDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxDescription.Multiline = true;
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(467, 118);
            this.textboxDescription.TabIndex = 7;
            this.textboxDescription.Text = "Enter the description here...";
            this.textboxDescription.Click += new System.EventHandler(this.textboxDescription_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.labelDate.Location = new System.Drawing.Point(22, 311);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(70, 19);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Due Date";
            // 
            // pickerDate
            // 
            this.pickerDate.CustomFormat = "dd / MM / yyyy ";
            this.pickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerDate.Location = new System.Drawing.Point(21, 345);
            this.pickerDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(114, 20);
            this.pickerDate.TabIndex = 11;
            this.pickerDate.ValueChanged += new System.EventHandler(this.pickerDate_ValueChanged);
            this.pickerDate.DropDown += new System.EventHandler(this.pickerDate_DropDown);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.labelTime.Location = new System.Drawing.Point(187, 311);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(71, 19);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Due Time";
            // 
            // pickerTime
            // 
            this.pickerTime.CalendarFont = new System.Drawing.Font("Yu Gothic UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerTime.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.pickerTime.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.pickerTime.CustomFormat = "hh:mm tt";
            this.pickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerTime.Location = new System.Drawing.Point(190, 345);
            this.pickerTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickerTime.Name = "pickerTime";
            this.pickerTime.ShowUpDown = true;
            this.pickerTime.Size = new System.Drawing.Size(91, 20);
            this.pickerTime.TabIndex = 14;
            this.pickerTime.ValueChanged += new System.EventHandler(this.pickerTime_ValueChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSave.IconColor = System.Drawing.Color.Black;
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.Location = new System.Drawing.Point(394, 392);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 40);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(255)))));
            this.buttonCancel.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonCancel.IconColor = System.Drawing.Color.Black;
            this.buttonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCancel.Location = new System.Drawing.Point(310, 392);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 40);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Task Manager";
            this.notify.Visible = true;
            this.notify.BalloonTipClicked += new System.EventHandler(this.notify_BalloonTipClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // addTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pickerTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.pickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textboxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textboxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addTask";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.addTask_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addTask_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Label labelTitle;
        private FontAwesome.Sharp.IconButton buttonCancel;
        private FontAwesome.Sharp.IconButton buttonSave;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        public System.Windows.Forms.TextBox textboxTitle;
        public System.Windows.Forms.TextBox textboxDescription;
        public System.Windows.Forms.DateTimePicker pickerDate;
        public System.Windows.Forms.DateTimePicker pickerTime;
        public System.Windows.Forms.NotifyIcon notify;
        public System.Windows.Forms.Label labelAddTask;
        public System.Windows.Forms.Timer timer1;
    }
}