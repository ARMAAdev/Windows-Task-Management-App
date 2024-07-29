using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskManager
{
    public partial class viewTasks : UserControl
    {
        public viewTasks()
        {
            InitializeComponent();
        }

        public static mainForm parentForm { get; set; }

        private void viewTasks_Load(object sender, EventArgs e)
        {

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (parentForm.listBoxTasks.SelectedItems.Count > 1)
            {
                MessageBox.Show("Cannot Edit Multiple Tasks at once.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                Task selectedTask = (Task)parentForm.listBoxTasks.SelectedItem;
                selectedTask.Form.labelAddTask.Text = "Edit Task";
                selectedTask.Form.ShowDialog();
            }
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void taskDescription_Click(object sender, EventArgs e)
        {
            
        }
    }
}
