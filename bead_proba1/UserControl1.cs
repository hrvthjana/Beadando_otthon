using bead_proba1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bead_proba1
{
    public partial class UserControl1 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl1()
        {
            InitializeComponent();
            FilterCustomer();
            LoadOrders();
            LoadOrderDetails();
        }


        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            FilterCustomer();


        }
        private void lbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrders();
            LoadOrderDetails();

        }
        private void lbOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrderDetails();

        }

        private void FilterCustomer()
        {
            var filterCustomer = from x in context.CustomerDetails
                                 where x.CustomerName.StartsWith(txtCustomer.Text)
                                 select x;
            lbCustomer.DataSource = filterCustomer.ToList();
            lbCustomer.DisplayMember = "CustomerName";
        }



        private void LoadOrders()
        {
            var selectedCustomer = (CustomerDetail)lbCustomer.SelectedItem;
            var loadOrders = from x in context.OrderCustomers
                             join od in context.OrderDetails on x.OrderId equals od.OrderId
                             where x.CustomerId == selectedCustomer.CustomerId
                             select od;
            lbOrders.DataSource = loadOrders.ToList();
            lbOrders.DisplayMember = "OrderID";
        }



        private void LoadOrderDetails()
        {
            var selectedOrder = (OrderDetail)lbOrders.SelectedItem;
            var valami = from x in context.OrderCustomers
                         join od in context.OrderDetails on x.OrderId equals od.OrderId
                         join op in context.OrderProducts on x.OrderId equals op.OrderId
                         join p in context.Products on op.ProductId equals p.ProductId
                         where x.OrderId == selectedOrder.OrderId
                         select new Sajatom
                         {

                             productName = p.ProductName,
                             category = p.Category,
                             subcategory = p.SubCategory,
                             orderDate = od.OrderDate,
                             shipDate = od.ShipDate,
                             shipMode = od.ShipMode,
                             sales = (decimal)op.Sales,


                         };
            sajatomBindingSource.DataSource = valami.ToList();
            var total = (from x in context.OrderProducts
                         where x.OrderId == selectedOrder.OrderId
                         select x.Sales).Sum();
            txtTotal.Text = total.ToString();

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var OrderToDel = (OrderDetail)lbOrders.SelectedItem;

        }
    }
    public class Sajatom
    {
        public string productName { get; set; }
        public string category { get; set; }
        public string subcategory { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime shipDate { get; set; }
        public string shipMode { get; set; }
        public decimal sales { get; set; }

    }
}
