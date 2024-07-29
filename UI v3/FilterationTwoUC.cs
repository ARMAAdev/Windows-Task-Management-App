using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_v3
{


    public partial class FilterationTwoUC : UserControl
    {
        public static taskManager.mainForm parentForm { get; set; }

        public FilterationTwoUC()
        {
            InitializeComponent();
        }

        public DateTime FromTime
        {
            get { return fromFilterPicker.Value; }
        }

        public DateTime ToTime
        {
            get { return toFilterPicker.Value; }
        }

        public void resetFilterDetails()
        {
            fromFilterPicker.Value = DateTime.Now;
            toFilterPicker.Value = DateTime.Now.AddHours(10);
        }

        public void cancel()
        {
            cancelFilter_Click(null, null);
        }

        private void cancelFilter_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            parentForm.refresh();
        }
    }
}
