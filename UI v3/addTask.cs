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
    public partial class addTask : Form
    {

        mainForm parentForm;

        public addTask(mainForm _parentForm)
        {
            InitializeComponent();
            parentForm = _parentForm;
        }


        private void addTask_Load(object sender, EventArgs e)
        {
            int sec = DateTime.Now.Second;

            pickerDate.Value = DateTime.Today;
            pickerTime.Value = DateTime.Now.AddSeconds(-sec);
            if (this.WindowState == FormWindowState.Normal)
            { notify.Visible = false; }
        }

        string textboxcopy;
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (labelAddTask.Text == "Edit Task")
            {
                textboxTitle.Text = textboxcopy;
                this.Visible = false;
                notify.Visible = false;
            }
            else
            {
                this.Close();
            }
        }

        private void isEmpty()
        {
            if (textboxTitle.Text == "")
            {
                textboxTitle.ForeColor = Color.LightGray;
                textboxTitle.Text = "Enter the title here...";
            }
            if (textboxDescription.Text == "")
            {
                textboxDescription.Text = "Enter the description here...";
                textboxDescription.ForeColor = Color.LightGray;
            }
        }

        private void textboxDescription_Click(object sender, EventArgs e)
        {
            isEmpty();

            if (textboxDescription.Text == "Enter the description here...")
            {
                textboxDescription.ForeColor = Color.Black;
                textboxDescription.Text = "";
            }

        }
        //
        private void textboxTitle_Click(object sender, EventArgs e)
        {
            isEmpty();

            if (textboxTitle.Text == "Enter the title here...")
            {
                textboxTitle.ForeColor = Color.Black;
                textboxTitle.Text = "";
            }
        }

        private void pickerDate_DropDown(object sender, EventArgs e)
        {
            isEmpty();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {   
            textboxcopy = textboxTitle.Text; //takes a copy of the textboxtitle

            if (labelAddTask.Text == "Edit Task")
            {
                Task temp = (Task)parentForm.listBoxTasks.SelectedItem;
                mainForm.listTasks.Remove(temp);
                parentForm.textBoxSearch.AutoCompleteCustomSource.Remove(temp.Title);
            }

            if (textboxTitle.Text == "Enter the title here..." || textboxTitle.Text == "")
                MessageBox.Show("You forgot to enter a title!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(textboxTitle.Text))
            {
                MessageBox.Show("Your title can't consist of spaces only!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (textboxDescription.Text == "Enter the description here...")
                    mainForm.listTasks.Add(new Task(textboxTitle.Text, "", pickerDate.Value, pickerTime.Value, this));
                else
                    mainForm.listTasks.Add(new Task(textboxTitle.Text, textboxDescription.Text, pickerDate.Value, pickerTime.Value, this));

                if (labelAddTask.Text == "Edit Task")
                {
                    parentForm.textBoxSearch.AutoCompleteCustomSource.Add(textboxTitle.Text);
                    MessageBox.Show("Task edited succefully");
                    timer1.Stop();
                    timer1.Start();
                    this.Visible = false;
                }
                else
                {
                    parentForm.textBoxSearch.AutoCompleteCustomSource.Add(textboxTitle.Text);
                    MessageBox.Show("Task added succefully");
                    timer1.Start();
                    this.Visible = false;
                }
            }
            parentForm.resort();
            parentForm.refresh();
        }

        private void textboxTitle_KeyDown(object sender, KeyEventArgs e)
        {
            textboxTitle.ForeColor = Color.Black;
        }

        DateTime duedate = new DateTime();
        DateTime duetime = new DateTime();
        bool flag = false;

        private void pickerDate_ValueChanged(object sender, EventArgs e)
        {
            isEmpty();
            duedate = pickerDate.Value;
            if (!flag)
            {
                pickerTime.Value = duedate;
            }
        }

        private void pickerTime_ValueChanged(object sender, EventArgs e)
        {
            isEmpty();
            duetime = pickerTime.Value;
            flag = true;
        }

        int seconds = 0;
        private void timer_Tick(object sender, EventArgs e) //ticks every 1 second
        {
            bool check = false;
            foreach (Task list in mainForm.listTasks)
            {
                if (list.Title == textboxTitle.Text)
                    check = true;
            }
            if (check == false)
            {
                timer1.Stop();
            }

            if (DateTime.Now >= duetime.AddMinutes(60))
            {
                notify.ShowBalloonTip(5000, "Task", "your task: '" + textboxTitle.Text + "' is Overdue by 1 hour", ToolTipIcon.Warning);
                timer1.Stop();
            }
            else if (DateTime.Now >= duetime)
            {
                if (DateTime.Now.Second == duetime.Second && DateTime.Now.Minute == duetime.Minute && DateTime.Now.Hour == duetime.Hour)
                {
                    notify.Visible = true;
                    notify.ShowBalloonTip(5000, "Task", "your task: '" + textboxTitle.Text + "' is Due Now", ToolTipIcon.None);
                    notify.Visible = false;
                }
                else if (seconds % 300 == 0 && DateTime.Now >= duetime.AddMinutes(5))
                {
                    notify.Visible = true;
                    notify.ShowBalloonTip(5000, "Task", "your task: '" + textboxTitle.Text + "' is Over due by: " + seconds/60 + " minutes", ToolTipIcon.None);
                    notify.Visible = false;
                }
            }
            else if (DateTime.Today == duedate)
            {
                if (seconds % 3600 == 0)
                {
                    notify.Visible = true;
                    notify.ShowBalloonTip(5000, "Task", "your task: '" + textboxTitle.Text + "' is Due Today", ToolTipIcon.None);
                    notify.Visible = false;
                }
            }
            seconds++; //minute counter
        }

        private void notify_BalloonTipClicked(object sender, EventArgs e) //when you click on a notification
        {
            notify.ShowBalloonTip(1000, "'", textboxTitle.Text + "'  marked as done!", ToolTipIcon.Info);
            notify.Visible = false;
            timer1.Stop();
        }

        private void addTask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                buttonCancel.PerformClick();
        }

    }
}
