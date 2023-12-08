namespace bead_proba1
{
    partial class UserControl3
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
            pDiag = new Panel();
            btnGenerate = new Button();
            radioState = new RadioButton();
            radioCategory = new RadioButton();
            SuspendLayout();
            // 
            // pDiag
            // 
            pDiag.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pDiag.BackColor = SystemColors.ControlLight;
            pDiag.Location = new Point(49, 37);
            pDiag.Name = "pDiag";
            pDiag.Size = new Size(1052, 713);
            pDiag.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGenerate.Location = new Point(1129, 37);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(326, 46);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate!";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // radioState
            // 
            radioState.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioState.AutoSize = true;
            radioState.Checked = true;
            radioState.Location = new Point(1129, 100);
            radioState.Name = "radioState";
            radioState.Size = new Size(98, 36);
            radioState.TabIndex = 2;
            radioState.TabStop = true;
            radioState.Text = "State";
            radioState.UseVisualStyleBackColor = true;
            // 
            // radioCategory
            // 
            radioCategory.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioCategory.AutoSize = true;
            radioCategory.Location = new Point(1129, 152);
            radioCategory.Name = "radioCategory";
            radioCategory.Size = new Size(155, 36);
            radioCategory.TabIndex = 3;
            radioCategory.Text = "Catgegory";
            radioCategory.UseVisualStyleBackColor = true;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(radioCategory);
            Controls.Add(radioState);
            Controls.Add(btnGenerate);
            Controls.Add(pDiag);
            Name = "UserControl3";
            Size = new Size(1504, 809);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pDiag;
        private Button btnGenerate;
        private RadioButton radioState;
        private RadioButton radioCategory;
    }
}
