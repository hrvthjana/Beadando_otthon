using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bead_proba1
{
    public partial class Form3 : Form
    {
        Models.MyContext context = new Models.MyContext();
        public Form3()
        {
            InitializeComponent();
            var getSegment = (from x in context.CustomerDetails
                              select x.Segment).Distinct();
            cbSzegmens.DataSource = getSegment.ToList();

            var getPostal = (from x in context.CustomerDetails
                             select x.PostalCode).Distinct();
            cbPostal.DataSource = getPostal.ToList();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true) this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void txtNev_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNev.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNev, "Nem lehet üres az érték!");
            }
        }

        private void txtNev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtNev, string.Empty);
        }

        private void txtID_Validating(object sender, CancelEventArgs e)
        {
            Models.MyContext context = new Models.MyContext();
            var custid = from x in context.CustomerDetails
                         select x.CustomerId;

            Regex r = new Regex("^[A-Z]{2}-[0-9]{5}$");
            if (!r.IsMatch(txtID.Text))
            {
                errorProvider1.SetError(txtID, "Az elvárt fomátum: XX-000000");
                e.Cancel = true;
            }
            if (custid.Contains(txtID.Text))
            {
                errorProvider1.SetError(txtID, "A megadott ID már foglalt!");
                e.Cancel = true;
            }
        }

        private void txtID_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtID, string.Empty);
        }
    }
}
