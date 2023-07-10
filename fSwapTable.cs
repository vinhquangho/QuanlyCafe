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
            var billTo = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbTo.SelectedValue);
            var listBillInfo = lvFrom.CheckedItems.Cast<ListViewItem>().ToList();
            
            if(billTo == null)
            {
                var billDto = new Bill()
                {
                    DateIn = DateTime.Now,
                    TableId = (int)cbbTo.SelectedValue,
                    Status = Status.Active,
                    Discount = 0,
                    Service = 0,
                    Note = string.Empty,
                    AccountId = Global.AccountId,
                };
                _dbContext.Bills.Add(billDto);
                _dbContext.SaveChanges();

                decimal price = 0;
                foreach (var item in listBillInfo)
                {
                    var billInfo = _dbContext.BillInfos.FirstOrDefault(f => f.Id == (int)item.Tag);
                    billInfo.BillId = billDto.Id;
                    price += billInfo.Count * billInfo.Price;
                    _dbContext.SaveChanges();
                }
                billDto.Price = price;
                billDto.TotalPrice = price;
                _dbContext.SaveChanges();

                var billFrom = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbFrom.SelectedValue);
                if(billFrom.BillInfos.Count <= 0)
                {
                    _dbContext.Bills.Remove(billFrom);
                    _dbContext.SaveChanges();
                }
                else
                {
                    var billInfoPrice = billFrom.BillInfos.Sum(f => f.Price * f.Count);
                    billFrom.Price = billInfoPrice;
                    billFrom.TotalPrice = billInfoPrice + billFrom.Service - billFrom.Discount;
                    _dbContext.SaveChanges();
                }
            }
            if(billTo != null)
            {
                foreach (var item in listBillInfo)
                {
                    var billInfoFrom = _dbContext.BillInfos.FirstOrDefault(f => f.Id == (int)item.Tag);
                    var billInfoTo = _dbContext.BillInfos.FirstOrDefault(f => f.FoodId == billInfoFrom.FoodId && f.BillId == billTo.Id);
                    if(billInfoTo != null)
                    {
                        billInfoTo.Count += billInfoFrom.Count;
                        _dbContext.BillInfos.Remove(billInfoFrom);
                        _dbContext.SaveChanges();
                    }
                    if(billInfoTo == null)
                    {
                        billInfoFrom.BillId = billTo.Id;
                        _dbContext.SaveChanges();
                    }
                }
                var billFrom = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbFrom.SelectedValue);
                var billInfoPrice = billFrom.BillInfos.Sum(f => f.Price * f.Count);
                billFrom.Price = billInfoPrice;
                billFrom.TotalPrice = billFrom.Price + billFrom.Service - billFrom.Discount;
                _dbContext.SaveChanges();

                var billInfoToPrice = billTo.BillInfos.Sum(f => f.Price * f.Count);
                billTo.Price = billInfoToPrice;
                billTo.TotalPrice = billTo.Price + billTo.Service - billTo.Discount;
                _dbContext.SaveChanges();
            }
            cbbFrom_SelectedIndexChanged(cbbFrom, EventArgs.Empty);
            cbbTo_SelectedIndexChanged(cbbTo, EventArgs.Empty);
        }

        private void btnTo_Click(object sender, EventArgs e)
        {
            var billTo = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbFrom.SelectedValue);
            var listBillInfo = lvTo.CheckedItems.Cast<ListViewItem>().ToList();

            if (billTo == null)
            {
                var billDto = new Bill()
                {
                    DateIn = DateTime.Now,
                    TableId = (int)cbbFrom.SelectedValue,
                    Status = Status.Active,
                    Discount = 0,
                    Service = 0,
                    Note = string.Empty,
                    AccountId = Global.AccountId,
                };
                _dbContext.Bills.Add(billDto);
                _dbContext.SaveChanges();

                decimal price = 0;
                foreach (var item in listBillInfo)
                {
                    var billInfo = _dbContext.BillInfos.FirstOrDefault(f => f.Id == (int)item.Tag);
                    billInfo.BillId = billDto.Id;
                    price += billInfo.Count * billInfo.Price;
                    _dbContext.SaveChanges();
                }
                billDto.Price = price;
                billDto.TotalPrice = price;
                _dbContext.SaveChanges();

                var billFrom = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbTo.SelectedValue);
                if (billFrom.BillInfos.Count <= 0)
                {
                    _dbContext.Bills.Remove(billFrom);
                    _dbContext.SaveChanges();
                }
                else
                {
                    var billInfoPrice = billFrom.BillInfos.Sum(f => f.Price * f.Count);
                    billFrom.Price = billInfoPrice;
                    billFrom.TotalPrice = billInfoPrice + billFrom.Service - billFrom.Discount;
                    _dbContext.SaveChanges();
                }
            }
            if (billTo != null)
            {
                foreach (var item in listBillInfo)
                {
                    var billInfoFrom = _dbContext.BillInfos.FirstOrDefault(f => f.Id == (int)item.Tag);
                    var billInfoTo = _dbContext.BillInfos.FirstOrDefault(f => f.FoodId == billInfoFrom.FoodId && f.BillId == billTo.Id);
                    if (billInfoTo != null)
                    {
                        billInfoTo.Count += billInfoFrom.Count;
                        _dbContext.BillInfos.Remove(billInfoFrom);
                        _dbContext.SaveChanges();
                    }
                    if (billInfoTo == null)
                    {
                        billInfoFrom.BillId = billTo.Id;
                        _dbContext.SaveChanges();
                    }
                }
                var billFrom = _dbContext.Bills.Include("BillInfos").FirstOrDefault(f => f.Status == Status.Active && f.TableId == (int)cbbTo.SelectedValue);
                var billInfoPrice = billFrom.BillInfos.Sum(f => f.Price * f.Count);
                billFrom.Price = billInfoPrice;
                billFrom.TotalPrice = billFrom.Price + billFrom.Service - billFrom.Discount;
                _dbContext.SaveChanges();

                var billInfoToPrice = billTo.BillInfos.Sum(f => f.Price * f.Count);
                billTo.Price = billInfoToPrice;
                billTo.TotalPrice = billTo.Price + billTo.Service - billTo.Discount;
                _dbContext.SaveChanges();
            }
            cbbFrom_SelectedIndexChanged(cbbFrom, EventArgs.Empty);
            cbbTo_SelectedIndexChanged(cbbTo, EventArgs.Empty);
        }
    }
}
