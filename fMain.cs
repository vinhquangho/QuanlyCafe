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
            LoadComboboxStatus(ccbAreaStatus);
            LoadComboboxStatus(cbbTableStatus);
            LoadComboboxStatus(cbbCategoryStatus);
            LoadComboboxStatus(ccbFoodStatus);
            LoadComboboxStatus(cbbAccountStatus);
            BindingArea();
            BindingTable();
            BindingCategory();
            BindingFood();
            BindingAccount();
            LoadCombboxArea();
            LoadComboboxFood();
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
            // add nút xóa vào datagridview
            if (dgvAccount.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvAccount.Columns.Insert(6, btnDelete);
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

            // add nút xóa vào datagridview
            if (dgvArea.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvArea.Columns.Insert(4, btnDelete);
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

            // add nút xóa vào datagridview
            if (dgvTable.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvTable.Columns.Insert(5, btnDelete);
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


            // add nút xóa vào datagridview
            if (dgvCategory.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvCategory.Columns.Insert(4, btnDelete);
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


            // add nút xóa vào datagridview
            if (dgvFood.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvFood.Columns.Insert(6, btnDelete);
            }

            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        #endregion
        #region binding data

        private void BindingArea()
        {
            txtAreaId.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtAreaName.DataBindings.Add(new Binding("Text", dgvArea.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        private void BindingTable()
        {
            txtTableId.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtTableName.DataBindings.Add(new Binding("Text", dgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        private void BindingCategory()
        {
            txtCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }
        private void BindingFood()
        {
            txtFoodId.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txtFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        private void BindingAccount()
        {
            txtAccountId.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtAccountUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtAccountDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DislayName", true, DataSourceUpdateMode.Never));
            txtAccountPassword.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Password", true, DataSourceUpdateMode.Never));
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

        private List<Select> GetSatus()
        {
            return new List<Select>()
            {
                new Select(){ Id = 1 , Name = "Đang hoạt động" },
                new Select(){ Id = 2, Name = "Ngừng hoạt động" }
            };
        }
        private void LoadComboboxStatus(ComboBox comboBox)
        {
            comboBox.DataSource = GetSatus();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }
        private void LoadCombboxArea()
        {
            var list = _dbContext.AreaTables.ToList();
            cbbAreaTable.DataSource = list;
            cbbAreaTable.DisplayMember = "Name";
            cbbAreaTable.ValueMember = "Id";
        }
        private void LoadComboboxFood()
        {
            var list = _dbContext.Categories.ToList();
            cbbFoodCategory.DataSource = list;
            cbbFoodCategory.DisplayMember = "Name";
            cbbFoodCategory.ValueMember = "Id";
        }
        private void txtAreaId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvArea.SelectedCells.Count > 0)
                {
                    int id = (int)dgvArea.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    ccbAreaStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }

        private void txtTableId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTable.SelectedCells.Count > 0)
                {
                    int id = (int)dgvTable.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    cbbTableStatus.SelectedIndex = index;

                    var areaId = (int)dgvTable.SelectedCells[0].OwningRow.Cells["AreaTableId"].Value;
                    var areaIndex = _dbContext.AreaTables.ToList().FindIndex(f => f.Id == areaId);
                    cbbAreaTable.SelectedIndex = areaIndex;
                }
            }
            catch (Exception exception) { }
        }

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategory.SelectedCells.Count > 0)
                {
                    int id = (int)dgvCategory.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    cbbCategoryStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }

        private void txtFoodId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFood.SelectedCells.Count > 0)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    ccbFoodStatus.SelectedIndex = index;

                    var foodId = (int)dgvTable.SelectedCells[0].OwningRow.Cells["CategoryId"].Value;
                    var foodIndex = _dbContext.Categories.ToList().FindIndex(f => f.Id == foodId);
                    cbbFoodCategory.SelectedIndex = foodIndex;
                }
            }
            catch (Exception exception) { }
        }

        private void txtAccountId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccount.SelectedCells.Count > 0)
                {
                    int id = (int)dgvFood.SelectedCells[0].OwningRow.Cells["Status"].Value;
                    var index = GetSatus().FindIndex(x => x.Id == id);
                    cbbAccountStatus.SelectedIndex = index;
                }
            }
            catch (Exception exception) { }
        }
        private void dgvaccount_cellformatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvAccount.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }
        private void dgvFood_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFood.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
            if (dgvFood.Columns[e.ColumnIndex].Name == "CategoryId")
            {
                var id = (int)e.Value;
                e.Value = _dbContext.Categories.FirstOrDefault(f => f.Id == id).Name;
            }
        }

        private void dgvCategory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCategory.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }

        private void dgvTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvTable.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "AreaTableId")
            {
                var id = (int)e.Value;
                e.Value = _dbContext.AreaTables.FirstOrDefault(f => f.Id == id).Name;
            }
        }

        private void dgvArea_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvArea.Columns[e.ColumnIndex].Name == "Status")
            {
                var enumdata = (Status)e.Value;
                e.Value = enumdata.GetType().GetMember(enumdata.ToString()).First().GetCustomAttribute<DisplayAttribute>()?.GetName();
            }
        }
    }
}
