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
    public partial class CTDDHSubForm : DevExpress.XtraEditors.XtraForm
    {
        public CTDDHSubForm()
        {
            InitializeComponent();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vattuBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVT_DATHANGDataSet);

        }

        private void CTDDHSubForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLVT_DATHANGDataSet.Vattu' table. You can move, or remove it, as needed.
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.nhanVienForm.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.nhanVienForm.Enabled = true;
        }

        private void nuDonGia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dONGIALabel_Click(object sender, EventArgs e)
        {

        }

        private void sOLUONGLabel_Click(object sender, EventArgs e)
        {

        }

        private void nuSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbMaVT_TextChanged(object sender, EventArgs e)
        {

        }

        private void mAVTLabel1_Click(object sender, EventArgs e)
        {

        }

        private void masoDDHLabel_Click(object sender, EventArgs e)
        {

        }

        private void tbMasoDDH_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.nhanVienForm.Enabled = true;
        }
    }
}