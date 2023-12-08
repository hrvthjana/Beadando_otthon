using bead_proba1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bead_proba1
{
    public partial class UserControl2 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl2()
        {
            InitializeComponent();
            FilterCustomer();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterCustomer();

        }

        private void FilterCustomer()
        {
            var filterterCustomers = from x in context.CustomerDetails
                                     where x.CustomerName.StartsWith(textBox1.Text)
                                     select x;
            listBox1.DataSource = filterterCustomers.ToList();
            listBox1.DisplayMember = "CustomerName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            if (form3.ShowDialog() == DialogResult.OK)
            {
                Models.CustomerDetail cd = new Models.CustomerDetail();
                cd.CustomerId = form3.txtID.Text;
                cd.CustomerName = form3.txtNev.Text;
                cd.Segment = form3.cbSzegmens.Text;
                cd.PostalCode = int.Parse(form3.cbPostal.Text);
                context.CustomerDetails.Add(cd);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                FilterCustomer();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            DialogResult eredmeny = MessageBox.Show("Biztosan törölni szeretné?\r\nA törléskor a vevő rendelései is törlődni fognak", "Törlés megerősítése", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (eredmeny == DialogResult.Yes)
            {
                var selectedCustomer = (CustomerDetail)listBox1.SelectedItem;
                var customerToDelete = (from x in context.CustomerDetails
                                        where x.CustomerId == selectedCustomer.CustomerId
                                        select x).FirstOrDefault();

                context.CustomerDetails.Remove(customerToDelete);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.InnerException.ToString());
                }

                FilterCustomer();
            }
            
            

        }
    }
}
