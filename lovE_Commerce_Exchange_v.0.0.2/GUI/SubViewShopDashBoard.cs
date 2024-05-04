using BUS;
using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class SubViewShopDashBoard : Form
    {


        Shop shop;

        public struct RevenueByDate
        {
            public string Date { get; set; }
            public decimal TotalAmount { get; set; }
        }

        //Fields & Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public int NumCustomers { get; private set; }
        public int NumSuppliers { get; private set; }
        public int NumProducts { get; private set; }
        public List<KeyValuePair<string, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderstockList { get; private set; }
        public List<RevenueByDate> GrossRevenueList { get; private set; }
        public int NumOrders { get; set; }
        public decimal TotalRevenue { get; set; }
        public decimal TotalProfit { get; set; }

        public SubViewShopDashBoard(Shop shop )
        {
            InitializeComponent();
            this.shop = shop;
            InitializeDataset();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        
            Product[] products;
            OrderDetail[] orderDetails;
            Order[] orders;
            Customer[] customers;
            Comment[] comments;
        private void InitializeDataset()
        {

            //get all product belongs to this shop
            products = Product.GetProducts().Where(pro => pro.ShopID == shop.ShopId).ToArray();
            //get all order detail related to these products
            orderDetails = OrderDetail.GetOrderDetails().Join(products, orderdetail => orderdetail.ProductId, pro => pro.ProductId, (orderdetail, pro) => orderdetail).ToArray();
            //get  all order belongs to these order detail
            orders = Order.GetOrders().Join(orderDetails,order => order.OrderId, orderdetail => orderdetail.OrderId, (order, orderdetail) => order).ToArray();
            //get all customer has made these order
            customers = Customer.GetCustomers().Join(orders,customer => customer.CustomerId, order => order.CustomerID, (customer, order) => customer).ToArray();
            //get all comment has made by these customer and orderdetail;
            comments = Comment.GetComments().Join(orderDetails, comment => comment.OrderDetailID,orderdetail => orderdetail.OrderDetailId, (comment, orderdetails) => comment).ToArray();
            //Fill total counter
        }       








        #region   Statistic
        private void StatisticOrderByDay(string StartedDay, string EndedDay)
        {
            //process day as 
        }

        #endregion































        private DateTime TurnToDate(string stringformatDate)
        {
            string[] date = stringformatDate.Split('-');
            return new DateTime(date[0].ToInt(), date[1].ToInt(), date[2].ToInt(),00,00,00);
        }


        private void LoadDataOnChart()
        {

            DateTime startDate = dateTimePicker_startedDate.Value;
            DateTime endDate = dateTimePicker_endedDate.Value;
            int numberDays = (endDate - startDate).Days;

            //
            label_customers.Text = customers.Count().ToString();
            label_comments.Text = comments.Count().ToString();
            label_products.Text = products.Count().ToString();
            label_orders.Text = orders.Where(order => startDate < TurnToDate(order.Date) && TurnToDate(order.Date) < endDate).Count().ToString();


            // filter top 5 product has a highest selling quantity
            //int totalQuanity = 0;
            TopProductsList = new List<KeyValuePair<string, int>>();
            UnderstockList = new List<KeyValuePair<string, int>>();
            foreach (Product product in products)
            {
                TopProductsList.Add(new KeyValuePair<string, int>(product.ProductName, orderDetails.Where(orderdetail => orderdetail.ProductId == product.ProductId).Sum(orderdetail => orderdetail.Quantity.ToInt())));
            }
            ;
            //TopProductsList = new List<KeyValuePair<string, int>>(new KeyValuePair<string, int>());
            chart_bestSellingProduct.DataSource = TopProductsList.OrderBy(x => x.Value).Take(5).ToList();
            chart_bestSellingProduct.Series[0].XValueMember = "Key";
            chart_bestSellingProduct.Series[0].YValueMembers = "Value";
            //chart_bestSellingProduct.DataBind();


            //get lower Stock
            foreach(Product product1 in  products.OrderBy(pro => pro.Quantity).Take(5))
            {
                UnderstockList.Add(
                                new KeyValuePair<string, int>(product1.ProductName, product1.Quantity.ToInt()));
            }
            dataGridView_underStock.DataSource = UnderstockList;
            dataGridView_underStock.Columns[0].HeaderText = "Item";
            dataGridView_underStock.Columns[1].HeaderText = "Units";




            //get grossrevenue
            GrossRevenueList = new List<RevenueByDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            var resultTable = new List<KeyValuePair<DateTime, decimal>>();

            foreach (var Groupp in orders.GroupBy(order => order.Date))
            {
                int totalAmount = 0; // total Amount in a day 
                //filter all ordertail belongs to these order at that day
                OrderDetail[] orderDetailsTemp = orderDetails.Join(Groupp, orderdetail => orderdetail.OrderId, order => order.OrderId, (orderdetail, order) => orderdetail).ToArray();
                //filter those products which was sold by this shop, because 1 order can have a lot orderdetail and form alot different shop;
                orderDetailsTemp = orderDetailsTemp.Where(orderdetail => products.Any(pro => pro.ProductId == orderdetail.ProductId)).ToArray();
                orderDetailsTemp.ToList().ForEach(orderdetail => totalAmount += (orderdetail.Quantity.ToInt() * orderdetail.UnitPrice.ToInt()) - orderdetail.Discount.ToInt());
                resultTable.Add(new KeyValuePair<DateTime, decimal>(TurnToDate( Groupp.Key), totalAmount));
                TotalRevenue += totalAmount;
            }
            TotalProfit = TotalRevenue * 0.2m;//20%



            //legacy code
            if (numberDays <= 1)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("hh tt")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }
            //Group by Days
            else if (numberDays <= 30)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("dd MMM")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Weeks
            else if (numberDays <= 92)
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                        orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = "Week " + order.Key.ToString(),
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Months
            else if (numberDays <= (365 * 2))
            {
                bool isYear = numberDays <= 365 ? true : false;
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("MMM yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = isYear ? order.Key.Substring(0, order.Key.IndexOf(" ")) : order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }

            //Group by Years
            else
            {
                GrossRevenueList = (from orderList in resultTable
                                    group orderList by orderList.Key.ToString("yyyy")
                                   into order
                                    select new RevenueByDate
                                    {
                                        Date = order.Key,
                                        TotalAmount = order.Sum(amount => amount.Value)
                                    }).ToList();
            }




            label_totalRevenue.Text = "$" + TotalRevenue.ToString();
            label_totalProfit.Text = "$" + TotalProfit.ToString();
            chart_grossRevenue.DataSource = GrossRevenueList;
            chart_grossRevenue.Series[0].XValueMember = "Date";
            chart_grossRevenue.Series[0].YValueMembers = "TotalAmount";
            chart_grossRevenue.DataBind();
        }


        private void SubViewShopDashBoard_Resize(object sender, EventArgs e)
        {
            double averageWitdth =( this.Width - 60) / 3;
            panel_orders.Size = new Size( (int)averageWitdth, panel_orders.Size.Height);

            panel_totalProfit.Size = new Size( (int)averageWitdth, panel_totalProfit.Size.Height);
            panel_totalProfit.Location = new Point(panel_orders.Size.Width + panel_orders.Location.X + 10, panel_totalProfit.Location.Y);

            panel_totalRevenue.Size = new Size( (int)averageWitdth, panel_totalRevenue.Size.Height);
            panel_totalRevenue.Location = new Point(panel_totalProfit.Size.Width + panel_totalProfit.Location.X + 10, panel_totalRevenue.Location.Y);

         


        }

        private void DateTimePicker_endedDate_ValueChanged(object sender, EventArgs e)
        {

             label_endedDate.Text = dateTimePicker_endedDate.Text;
        }

        private void DateTimePicker_startedDate_ValueChanged(object sender, EventArgs e)
        {
            label_startedDate.Text = dateTimePicker_startedDate.Text;

        }

        private void Label_startedDate_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Select();
            SendKeys.Send("%{DOWN}");
        }

        private void Label_endedDate_Click(object sender, EventArgs e)
        {
            dateTimePicker_endedDate.Select();
            SendKeys.Send("%{DOWN}");
        }


        private void RjButton9_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, null);

        }
        private void ActivatedButton(object sender, EventArgs e)
        {
            
            RJButton currentBUtton = (RJButton)sender;
            foreach (RJButton rJButton in panel_OptionHolder.Controls)
            {
                rJButton.BackColor = Color.White;
                rJButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
            currentBUtton.BackColor = Color.MediumSlateBlue;
            currentBUtton.ForeColor = Color.White;
        }

        private void RjButton9_Click_1(object sender, EventArgs e)
        {
            //check datetime picker
            if(dateTimePicker_startedDate.Value > dateTimePicker_endedDate.Value)
            {
                MessageBox.Show("Started  day cannot higher than ended daay !");
                return;
            }
            if(label_endedDate.Text == "Ended day")
            {
                MessageBox.Show("Please choose ended day!   " );
                return;
            }
            if(label_startedDate.Text == "Started day")
            {
                MessageBox.Show("Please choose started day!");
                return;
            }

            LoadDataOnChart();
            ActivatedButton(sender, null);
        }

        private void RjButton13_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Value = DateTime.Today;
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();
            ActivatedButton(sender, null);

        }

        private void RjButton10_Click(object sender, EventArgs e)
        {
            ActivatedButton(sender, null);
            dateTimePicker_startedDate.Value = DateTime.Today.AddDays(-7);
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();

        }

        private void RjButton11_Click(object sender, EventArgs e)
        {
            dateTimePicker_startedDate.Value = DateTime.Today.AddDays(-30);
            dateTimePicker_endedDate.Value = DateTime.Now;
            LoadDataOnChart();
            ActivatedButton(sender, null);


        }

        private void SubViewShopDashBoard_Load(object sender, EventArgs e)
        {
            //dataGridView_underStock.Columns[1].Width = 50;
        }

        private void DateTimePicker_startedDate_ValueChanged_1(object sender, EventArgs e)
        {
            label_startedDate.Text = dateTimePicker_startedDate.Text;
            
        }

        private void DateTimePicker_endedDate_ValueChanged_1(object sender, EventArgs e)
        {
            label_endedDate.Text = dateTimePicker_endedDate.Text;
        }
    }
}                                                       
