using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLVT_DATHANG.SubForm
{
    public partial class CTPNSubForm : DevExpress.XtraEditors.XtraForm
    {
        public CTPNSubForm()
        {
            InitializeComponent();
        }

        private void cTDDHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cTDDHBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void CTPNSubForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.CTDDH' table. You can move, or remove it, as needed.
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CTPNSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.nhanVienForm.Enabled = true;
            Program.mainForm.Enabled = true;

        }
    }
}