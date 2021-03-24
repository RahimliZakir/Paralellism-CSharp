namespace _2.ThreadPools.WindowsFormsApp
{
    partial class Form
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
            this.btnAsynchronously = new System.Windows.Forms.Button();
            this.btnSynchonously = new System.Windows.Forms.Button();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.numericUpToDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpToDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsynchronously
            // 
            this.btnAsynchronously.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsynchronously.Location = new System.Drawing.Point(411, 71);
            this.btnAsynchronously.Name = "btnAsynchronously";
            this.btnAsynchronously.Size = new System.Drawing.Size(212, 64);
            this.btnAsynchronously.TabIndex = 14;
            this.btnAsynchronously.Text = "Execute Asynchonously";
            this.btnAsynchronously.UseVisualStyleBackColor = true;
            this.btnAsynchronously.Click += new System.EventHandler(this.btnAsynchronously_Click);
            // 
            // btnSynchonously
            // 
            this.btnSynchonously.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSynchonously.Location = new System.Drawing.Point(68, 71);
            this.btnSynchonously.Name = "btnSynchonously";
            this.btnSynchonously.Size = new System.Drawing.Size(212, 64);
            this.btnSynchonously.TabIndex = 13;
            this.btnSynchonously.Text = "Execute Synchonously";
            this.btnSynchonously.UseVisualStyleBackColor = true;
            this.btnSynchonously.Click += new System.EventHandler(this.btnSynchonously_Click);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.ItemHeight = 20;
            this.lst2.Location = new System.Drawing.Point(411, 160);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(212, 284);
            this.lst2.TabIndex = 12;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.ItemHeight = 20;
            this.lst1.Location = new System.Drawing.Point(68, 160);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(212, 284);
            this.lst1.TabIndex = 11;
            // 
            // numericUpToDown
            // 
            this.numericUpToDown.Location = new System.Drawing.Point(68, 18);
            this.numericUpToDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpToDown.Name = "numericUpToDown";
            this.numericUpToDown.Size = new System.Drawing.Size(120, 26);
            this.numericUpToDown.TabIndex = 10;
            this.numericUpToDown.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnAsynchronously);
            this.Controls.Add(this.btnSynchonously);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.numericUpToDown);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpToDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAsynchronously;
        private System.Windows.Forms.Button btnSynchonously;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.NumericUpDown numericUpToDown;
    }
}

