﻿using bead_proba1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Axes;

namespace bead_proba1
{
    public partial class UserControl3 : UserControl
    {
        Models.MyContext context = new Models.MyContext();
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            pDiag.Controls.Clear();
            PlotView view = new PlotView();
            view.Dock = DockStyle.Fill;
           var model = new PlotModel();
            view.Width = pDiag.Width;
            view.Height = pDiag.Height;
            if (radioState.Checked == true)
            {
                model.Title = "TotalSales - State";
                var diagramQuery = from x in context.OrderProducts
                                   join oc in context.OrderCustomers on x.OrderId equals oc.OrderId
                                   join cd in context.CustomerDetails on oc.CustomerId equals cd.CustomerId
                                   join ca in context.CustomerAddresses on cd.PostalCode equals ca.PostalCode
                                   group x by ca.State into stateGroup
                                   select new DiagramClass
                                   {
                                       State = stateGroup.Key,
                                       Total = (double)stateGroup.Sum(op => op.Sales)
                                   };

                var bari = new BarSeries();
                var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
                model.Axes.Add(categoryAxis);
                foreach (var item in diagramQuery)
                {
                    bari.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.State);
                }
                model.Series.Add(bari);
            }
            else
            {
                model.Title = "TotalOrder - SubCategory" ;
                var diagramquery = from x in context.OrderProducts
                                   join p in context.Products on x.ProductId equals p.ProductId
                                   group x by p.SubCategory into categoryGroup
                                   select new DiagramClass2
                                   {
                                       SubCategory = categoryGroup.Key,
                                       Total = (double)categoryGroup.Sum(op => op.Sales)
                                   };

                var bari = new BarSeries();
                var categoryAxis = new CategoryAxis { Position = AxisPosition.Left };
                model.Axes.Add(categoryAxis);
                foreach (var item in diagramquery)
                {
                    bari.Items.Add(new BarItem { Value = item.Total });
                    categoryAxis.Labels.Add(item.SubCategory);
                }
                model.Series.Add(bari);

            }

            view.Model = model;
            pDiag.Controls.Add(view);


        }
    }

    public class DiagramClass
    {
        public string State { get; set; }

        public double Total { get; set; }
    }
    public class DiagramClass2
    {
        public string SubCategory { get; set; }

        public double Total { get; set; }
    }

}
