﻿
namespace CrystalReport
{
    partial class InDSSV
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
            this.crystalReportDSSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportDSSV
            // 
            this.crystalReportDSSV.ActiveViewIndex = -1;
            this.crystalReportDSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportDSSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportDSSV.Location = new System.Drawing.Point(0, 0);
            this.crystalReportDSSV.Name = "crystalReportDSSV";
            this.crystalReportDSSV.Size = new System.Drawing.Size(1262, 673);
            this.crystalReportDSSV.TabIndex = 0;
            // 
            // InDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.crystalReportDSSV);
            this.Name = "InDSSV";
            this.Text = "In DSSV";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportDSSV;
    }
}

