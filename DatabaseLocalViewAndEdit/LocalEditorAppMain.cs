using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseLocalViewAndEdit
{
    public partial class LocalEditorAppMain : Form
    {
        public LocalEditorAppMain()
        {
            InitializeComponent();
            dbSelector.Items.AddRange(RequestDBTableNames());
        }

        private void dbSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddRecord.Enabled = true;
            btnEditDeleteRecord.Enabled = true;
        }
    }
}
