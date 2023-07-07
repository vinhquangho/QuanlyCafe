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
    public partial class fTableManager : Form
    {
        private AppDbContext _dbContext = new AppDbContext();
        private CultureInfo culture = new CultureInfo("vi-VN");
        NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        private int? TableId = null;
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            LoadCategory();
            LoadFood();
        }
        private void LoadTable()
        {

            var area = _dbContext.AreaTables.Where(f => f.Status == Status.Active).ToList();
            foreach (var a in area)
            {
                var tabPanel = new TabPage() { Name = $@"tab-${a.Id}", Text = a.Name, Width = 780, Height = 708 };
                var flowLayoutControl = new FlowLayoutPanel() { Name = $@"fp-${a.Id}", Height = 708, Width = 780 };
                tabPanel.Controls.Add(flowLayoutControl);

                var table = _dbContext.Tables.Where(f => f.AreaTableId == a.Id).ToList();
                foreach (var t in table)
                {
                    var btn = new Button() { Name = $"btn-${t.Id}", Text = t.Name, Width = 150, Height = 50, TextAlign = ContentAlignment.MiddleCenter, Tag = t.Id };
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
        private void LoadFood()
        {
            var food = _dbContext.Foods.Where(f => f.Status == Status.Active).ToList();
            cbbFood.DataSource = food;
            cbbFood.ValueMember = "Id";
            cbbFood.DisplayMember = "Name";
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
                            if(TableId.HasValue && TableId.Value == (int)b.Tag)
                            {
                                var button = (Button)b;
                                button.PerformClick();
                            }
                        }
                    }
                }
            }
        }
    }
}
