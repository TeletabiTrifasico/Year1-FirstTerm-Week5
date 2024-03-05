namespace assignment7
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
            btnThrow = new Button();
            txtNumberOfThrows = new Label();
            SuspendLayout();
            // 
            // btnThrow
            // 
            btnThrow.Location = new Point(159, 256);
            btnThrow.Name = "btnThrow";
            btnThrow.Size = new Size(171, 42);
            btnThrow.TabIndex = 0;
            btnThrow.Text = "Throw";
            btnThrow.UseVisualStyleBackColor = true;
            btnThrow.Click += btnThrow_Click;
            // 
            // txtNumberOfThrows
            // 
            txtNumberOfThrows.AutoSize = true;
            txtNumberOfThrows.Location = new Point(37, 42);
            txtNumberOfThrows.Name = "txtNumberOfThrows";
            txtNumberOfThrows.Size = new Size(0, 20);
            txtNumberOfThrows.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 322);
            Controls.Add(txtNumberOfThrows);
            Controls.Add(btnThrow);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThrow;
        private Label txtNumberOfThrows;
    }
}