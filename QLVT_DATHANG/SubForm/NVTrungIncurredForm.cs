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
    public partial class NVTrungIncurredForm : DevExpress.XtraEditors.XtraForm
    {
        public NVTrungIncurredForm()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sP_CheckNVTrungTableAdapter.Fill(this.qLVT_DATHANGDataSet_NVTrung.SP_CheckNVTrung, new System.Nullable<int>(((int)(System.Convert.ChangeType(mANVToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void NVTrungIncurredForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.mainForm.Enabled = true;
        }

        private void NVTrungIncurredForm_Load(object sender, EventArgs e)
        {
            /*
             * Trước khi đổ dữ liệu cần cập nhập Connection của Adapter điều này xảy ra khi
             * Trường hợp này xảy ra khi đăng nhập từ 1 Nhân viên ở CN2 và cần GrowTable dữ liệu cũng của CN2
            */
            this.sP_CheckNVTrungTableAdapter.Connection.ConnectionString = Program.connstr;
            try
            {
                this.sP_CheckNVTrungTableAdapter.Fill(this.qLVT_DATHANGDataSet_NVTrung.SP_CheckNVTrung, Program.maNVChuyenCN);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}