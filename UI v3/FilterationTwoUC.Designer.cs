namespace UI_v3
{
    partial class FilterationTwoUC
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
            this.cancelFilter = new System.Windows.Forms.Label();
            this.toFilterLabel = new System.Windows.Forms.Label();
            this.fromFilterLabel = new System.Windows.Forms.Label();
            this.fromFilterPicker = new System.Windows.Forms.DateTimePicker();
            this.toFilterPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cancelFilter
            // 
            this.cancelFilter.AutoSize = true;
            this.cancelFilter.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.cancelFilter.Location = new System.Drawing.Point(324, 24);
            this.cancelFilter.Name = "cancelFilter";
            this.cancelFilter.Size = new System.Drawing.Size(20, 20);
            this.cancelFilter.TabIndex = 9;
            this.cancelFilter.Text = "X";
            this.cancelFilter.Click += new System.EventHandler(this.cancelFilter_Click);
            // 
            // toFilterLabel
            // 
            this.toFilterLabel.AutoSize = true;
            this.toFilterLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.toFilterLabel.Location = new System.Drawing.Point(75, 36);
            this.toFilterLabel.Name = "toFilterLabel";
            this.toFilterLabel.Size = new System.Drawing.Size(26, 18);
            this.toFilterLabel.TabIndex = 8;
            this.toFilterLabel.Text = "To:";
            // 
            // fromFilterLabel
            // 
            this.fromFilterLabel.AutoSize = true;
            this.fromFilterLabel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFilterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(207)))), ((int)(((byte)(208)))));
            this.fromFilterLabel.Location = new System.Drawing.Point(66, 10);
            this.fromFilterLabel.Name = "fromFilterLabel";
            this.fromFilterLabel.Size = new System.Drawing.Size(44, 18);
            this.fromFilterLabel.TabIndex = 7;
            this.fromFilterLabel.Text = "From:";
            // 
            // fromFilterPicker
            // 
            this.fromFilterPicker.CalendarFont = new System.Drawing.Font("Yu Gothic UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromFilterPicker.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.fromFilterPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.fromFilterPicker.CustomFormat = "hh:mm tt";
            this.fromFilterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromFilterPicker.Location = new System.Drawing.Point(171, 10);
            this.fromFilterPicker.Margin = new System.Windows.Forms.Padding(2);
            this.fromFilterPicker.Name = "fromFilterPicker";
            this.fromFilterPicker.ShowUpDown = true;
            this.fromFilterPicker.Size = new System.Drawing.Size(98, 20);
            this.fromFilterPicker.TabIndex = 15;
            // 
            // toFilterPicker
            // 
            this.toFilterPicker.CalendarFont = new System.Drawing.Font("Yu Gothic UI Semilight", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFilterPicker.CalendarForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.toFilterPicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.toFilterPicker.CustomFormat = "hh:mm tt";
            this.toFilterPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toFilterPicker.Location = new System.Drawing.Point(171, 36);
            this.toFilterPicker.Margin = new System.Windows.Forms.Padding(2);
            this.toFilterPicker.Name = "toFilterPicker";
            this.toFilterPicker.ShowUpDown = true;
            this.toFilterPicker.Size = new System.Drawing.Size(98, 20);
            this.toFilterPicker.TabIndex = 16;
            // 
            // FilterationTwoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(95)))), ((int)(((byte)(96)))));
            this.Controls.Add(this.toFilterPicker);
            this.Controls.Add(this.fromFilterPicker);
            this.Controls.Add(this.cancelFilter);
            this.Controls.Add(this.toFilterLabel);
            this.Controls.Add(this.fromFilterLabel);
            this.Name = "FilterationTwoUC";
            this.Size = new System.Drawing.Size(410, 67);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cancelFilter;
        private System.Windows.Forms.Label toFilterLabel;
        private System.Windows.Forms.Label fromFilterLabel;
        public System.Windows.Forms.DateTimePicker fromFilterPicker;
        public System.Windows.Forms.DateTimePicker toFilterPicker;
    }
}
