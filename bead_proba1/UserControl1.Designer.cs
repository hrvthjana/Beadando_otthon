namespace bead_proba1
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbCustomer = new ListBox();
            txtCustomer = new TextBox();
            dataGridView1 = new DataGridView();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subcategoryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shipModeDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            sajatomBindingSource = new BindingSource(components);
            salesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lbOrders = new ListBox();
            label1 = new Label();
            txtTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sajatomBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbCustomer
            // 
            lbCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbCustomer.FormattingEnabled = true;
            lbCustomer.ItemHeight = 32;
            lbCustomer.Location = new Point(51, 104);
            lbCustomer.Name = "lbCustomer";
            lbCustomer.Size = new Size(259, 452);
            lbCustomer.TabIndex = 0;
            lbCustomer.SelectedIndexChanged += lbCustomer_SelectedIndexChanged;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(51, 35);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(200, 39);
            txtCustomer.TabIndex = 3;
            txtCustomer.TextChanged += txtCustomer_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productNameDataGridViewTextBoxColumn, categoryDataGridViewTextBoxColumn, subcategoryDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, shipDateDataGridViewTextBoxColumn, shipModeDataGridViewTextBoxColumn, salesDataGridViewTextBoxColumn });
            dataGridView1.DataSource = sajatomBindingSource;
            dataGridView1.Location = new Point(626, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(728, 556);
            dataGridView1.TabIndex = 4;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "productName";
            productNameDataGridViewTextBoxColumn.HeaderText = "productName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            categoryDataGridViewTextBoxColumn.HeaderText = "category";
            categoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            categoryDataGridViewTextBoxColumn.ReadOnly = true;
            categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // subcategoryDataGridViewTextBoxColumn
            // 
            subcategoryDataGridViewTextBoxColumn.DataPropertyName = "subcategory";
            subcategoryDataGridViewTextBoxColumn.HeaderText = "subcategory";
            subcategoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            subcategoryDataGridViewTextBoxColumn.Name = "subcategoryDataGridViewTextBoxColumn";
            subcategoryDataGridViewTextBoxColumn.ReadOnly = true;
            subcategoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "orderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "orderDate";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // shipDateDataGridViewTextBoxColumn
            // 
            shipDateDataGridViewTextBoxColumn.DataPropertyName = "shipDate";
            shipDateDataGridViewTextBoxColumn.HeaderText = "shipDate";
            shipDateDataGridViewTextBoxColumn.MinimumWidth = 10;
            shipDateDataGridViewTextBoxColumn.Name = "shipDateDataGridViewTextBoxColumn";
            shipDateDataGridViewTextBoxColumn.ReadOnly = true;
            shipDateDataGridViewTextBoxColumn.Width = 200;
            // 
            // shipModeDataGridViewTextBoxColumn
            // 
            shipModeDataGridViewTextBoxColumn.DataPropertyName = "shipMode";
            shipModeDataGridViewTextBoxColumn.DataSource = sajatomBindingSource;
            shipModeDataGridViewTextBoxColumn.DisplayMember = "shipMode";
            shipModeDataGridViewTextBoxColumn.HeaderText = "shipMode";
            shipModeDataGridViewTextBoxColumn.MinimumWidth = 10;
            shipModeDataGridViewTextBoxColumn.Name = "shipModeDataGridViewTextBoxColumn";
            shipModeDataGridViewTextBoxColumn.ReadOnly = true;
            shipModeDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            shipModeDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            shipModeDataGridViewTextBoxColumn.Width = 200;
            // 
            // sajatomBindingSource
            // 
            sajatomBindingSource.DataSource = typeof(Sajatom);
            // 
            // salesDataGridViewTextBoxColumn
            // 
            salesDataGridViewTextBoxColumn.DataPropertyName = "sales";
            salesDataGridViewTextBoxColumn.HeaderText = "sales";
            salesDataGridViewTextBoxColumn.MinimumWidth = 10;
            salesDataGridViewTextBoxColumn.Name = "salesDataGridViewTextBoxColumn";
            salesDataGridViewTextBoxColumn.ReadOnly = true;
            salesDataGridViewTextBoxColumn.Width = 200;
            // 
            // lbOrders
            // 
            lbOrders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbOrders.FormattingEnabled = true;
            lbOrders.ItemHeight = 32;
            lbOrders.Location = new Point(344, 104);
            lbOrders.Name = "lbOrders";
            lbOrders.Size = new Size(240, 452);
            lbOrders.TabIndex = 5;
            lbOrders.SelectedIndexChanged += lbOrders_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(1081, 702);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 6;
            label1.Text = "Total";
            // 
            // txtTotal
            // 
            txtTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtTotal.Location = new Point(1154, 699);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(200, 39);
            txtTotal.TabIndex = 7;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(txtTotal);
            Controls.Add(label1);
            Controls.Add(lbOrders);
            Controls.Add(dataGridView1);
            Controls.Add(txtCustomer);
            Controls.Add(lbCustomer);
            Name = "UserControl1";
            Size = new Size(1385, 757);
            Load += UserControl1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sajatomBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbCustomer;
        private TextBox txtCustomer;
        private DataGridView dataGridView1;
        private ListBox lbOrders;
        private BindingSource sajatomBindingSource;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subcategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shipDateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn shipModeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salesDataGridViewTextBoxColumn;
        private Label label1;
        private TextBox txtTotal;
    }
}
