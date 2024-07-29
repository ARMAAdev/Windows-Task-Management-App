using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using UI_v3;
//errors to fix: viewtask not updating
// look at notification timing
namespace taskManager
{
    public partial class mainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] // Makes the form Rounded (Copied From The Internet)
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public static List<Task> listTasks = new List<Task>();
        public static List<Task> listTasksSorted = new List<Task>();
        public static List<Task> listTasksFiltered = new List<Task>();

        BindingSource taskBindingSource = new BindingSource();

        public mainForm()
        {      
            InitializeComponent();
            useMyUI();
            dateAddedToolStripMenuItem.PerformClick();
            viewTasks.parentForm = this;
            FilterationUC.parentForm = FilterationTwoUC.parentForm = this;
            // GenerateTestCases();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Con't (Copied From The Internet)
        }

        void setList(List<Task> T1)
        {
            taskBindingSource.DataSource = T1;
            listBoxTasks.DataSource = taskBindingSource;
            listBoxTasks.DisplayMember = "Title";
            refresh();
        }

        void dynamicSort(int sortBy)
        {
            switch (sortBy)
            {
                case 1: // Sort by Task title
                    listTasksSorted = listTasks.OrderBy(order => order.Title).ToList();
                    setList(listTasksSorted);
                    break;

                case 2: // Sort by Task Date
                    listTasksSorted = listTasks.OrderBy(order => order.Date.ToString()).ToList();
                    setList(listTasksSorted);
                    break;

                case 0: // Sort by Date Added (Default)
                default:
                    setList(listTasks);
                    refresh();
                    break;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addTask temp = new addTask(this);
            temp.FormBorderStyle = FormBorderStyle.None;
            temp.Owner = this;
            temp.ShowDialog();
        }

        public void refresh()
        {
            
            if (textBoxSearch.Text == "")
            {
                //textBoxSearch.Visible = false;
                searchCancel.Visible = false;
            }

            taskBindingSource.ResetBindings(false);
        }

        public void resort()
        {
            dateAddedToolStripMenuItem.PerformClick();
            if (buttonSort.IconChar == FontAwesome.Sharp.IconChar.SortAlphaDown)
            {
                alphabeticalToolStripMenuItem.PerformClick();
            }
            else if (buttonSort.IconChar == FontAwesome.Sharp.IconChar.Clock)
            {
                dueDateToolStripMenuItem.PerformClick();
            }
        }
        public void resetBS()
        {
            taskBindingSource.DataSource = listTasks;
            refresh();
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            resetBS();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedItem != null)
            {
                List<Task> selectedTasks = new List<Task>();
                foreach (Task i in listBoxTasks.SelectedItems)
                {
                    selectedTasks.Add((Task)i);
                }

                DialogResult result = new DialogResult();
                if (listBoxTasks.SelectedItems.Count > 1)
                    result = MessageBox.Show("Are you sure you want to delete the selected tasks?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                else
                    result = MessageBox.Show("Are you sure you want to delete the selected task?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (Task i in selectedTasks)
                    {
                        i.Form.timer1.Stop();
                        textBoxSearch.AutoCompleteCustomSource.Remove(i.Title);
                        listTasks.Remove(i);
                    }
                    resetBS();
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void dateAddedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSort.IconChar = FontAwesome.Sharp.IconChar.Sort; // Icons vary in size so relocation
            buttonSort.Location = new System.Drawing.Point(28, 18); // is needed to be more seemless
            dynamicSort(0);
        }

        public void alphabeticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSort.IconChar = FontAwesome.Sharp.IconChar.SortAlphaDown;
            buttonSort.Location = new System.Drawing.Point(21, 20);
            dynamicSort(1);
        }

        public void dueDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSort.IconChar = FontAwesome.Sharp.IconChar.Clock;
            buttonSort.Location = new System.Drawing.Point(28, 18);
            dynamicSort(2);
        }

        private void listBoxTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                buttonDelete_Click(sender, e);
            if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
                buttonAdd_Click(sender, e);
        }


        bool exitFlag = false;
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifymainForm.Visible = true;

            if (!exitFlag)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifymainForm.Visible = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitFlag = true;
            this.Close();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            notifymainForm.Visible = false;
        }

        private void notifymainForm_DoubleClick(object sender, EventArgs e)
        {
            restoreToolStripMenuItem_Click(sender, e);
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifymainForm.Visible = true;
            }

            if (this.WindowState == FormWindowState.Normal)
                notifymainForm.Visible = true;

        }

        void showTasks()
        {
            if (listBoxTasks.SelectedItem != null)
            {
                foreach (Task task in listTasks)
                {
                    if (listBoxTasks.Text == task.Title)
                    {
                        viewTask.taskName.Text = task.Title;
                        viewTask.taskDescription.Text = task.Description;
                        viewTask.taskDate.Text = task.Date.ToShortDateString() + " " + task.Time.ToShortTimeString();
                        viewTask.Visible = true;
                    }
                }
            }
        }

        private void listBoxTasks_Click(object sender, EventArgs e)
        {
            showTasks();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;   
            if(textBoxSearch.Text != "")
            {
                textBoxSearch_TextChanged(sender, e);
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTasks.Count == 0)
            {
                viewTask.Visible = false;
            }
            else
                showTasks();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (filterationUC1.Visible == true)
                filterationUC1.cancel();
            if (filterationTwoUC1.Visible == true)
                filterationTwoUC1.cancel();
            if (calenderDropdown.Visible == true)
                buttonCalender.PerformClick();

            searchCancel.Visible = true;
            listTasksFiltered = listTasks.FindAll(x => x.Title.Contains(textBoxSearch.Text));
            setList(listTasksFiltered);
        }

        private void searchCancel_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "";
            textBoxSearch.Visible = false;
            resetBS();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                searchCancel_Click(sender, e);
            if (e.KeyCode == Keys.Enter)
            {
                buttonSearch_Click(sender, e);
                textBoxSearch.DeselectAll();
                SendKeys.SendWait("^{RIGHT}");
            }
        }

        public int click;
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (click == 0) // Sort by Task title
            {
                alphabeticalToolStripMenuItem.PerformClick();
                click++;
            }
            else if(click ==1) // Sort by Due Date
            {
                dueDateToolStripMenuItem.PerformClick();
                click++;
            }
            else if(click == 2) // Sort by Date Added
            {
                dateAddedToolStripMenuItem.PerformClick();
                click = 0;
            }
        }

        private void dateFilterItem_Click(object sender, EventArgs e)
        {
            if (filterationTwoUC1.Visible == true)
                filterationTwoUC1.cancel();
            if (calenderDropdown.Visible == true)
            {
                buttonCalender.PerformClick();
            }
                filterationUC1.resetFilterDetails();
            //textBoxSearch.Visible = false;
            //buttonSearch.Visible = false;
            filterationUC1.Visible = true;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (filterationUC1.Visible == true)
            {
                listTasksFiltered = listTasks.FindAll(x => x.Date >= filterationUC1.FromDate && x.Date <= filterationUC1.ToDate);
                setList(listTasksFiltered);
            }
            if (filterationTwoUC1.Visible == true)
            {
                listTasksFiltered = listTasks.FindAll(x => x.Time >= filterationTwoUC1.FromTime && x.Time <= filterationTwoUC1.ToTime);
                setList(listTasksFiltered);
            }
        }

        private void timeFilterItem_Click(object sender, EventArgs e)
        {
            if (filterationUC1.Visible == true)
                filterationUC1.cancel();
            if (calenderDropdown.Visible == true)
                buttonCalender.PerformClick();
            
            filterationTwoUC1.resetFilterDetails();
            //textBoxSearch.Visible = false;
            //buttonSearch.Visible = false;
            filterationTwoUC1.Visible = true;
        }

        private void buttonCalender_Click(object sender, EventArgs e)
        {
            if (calenderDropdown.Visible == false)
            {
                calenderDropdown.Visible = true;
                DateTime[] taskDatesArr = new DateTime[1000];
                int i = 0;

                foreach (var task in listTasks)
                {
                    taskDatesArr[i] = task.Date;
                    i++;
                }
                this.calenderDropdown.BoldedDates = taskDatesArr;
            }
            else
            {
                calenderDropdown.Visible = false;
                refresh();
            }
                filterationTwoUC1.cancel();
                filterationUC1.cancel();
        }

        private void calenderDropdown_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            listTasksFiltered = listTasks.FindAll(x => x.Date >= calenderDropdown.SelectionStart && x.Date <= calenderDropdown.SelectionEnd);
            setList(listTasksFiltered);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            myUI.theme++;
            myUI.theme %= 5;
            useMyUI();
        }
    }
}

        //void GenerateTestCases() // this method just adds tasks and it's for test purposes only
        //{
        //    DateTime day = DateTime.Today.AddDays(10);
        //    DateTime time = DateTime.Now.AddHours(10);

        //    addTask test0 = new addTask(this);
        //    addTask test1 = new addTask(this);
        //    addTask test2 = new addTask(this);
        //    addTask test3 = new addTask(this);
        //    addTask test4 = new addTask(this);
        //    addTask test5 = new addTask(this);
        //    addTask test6 = new addTask(this);
        //    addTask test7 = new addTask(this);
        //    addTask test8 = new addTask(this);


        //    test0.FormBorderStyle = test1.FormBorderStyle = test2.FormBorderStyle
        //        = test3.FormBorderStyle = test4.FormBorderStyle = test5.FormBorderStyle
        //        = test6.FormBorderStyle = test7.FormBorderStyle = test8.FormBorderStyle
        //        = FormBorderStyle.None;

        //    test0.Owner = test1.Owner = test2.Owner = test3.Owner = test4.Owner
        //        = test5.Owner = test6.Owner = test7.Owner = test8.Owner
        //        = this;

        //    listTasks.Add(new Task("Study", "Math", day, time, test0));
        //    listTasks.Add(new Task("Eat", "Breakfast", day, time, test1));
        //    listTasks.Add(new Task("Drink", "Juice", day, time, test2));
        //    listTasks.Add(new Task("Dress", "Outfit", day, time, test3));
        //    listTasks.Add(new Task("Sleep", "8 Hours", day, time, test4));
        //    listTasks.Add(new Task("Dance", "With GF", day, time, test5));
        //    listTasks.Add(new Task("Ammend", "Your roles", day, time, test6));
        //    listTasks.Add(new Task("Code 2", "Stored on desktop", day, time, test7));
        //    listTasks.Add(new Task("Code 1", "Stored in downloads", day, time, test8));
        //}