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
    public partial class FilterationUC : UserControl
    {
        public static taskManager.mainForm parentForm {get;set;}

        public FilterationUC()
        {
            InitializeComponent();
        }

        public DateTime FromDate
        {
            get { return fromFilterPicker.Value; }
            set { fromFilterPicker.Value = value; }
        }

        public DateTime ToDate
        {
            get { return toFilterPicker.Value; }
            set { toFilterPicker.Value = value; }
        }

        public void resetFilterDetails()
        {
            fromFilterPicker.Value = DateTime.Today;
            toFilterPicker.Value = DateTime.Today.AddDays(1);
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
