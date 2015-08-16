namespace MultiSelectGrid
{
    partial class Form1
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
            this.dataGridViewUC1 = new MultiSelectGrid.DataGridViewUC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUC1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUC1
            // 
            this.dataGridViewUC1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUC1.Location = new System.Drawing.Point(46, 22);
            this.dataGridViewUC1.Name = "dataGridViewUC1";
            this.dataGridViewUC1.Size = new System.Drawing.Size(493, 150);
            this.dataGridViewUC1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 355);
            this.Controls.Add(this.dataGridViewUC1);
            this.Name = "Form1";
            this.Text = "Multi Row Select Gridview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUC1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewUC dataGridViewUC1;

    }
}

