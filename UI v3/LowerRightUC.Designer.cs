namespace UI_v3
{
    partial class LowerRightUC
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
            this.labelmainOne = new System.Windows.Forms.Label();
            this.labelmainTwo = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmainOne
            // 
            this.labelmainOne.AutoSize = true;
            this.labelmainOne.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmainOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelmainOne.Location = new System.Drawing.Point(121, 49);
            this.labelmainOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmainOne.Name = "labelmainOne";
            this.labelmainOne.Size = new System.Drawing.Size(668, 52);
            this.labelmainOne.TabIndex = 0;
            this.labelmainOne.Text = "You have no tasks at the moment";
            // 
            // labelmainTwo
            // 
            this.labelmainTwo.AutoSize = true;
            this.labelmainTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmainTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelmainTwo.Location = new System.Drawing.Point(79, 590);
            this.labelmainTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmainTwo.Name = "labelmainTwo";
            this.labelmainTwo.Size = new System.Drawing.Size(299, 29);
            this.labelmainTwo.TabIndex = 1;
            this.labelmainTwo.Text = "Start now and add a task!";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 587);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(43, 39);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // LowerRightUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(158)))), ((int)(((byte)(160)))));
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.labelmainTwo);
            this.Controls.Add(this.labelmainOne);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LowerRightUC";
            this.Size = new System.Drawing.Size(963, 624);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmainOne;
        private System.Windows.Forms.Label labelmainTwo;
        public FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
