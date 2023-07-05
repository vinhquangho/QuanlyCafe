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
            LoadArea();
            LoadTable();
            LoadCategory();
            LoadFood();
            LoadAccount();
        }
        #region load data
        public void LoadAccount()
        {
            var list = _dbContext.Accounts.ToList();
            dgvAccount.DataSource = list;
            dgvAccount.Columns["Id"].HeaderText = "Mã";
            dgvAccount.Columns["Id"].ReadOnly = true;
            dgvAccount.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);

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
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadArea()
        {
            var list = _dbContext.AreaTables.ToList();
            dgvArea.DataSource = list;
            dgvArea.Columns["Id"].HeaderText = "Mã";
            dgvArea.Columns["Id"].ReadOnly = true;
            dgvArea.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192,192,192);

            dgvArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadTable()
        {
            var list = _dbContext.Tables.ToList();
            dgvTable.DataSource = list;
            dgvTable.Columns["Id"].HeaderText = "Mã";
            dgvTable.Columns["Id"].ReadOnly = true;
            dgvTable.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192,192,192);

            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadCategory()
        {
            var list = _dbContext.Categories.ToList();
            dgvCategory.DataSource = list;
            dgvCategory.Columns["Id"].HeaderText = "Mã";
            dgvCategory.Columns["Id"].ReadOnly = true;
            dgvCategory.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192,192,192);

            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadFood()
        {
            var list = _dbContext.Foods.ToList();
            dgvFood.DataSource = list;
            dgvFood.Columns["Id"].HeaderText = "Mã";
            dgvFood.Columns["Id"].ReadOnly = true;
            dgvFood.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192,192,192);

            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion

        #region exe data
        private void btnCreateArea_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
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
