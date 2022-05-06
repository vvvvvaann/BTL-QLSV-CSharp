
namespace CrystalReport
{
    partial class CrystalReporttest
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
            this.btnInDSSV = new System.Windows.Forms.Button();
            this.btnInDSKQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInDSSV
            // 
            this.btnInDSSV.Location = new System.Drawing.Point(393, 332);
            this.btnInDSSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInDSSV.Name = "btnInDSSV";
            this.btnInDSSV.Size = new System.Drawing.Size(75, 38);
            this.btnInDSSV.TabIndex = 0;
            this.btnInDSSV.Text = "In DSSV";
            this.btnInDSSV.UseVisualStyleBackColor = true;
            this.btnInDSSV.Click += new System.EventHandler(this.btnInDSSV_Click);
            // 
            // btnInDSKQ
            // 
            this.btnInDSKQ.Location = new System.Drawing.Point(578, 332);
            this.btnInDSKQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInDSKQ.Name = "btnInDSKQ";
            this.btnInDSKQ.Size = new System.Drawing.Size(75, 38);
            this.btnInDSKQ.TabIndex = 1;
            this.btnInDSKQ.Text = "In DSKQ";
            this.btnInDSKQ.UseVisualStyleBackColor = true;
            this.btnInDSKQ.Click += new System.EventHandler(this.btnInDSKQ_Click);
            // 
            // CrystalReporttest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 841);
            this.Controls.Add(this.btnInDSKQ);
            this.Controls.Add(this.btnInDSSV);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrystalReporttest";
            this.Text = "Crystal Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInDSSV;
        private System.Windows.Forms.Button btnInDSKQ;
    }
}