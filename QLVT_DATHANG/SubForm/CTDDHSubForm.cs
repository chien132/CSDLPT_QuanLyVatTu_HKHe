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
        private bool isSuccess = false;

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
            this.qLVT_DATHANGDataSet.EnforceConstraints = false;

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.qLVT_DATHANGDataSet.Vattu);
            this.cTDDHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDDHTableAdapter.Fill(this.qLVT_DATHANGDataSet.CTDDH);
            this.cTDDHBindingSource.DataSource = Program.nhanVienForm.getCTDatHangBDS();

        }

        private void CTDDHSubForm_Shown(object sender, EventArgs e)
        {
            ////Đặt trong Event Load thì Thread kết thúc sớm hơn Fill nên không đồng bộ, nên dùng Event có thứ tự sau
            this.cTDDHBindingSource.AddNew();

            /* 
             * Không hiểu sao không cập nhật MasoDDH trong CTDDH mà lại tự sinh ra MasoDDH,
             * nên chỗ này nếu ta set MasoDDH lần nữa thì sẽ phát sinh lỗi EndEdit không được      
            */
            BindingSource tempDDH = Program.nhanVienForm.getDatHangBDS();
            string valueMasoDDH = getDataRow(tempDDH, "MasoDDH");
            masoDDHTextEdit.Text = valueMasoDDH;
            mAVTTextEdit.Text = ((DataRowView)vattuBindingSource[vattuBindingSource.Position])["MAVT"].ToString().Trim();
            //setDataRow(this.cTDDHBDS, "MasoDDH", valueMasoDDH);
            ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["SOLUONG"] = 1;
            ((DataRowView)cTDDHBindingSource[cTDDHBindingSource.Position])["DONGIA"] = 0;
            sOLUONGSpinEdit.Value = 1;
            dONGIASpinEdit.Value = 0;
        }

        private bool checkValidate(TextEdit tb, string str)
        {
            if (tb.Text.Trim().Equals(""))
            {
                MessageBox.Show(str, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkValidate(mAVTTextEdit, "Mã VT không được trống!")) return;
            if (sOLUONGSpinEdit.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dONGIASpinEdit.Value == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra trùng CTDDH
            int positionMaVT = cTDDHBindingSource.Find("MAVT", mAVTTextEdit.Text);
            if (positionMaVT != -1 && (positionMaVT != cTDDHBindingSource.Position))
            {
                MessageBox.Show("Trùng Mã số DDH & Mã VT của chi tiết Đơn Đặt Hàng khác!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào Database?", "Thông báo",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                try
                {
                    this.cTDDHBindingSource.EndEdit();
                    this.cTDDHTableAdapter.Update(Program.nhanVienForm.getDataSet().CTDDH);
                    isSuccess = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Lỗi cho New lại cái mới(nếu không dữ liệu lúc này là Position của phần tử cuối)
                    this.cTDDHBindingSource.AddNew();
                    mAVTTextEdit.Text = getDataRow(vattuBindingSource, "MAVT");
                    sOLUONGSpinEdit.Value = 1;
                    dONGIASpinEdit.Value = 0;
                }
            }
        }


        private void CTDDHSubForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isSuccess) cTDDHBindingSource.CancelEdit();
            Program.mainForm.Enabled = true;
        }


        private string getDataRow(BindingSource bindingSource, string column)
        {
            return ((DataRowView)bindingSource[bindingSource.Position])[column].ToString().Trim();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            mAVTTextEdit.Text = getDataRow(vattuBindingSource, "MAVT");
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}