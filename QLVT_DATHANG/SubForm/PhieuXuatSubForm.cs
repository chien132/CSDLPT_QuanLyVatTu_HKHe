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
    public partial class PhieuXuatSubForm : DevExpress.XtraEditors.XtraForm
    {
        public PhieuXuatSubForm()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void PhieuXuatSubForm_Load(object sender, EventArgs e)
        {
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Kho' table. You can move, or remove it, as needed.
            this.khoTableAdapter.Fill(this.qLVT_DATHANGDataSet.Kho);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuXuatSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.nhanVienForm.Enabled = true;
            Program.mainForm.Enabled = true;

        }
    }
}