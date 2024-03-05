namespace assignment6
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
            txtStaticContentTable = new Label();
            label2 = new Label();
            txtTableAfter = new Label();
            txtStaticComparisonNumber = new Label();
            txtbxComparisonNumber = new TextBox();
            btnCompare = new Button();
            txtTableBefore = new Label();
            SuspendLayout();
            // 
            // txtStaticContentTable
            // 
            txtStaticContentTable.AutoSize = true;
            txtStaticContentTable.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaticContentTable.Location = new Point(22, 25);
            txtStaticContentTable.Name = "txtStaticContentTable";
            txtStaticContentTable.Size = new Size(166, 20);
            txtStaticContentTable.TabIndex = 0;
            txtStaticContentTable.Text = "Content table (before)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(234, 25);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 1;
            label2.Text = "Content table (after)";
            // 
            // txtTableAfter
            // 
            txtTableAfter.AutoSize = true;
            txtTableAfter.Location = new Point(234, 77);
            txtTableAfter.Name = "txtTableAfter";
            txtTableAfter.Size = new Size(0, 20);
            txtTableAfter.TabIndex = 3;
            // 
            // txtStaticComparisonNumber
            // 
            txtStaticComparisonNumber.AutoSize = true;
            txtStaticComparisonNumber.Location = new Point(22, 495);
            txtStaticComparisonNumber.Name = "txtStaticComparisonNumber";
            txtStaticComparisonNumber.Size = new Size(144, 20);
            txtStaticComparisonNumber.TabIndex = 4;
            txtStaticComparisonNumber.Text = "Comparison number";
            // 
            // txtbxComparisonNumber
            // 
            txtbxComparisonNumber.Location = new Point(190, 488);
            txtbxComparisonNumber.Name = "txtbxComparisonNumber";
            txtbxComparisonNumber.Size = new Size(70, 27);
            txtbxComparisonNumber.TabIndex = 5;
            // 
            // btnCompare
            // 
            btnCompare.Location = new Point(294, 488);
            btnCompare.Name = "btnCompare";
            btnCompare.Size = new Size(94, 29);
            btnCompare.TabIndex = 6;
            btnCompare.Text = "Compare";
            btnCompare.UseVisualStyleBackColor = true;
            btnCompare.Click += btnCompare_Click;
            // 
            // txtTableBefore
            // 
            txtTableBefore.AutoSize = true;
            txtTableBefore.Location = new Point(22, 77);
            txtTableBefore.Name = "txtTableBefore";
            txtTableBefore.Size = new Size(0, 20);
            txtTableBefore.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 542);
            Controls.Add(txtTableBefore);
            Controls.Add(btnCompare);
            Controls.Add(txtbxComparisonNumber);
            Controls.Add(txtStaticComparisonNumber);
            Controls.Add(txtTableAfter);
            Controls.Add(label2);
            Controls.Add(txtStaticContentTable);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtStaticContentTable;
        private Label label2;
        private Label txtTableAfter;
        private Label txtStaticComparisonNumber;
        private TextBox txtbxComparisonNumber;
        private Button btnCompare;
        private Label txtTableBefore;
    }
}