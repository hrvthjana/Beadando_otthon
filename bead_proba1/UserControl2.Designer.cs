namespace bead_proba1
{
    partial class UserControl2
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            btnDel = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(646, 39);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(71, 116);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(646, 452);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(761, 116);
            button1.Name = "button1";
            button1.Size = new Size(150, 125);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(761, 266);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 125);
            btnDel.TabIndex = 3;
            btnDel.Text = "-";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(btnDel);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "UserControl2";
            Size = new Size(1451, 633);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Button btnDel;
    }
}
