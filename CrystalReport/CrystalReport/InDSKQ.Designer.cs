
namespace CrystalReport
{
    partial class InDSKQ
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
            this.crystalReportDSKQ = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportDSKQ
            // 
            this.crystalReportDSKQ.ActiveViewIndex = -1;
            this.crystalReportDSKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportDSKQ.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportDSKQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportDSKQ.Location = new System.Drawing.Point(0, 0);
            this.crystalReportDSKQ.Name = "crystalReportDSKQ";
            this.crystalReportDSKQ.Size = new System.Drawing.Size(1262, 673);
            this.crystalReportDSKQ.TabIndex = 0;
            // 
            // InDSKQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.crystalReportDSKQ);
            this.Name = "InDSKQ";
            this.Text = "In DSKQ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportDSKQ;
    }
}