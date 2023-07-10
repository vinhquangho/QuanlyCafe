using QuanlyCafe.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCafe
{
    public partial class fSwapTable : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        private CultureInfo culture = new CultureInfo("vi-VN");
        NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        public fSwapTable()
        {
            InitializeComponent();
            LoadComboboxFrom();
        }
        private void LoadComboboxFrom()
        {
            var list = _dbContext.Tables.Where(f => f.Status == Status.Active).ToList();
            cbbFrom.DataSource = list;
            cbbFrom.DisplayMember = "Name";
            cbbFrom.ValueMember = "Id";
        }

        private void cbbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvFrom.Items.Clear();
            lvTo.Items.Clear();

            var selectedValueComboboxFrom = (Table)cbbFrom.SelectedItem;
            var comboboxTo = _dbContext.Tables.Where(f => f.Id != selectedValueComboboxFrom.Id && f.Status == Status.Active).ToList();
            cbbTo.DataSource = comboboxTo;
            cbbTo.DisplayMember = "Name";
            cbbTo.ValueMember = "Id";

            var billForm = _dbContext.Bills.Include("BillInfos").Where(f => f.TableId == selectedValueComboboxFrom.Id && f.Status == Status.Active).FirstOrDefault();
            if(billForm != null)
            {
                foreach (var billInfo in billForm.BillInfos)
                {
                    var food = _dbContext.Foods.FirstOrDefault(f => f.Id == billInfo.FoodId);
                    ListViewItem item = new ListViewItem(new string[] { food.Name, billInfo.Count.ToString() });
                    item.Tag = billInfo.Id;
                    lvFrom.Items.Add(item);
                }
            }
            
        }

        private void cbbTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTo.Items.Clear();
            var selectedValueComboboxTo = (Table)cbbTo.SelectedItem;
            var billTo = _dbContext.Bills.Include("BillInfos").Where(f => f.TableId == selectedValueComboboxTo.Id && f.Status == Status.Active).FirstOrDefault();
            if(billTo != null)
            {
                foreach (var billInfo in billTo.BillInfos)
                {
                    var food = _dbContext.Foods.FirstOrDefault(f => f.Id == billInfo.FoodId);
                    ListViewItem item = new ListViewItem(new string[] { food.Name, billInfo.Count.ToString() });
                    item.Tag = billInfo.Id;
                    lvTo.Items.Add(item);
                }
            }
            
        }

        private void btnFrom_Click(object sender, EventArgs e)
        {

        }

        private void btnTo_Click(object sender, EventArgs e)
        {

        }
    }
}
