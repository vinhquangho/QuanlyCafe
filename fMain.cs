using QuanlyCafe.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCafe
{
    public partial class fMain : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        public fMain()
        {
            InitializeComponent();
            LoadAccount();
        }
        #region load data
        public void LoadAccount()
        {
            var list = _dbContext.Accounts.ToList();
            dgvAccount.DataSource = list;
            dgvAccount.Columns["Id"].HeaderText = "Mã";
            dgvAccount.Columns["UserName"].HeaderText = "Tên đăng nhập";
            dgvAccount.Columns["DislayName"].HeaderText = "Tên hiển thị";
            dgvAccount.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dgvAccount.Columns["Status"].HeaderText = "Trạng thái";
            dgvAccount.Columns["Password"].HeaderText = "Mật khẩu";
            if (dgvAccount.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvAccount.Columns.Insert(6, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dgvAccount.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvAccount.Columns.Insert(7, btnDelete);
            }
        }
        public void LoadArea()
        {

        }
        public void LoadTable()
        {

        }
        public void LoadCategory()
        {

        }
        public void LoadFood()
        {

        }
        public void LoadBill()
        {

        }

        #endregion

        #region exe data
        private void btnCreateArea_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateArea_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateTable_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumData = (Status)e.Value;
                e.Value = enumData.GetType().GetMember(enumData.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }
    }
}
