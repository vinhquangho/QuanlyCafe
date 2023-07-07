using QuanlyCafe.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlyCafe
{
    public partial class fTableManager : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        private CultureInfo culture = new CultureInfo("vi-VN");
        NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        private int? TableId = null;
        private int? BillInfoId = null;
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
        }
        private void LoadTable()
        {

            var area = _dbContext.AreaTables.Where(f => f.Status == Status.Active).ToList();
            foreach (var a in area)
            {
                var tabPanel = new TabPage() { Name = $@"tab-${a.Id}", Text = a.Name, Width = 525, Height = 525 };
                var flowLayoutControl = new FlowLayoutPanel() { Name = $@"fp-${a.Id}", Height = 525, Width = 525 };
                tabPanel.Controls.Add(flowLayoutControl);

                var table = _dbContext.Tables.Where(f => f.AreaTableId == a.Id).ToList();
                foreach (var t in table)
                {
                    var btn = new Button() { Name = $"btn-${t.Id}", Text = t.Name, Width = 120, Height = 50, TextAlign = ContentAlignment.MiddleCenter, Tag = t.Id };
                    btn.Click += btnTable_Click;
                    var tableExsitBill = _dbContext.Bills.Any(b => b.TableId == t.Id && b.Status == Status.Active);
                    if (tableExsitBill)
                    {
                        btn.BackColor = Color.GreenYellow;
                    }
                    flowLayoutControl.Controls.Add(btn);
                }

                tArea.Controls.Add(tabPanel);
            }
        }
        private void LoadCategory()
        {
            var category = _dbContext.Categories.Where(f => f.Status == Status.Active).ToList();
            foreach (var c in category)
            {
                var node = new TreeNode() { Text = c.Name, Name = $"c-${c.Id}", Tag = c.Id };
                treeViewCategory.Nodes.Add(node);
            }
        }
        private void menuStripAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fmain = new fMain();
            fmain.ShowDialog();
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            foreach (Control t in tArea.Controls)
            {
                foreach (Control p in t.Controls)
                {
                    foreach (Control b in p.Controls)
                    {
                        b.BackColor = Color.FromArgb(255, 240, 240, 240);
                        b.ForeColor = Color.Black;

                        var tableExsitBill = _dbContext.Bills.Any(f => f.TableId == (int)b.Tag && f.Status == Status.Active);
                        if (tableExsitBill)
                        {
                            b.BackColor = Color.GreenYellow;
                        }
                    }
                }
            }
            var btn = (Button)sender;
            btn.BackColor = Color.Blue;
            btn.ForeColor = Color.White;
            TableId = (int)btn.Tag;
            listViewBill.Items.Clear();
            txtPrice.Text = 0.ToString("c", culture);
            txtService.Text = 0.ToString("c", culture);
            txtDiscount.Text = 0.ToString("c", culture);
            txtTotal.Text = 0.ToString("c", culture);
            txtNote.Text = string.Empty;

            var bill = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.TableId == TableId && f.Status == Status.Active);
            if (bill != null)
            {
                foreach (var billinfo in bill.BillInfos)
                {
                    var food = _dbContext.Foods.FirstOrDefault(f => f.Id == billinfo.FoodId);
                    ListViewItem item = new ListViewItem(new string[] { food.Name, billinfo.Count.ToString(), billinfo.Price.ToString("c", culture), (billinfo.Count * billinfo.Price).ToString("c", culture) });
                    item.Tag = billinfo.Id;
                    listViewBill.Items.Add(item);
                }
                txtPrice.Text = bill.Price.ToString("c", culture);
                txtService.Text = bill.Service.ToString("c", culture);
                txtDiscount.Text = bill.Discount.ToString("c", culture);
                txtTotal.Text = bill.TotalPrice.ToString("c", culture);
                txtNote.Text = bill.Note;
            }
        }

        private void treeViewCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewFood.Items.Clear();
            var food = _dbContext.Foods.Where(f => f.CategoryId == (int)e.Node.Tag && f.Status == Status.Active).ToList();
            foreach (var f in food)
            {
                ListViewItem item = new ListViewItem(new string[] { f.Name, f.Price.ToString("c", culture) });
                item.Tag = f.Id;
                listViewFood.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var listFood = listViewFood.CheckedItems.Cast<ListViewItem>().ToList();
            if (!TableId.HasValue)
            {
                MessageBox.Show("Bạn chưa chọn bàn cần thao tác", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(listFood.Count <= 0)
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var bill = _dbContext.Bills.FirstOrDefault(f => f.TableId == TableId.Value && f.Status == Status.Active);
            // đã có bill ở bàn
            if (bill != null)
            {

            }
            // chưa có bill ở bàn
            if (bill == null)
            {
                decimal Price = 0;

                var billDto = new Bill()
                {
                    DateIn = DateTime.Now,
                    TableId = TableId.Value,
                    Status = Status.Active,
                    Discount = decimal.Parse(txtDiscount.Text, style, culture),
                    Service = decimal.Parse(txtService.Text, style, culture),
                    Note = txtNote.Text,
                    AccountId = Global.AccountId,
                };

                var listBillInfo = new List<BillInfo>();
                foreach (var item in listFood)
                {
                    var foodId = (int)item.Tag;
                    var food = _dbContext.Foods.FirstOrDefault(f => f.Id == foodId);
                    var billInfo = new BillInfo() { FoodId = food.Id, Price = food.Price, Count = (int)numericeCount.Value };
                    Price += (food.Price * billInfo.Count);
                    listBillInfo.Add(billInfo);
                }
                billDto.BillInfos = listBillInfo;
                billDto.Price = Price;
                billDto.TotalPrice = Price + billDto.Service - billDto.Discount;

                _dbContext.Bills.Add(billDto);
                _dbContext.SaveChanges();

                listViewFood.Items.Clear();
                listViewBill.Items.Clear();

                ReloadTable();
            }
        }

        private void listViewBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listView = (ListView)sender;
            if (listView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView.SelectedItems)
                {
                    var billInfoId = (int)item.Tag;
                    var billInfo = _dbContext.BillInfos.FirstOrDefault(f => f.Id == billInfoId);
                    numericeCount.Value = billInfo.Count;
                    BillInfoId = billInfoId;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BillInfoId.HasValue && TableId.HasValue)
            {
                var billInfo = _dbContext.BillInfos.FirstOrDefault(f => f.Id == BillInfoId);
                billInfo.Count = billInfo.Count - (int)numericeCount.Value;
                if (billInfo.Count <= 0) _dbContext.BillInfos.Remove(billInfo);
                _dbContext.SaveChanges();

                var bill = _dbContext.Bills.FirstOrDefault(f => f.Id == billInfo.BillId);
                var listBillInfo = _dbContext.BillInfos.Where(f => f.BillId == bill.Id).ToList();
                if (listBillInfo.Count <= 0) _dbContext.Bills.Remove(bill); 
                var discount = decimal.Parse(string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text, style, culture);
                var service = decimal.Parse(string.IsNullOrEmpty(txtService.Text) ? "0" : txtService.Text, style, culture);
                bill.Price = listBillInfo.Sum(f => f.Price * f.Count);
                bill.Service = service;
                bill.Discount = discount;
                bill.TotalPrice = bill.Price + bill.Service - bill.Discount;
                _dbContext.SaveChanges();

                ReloadTable();
            }
        }
        private void ReloadTable()
        {
            foreach (Control t in tArea.Controls)
            {
                foreach (Control p in t.Controls)
                {
                    foreach (Control b in p.Controls)
                    {
                        b.BackColor = Color.FromArgb(255, 240, 240, 240);
                        b.ForeColor = Color.Black;

                        var tableExsitBill = _dbContext.Bills.Any(f => f.TableId == (int)b.Tag && f.Status == Status.Active);
                        if (tableExsitBill)
                        {
                            b.BackColor = Color.GreenYellow;
                        }
                        if (TableId.HasValue && TableId.Value == (int)b.Tag)
                        {
                            var button = (Button)b;
                            button.PerformClick();
                        }
                    }
                }
            }
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (TableId.HasValue)
            {
                var bill = _dbContext.Bills.FirstOrDefault(f => f.TableId == TableId.Value && f.Status == Status.Active);
                if(bill != null)
                {
                    bill.Status = Status.DeActive;
                    bill.DateOut = DateTime.Now;
                    bill.Price = decimal.Parse(txtPrice.Text, style, culture);
                    bill.Discount = decimal.Parse(txtDiscount.Text, style, culture);
                    bill.Service = decimal.Parse(txtService.Text, style, culture);
                    bill.TotalPrice = decimal.Parse(txtTotal.Text, style, culture);
                    bill.Note = txtNote.Text;
                    _dbContext.SaveChanges();

                    ReloadTable();
                }
            }
        }

        private void txtService_TextChanged(object sender, EventArgs e)
        {
            var price = decimal.Parse(txtPrice.Text, style, culture);
            var discount = decimal.Parse(string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text, style, culture);
            var service = decimal.Parse(string.IsNullOrEmpty(txtService.Text) ? "0" : txtService.Text, style, culture);
            txtTotal.Text = (price + service - discount).ToString("c", culture);
            txtService.Text = service.ToString("c", culture);
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            var price = decimal.Parse(txtPrice.Text, style, culture);
            var discount = decimal.Parse(string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text, style, culture);
            var service = decimal.Parse(string.IsNullOrEmpty(txtService.Text) ? "0" : txtService.Text, style, culture);
            txtTotal.Text = (price + service - discount).ToString("c", culture);
            txtDiscount.Text = discount.ToString("c", culture);
        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            if (BillInfoId.HasValue && TableId.HasValue)
            {
                var billInfo = _dbContext.BillInfos.FirstOrDefault(f => f.Id == BillInfoId);
                _dbContext.BillInfos.Remove(billInfo);
                _dbContext.SaveChanges();

                var bill = _dbContext.Bills.FirstOrDefault(f => f.Id == billInfo.BillId);
                var listBillInfo = _dbContext.BillInfos.Where(f => f.BillId == bill.Id).ToList();
                if (listBillInfo.Count <= 0) _dbContext.Bills.Remove(bill);
                var discount = decimal.Parse(string.IsNullOrEmpty(txtDiscount.Text) ? "0" : txtDiscount.Text, style, culture);
                var service = decimal.Parse(string.IsNullOrEmpty(txtService.Text) ? "0" : txtService.Text, style, culture);
                bill.Price = listBillInfo.Sum(f => f.Price * f.Count);
                bill.Service = service;
                bill.Discount = discount;
                bill.TotalPrice = bill.Price + bill.Service - bill.Discount;
                _dbContext.SaveChanges();

                ReloadTable();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSwipTable_Click(object sender, EventArgs e)
        {

        }
    }
}
