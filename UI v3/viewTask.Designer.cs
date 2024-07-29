namespace taskManager
{
    partial class viewTasks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.taskName = new System.Windows.Forms.Label();
            this.taskDescription = new System.Windows.Forms.Label();
            this.taskDate = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.buttonEdit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Trebuchet MS", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskName.ForeColor = System.Drawing.SystemColors.Info;
            this.taskName.Location = new System.Drawing.Point(29, 37);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(59, 59);
            this.taskName.TabIndex = 0;
            this.taskName.Text = "..";
            // 
            // taskDescription
            // 
            this.taskDescription.AutoSize = true;
            this.taskDescription.Font = new System.Drawing.Font("Corbel", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDescription.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.taskDescription.Location = new System.Drawing.Point(32, 148);
            this.taskDescription.Name = "taskDescription";
            this.taskDescription.Size = new System.Drawing.Size(211, 35);
            this.taskDescription.TabIndex = 4;
            this.taskDescription.Text = "Task Description";
            this.taskDescription.Click += new System.EventHandler(this.taskDescription_Click);
            // 
            // taskDate
            // 
            this.taskDate.AutoSize = true;
            this.taskDate.Font = new System.Drawing.Font("HP Simplified Hans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskDate.ForeColor = System.Drawing.SystemColors.Info;
            this.taskDate.Location = new System.Drawing.Point(93, 310);
            this.taskDate.Name = "taskDate";
            this.taskDate.Size = new System.Drawing.Size(120, 29);
            this.taskDate.TabIndex = 5;
            this.taskDate.Text = "Due Date";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(39, 300);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 49);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.buttonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEdit.Location = new System.Drawing.Point(827, 542);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(83, 60);
            this.buttonEdit.TabIndex = 7;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // viewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.taskDate);
            this.Controls.Add(this.taskDescription);
            this.Controls.Add(this.taskName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewTasks";
            this.Size = new System.Drawing.Size(941, 622);
            this.Load += new System.EventHandler(this.viewTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label taskName;
        public System.Windows.Forms.Label taskDescription;
        public System.Windows.Forms.Label taskDate;
        private FontAwesome.Sharp.IconButton buttonEdit;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
