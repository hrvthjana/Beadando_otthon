namespace bead_proba1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uc1 = new Button();
            uc2 = new Button();
            uc3 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // uc1
            // 
            uc1.Location = new Point(19, 29);
            uc1.Name = "uc1";
            uc1.Size = new Size(150, 46);
            uc1.TabIndex = 0;
            uc1.Text = "uc1";
            uc1.UseVisualStyleBackColor = true;
            uc1.Click += uc1_Click;
            // 
            // uc2
            // 
            uc2.Location = new Point(19, 95);
            uc2.Name = "uc2";
            uc2.Size = new Size(150, 46);
            uc2.TabIndex = 1;
            uc2.Text = "uc2";
            uc2.UseVisualStyleBackColor = true;
            uc2.Click += uc2_Click;
            // 
            // uc3
            // 
            uc3.Location = new Point(19, 156);
            uc3.Name = "uc3";
            uc3.Size = new Size(150, 46);
            uc3.TabIndex = 2;
            uc3.Text = "uc3";
            uc3.UseVisualStyleBackColor = true;
            uc3.Click += uc3_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Location = new Point(190, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 677);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 718);
            Controls.Add(panel1);
            Controls.Add(uc3);
            Controls.Add(uc2);
            Controls.Add(uc1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button uc1;
        private Button uc2;
        private Button uc3;
        private Panel panel1;
    }
}