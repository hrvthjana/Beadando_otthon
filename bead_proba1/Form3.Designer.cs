namespace bead_proba1
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNev = new TextBox();
            label2 = new Label();
            cbSzegmens = new ComboBox();
            cbPostal = new ComboBox();
            label3 = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnSave = new Button();
            btnCancel = new Button();
            txtID = new TextBox();
            ID = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 32);
            label1.TabIndex = 0;
            label1.Text = "Név";
            // 
            // txtNev
            // 
            txtNev.Location = new Point(22, 75);
            txtNev.Name = "txtNev";
            txtNev.Size = new Size(200, 39);
            txtNev.TabIndex = 1;
            txtNev.Validating += txtNev_Validating;
            txtNev.Validated += txtNev_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 255);
            label2.Name = "label2";
            label2.Size = new Size(122, 32);
            label2.TabIndex = 2;
            label2.Text = "Szegmens";
            // 
            // cbSzegmens
            // 
            cbSzegmens.FormattingEnabled = true;
            cbSzegmens.Location = new Point(22, 290);
            cbSzegmens.Name = "cbSzegmens";
            cbSzegmens.Size = new Size(242, 40);
            cbSzegmens.TabIndex = 3;
            // 
            // cbPostal
            // 
            cbPostal.FormattingEnabled = true;
            cbPostal.Location = new Point(22, 420);
            cbPostal.Name = "cbPostal";
            cbPostal.Size = new Size(242, 40);
            cbPostal.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 374);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 4;
            label3.Text = "postal code";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(472, 581);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.Location = new Point(628, 581);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(22, 187);
            txtID.Name = "txtID";
            txtID.Size = new Size(200, 39);
            txtID.TabIndex = 9;
            txtID.Validating += txtID_Validating;
            txtID.Validated += txtID_Validated;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(22, 140);
            ID.Name = "ID";
            ID.Size = new Size(37, 32);
            ID.TabIndex = 8;
            ID.Text = "ID";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 679);
            Controls.Add(txtID);
            Controls.Add(ID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cbPostal);
            Controls.Add(label3);
            Controls.Add(cbSzegmens);
            Controls.Add(label2);
            Controls.Add(txtNev);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ErrorProvider errorProvider1;
        private Button btnCancel;
        private Button btnSave;
        public TextBox txtNev;
        public ComboBox cbSzegmens;
        public ComboBox cbPostal;
        public TextBox txtID;
        private Label ID;
    }
}