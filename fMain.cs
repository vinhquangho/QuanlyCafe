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
            dgvArea.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
            dgvArea.Columns["Name"].HeaderText = "Tên";
            dgvArea.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dgvArea.Columns["Status"].HeaderText = "Trạng thái";

            if (dgvArea.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvArea.Columns.Insert(4, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dgvArea.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvArea.Columns.Insert(5, btnDelete);
            }

            dgvArea.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadTable()
        {
            var list = _dbContext.Tables.ToList();
            dgvTable.DataSource = list;
            dgvTable.Columns["Id"].HeaderText = "Mã";
            dgvTable.Columns["Id"].ReadOnly = true;
            dgvTable.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
            dgvTable.Columns["Name"].HeaderText = "Tên";
            dgvTable.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dgvTable.Columns["Status"].HeaderText = "Trạng thái";
            dgvTable.Columns["AreaTableId"].HeaderText = "Khu vực";

            if (dgvTable.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvTable.Columns.Insert(5, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dgvTable.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvTable.Columns.Insert(6, btnDelete);
            }

            dgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadCategory()
        {
            var list = _dbContext.Categories.ToList();
            dgvCategory.DataSource = list;
            dgvCategory.Columns["Id"].HeaderText = "Mã";
            dgvCategory.Columns["Id"].ReadOnly = true;
            dgvCategory.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
            dgvCategory.Columns["Name"].HeaderText = "Tên";
            dgvCategory.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dgvCategory.Columns["Status"].HeaderText = "Trạng thái";

            if (dgvCategory.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvCategory.Columns.Insert(4, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dgvCategory.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCategory.Columns.Insert(5, btnDelete);
            }

            dgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadFood()
        {
            var list = _dbContext.Foods.ToList();
            dgvFood.DataSource = list;
            dgvFood.Columns["Id"].HeaderText = "Mã";
            dgvFood.Columns["Id"].ReadOnly = true;
            dgvFood.Columns["Id"].DefaultCellStyle.BackColor = Color.FromArgb(192, 192, 192);
            dgvFood.Columns["Name"].HeaderText = "Tên";
            dgvFood.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dgvFood.Columns["Status"].HeaderText = "Trạng thái";
            dgvFood.Columns["Price"].HeaderText = "Giá";
            dgvFood.Columns["CategoryId"].HeaderText = "Loại món";

            if (dgvFood.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dgvFood.Columns.Insert(6, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dgvFood.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvFood.Columns.Insert(7, btnDelete);
            }

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

        //private void dgvAccount_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (dgvAccount.Columns[e.ColumnIndex].Name == "Status")
        //    {
        //        var enumData = (Status)e.Value;
        //        e.Value = enumData.GetType().GetMember(enumData.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
        //    }
        //}
        private List<Select> GetSatus()
        {
            return new List<Select>()
            {
                new Select(){ Id = 1 , Name = "Đang hoạt động" },
                new Select(){ Id = 2, Name = "Ngừng hoạt động" }
            };
        }
    }
}
