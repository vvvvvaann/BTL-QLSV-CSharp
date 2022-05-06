
namespace CrystalReport
{
    partial class CrystalReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInDSSV
            // 
            this.btnInDSSV.Location = new System.Drawing.Point(403, 162);
            this.btnInDSSV.Name = "btnInDSSV";
            this.btnInDSSV.Size = new System.Drawing.Size(200, 50);
            this.btnInDSSV.TabIndex = 0;
            this.btnInDSSV.Text = "In Danh Sach Sinh Vien";
            this.btnInDSSV.UseVisualStyleBackColor = true;
            this.btnInDSSV.Click += new System.EventHandler(this.btnInDSSV_Click);
            // 
            // btnInDSKQ
            // 
            this.btnInDSKQ.Location = new System.Drawing.Point(664, 162);
            this.btnInDSKQ.Name = "btnInDSKQ";
            this.btnInDSKQ.Size = new System.Drawing.Size(200, 50);
            this.btnInDSKQ.TabIndex = 1;
            this.btnInDSKQ.Text = "In Danh Sach Ket Qua";
            this.btnInDSKQ.UseVisualStyleBackColor = true;
            this.btnInDSKQ.Click += new System.EventHandler(this.btnInDSKQ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(522, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crystal Report";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(583, 304);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 40);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoat";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // CrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInDSKQ);
            this.Controls.Add(this.btnInDSSV);
            this.Name = "CrystalReport";
            this.Text = "Crystal Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInDSSV;
        private System.Windows.Forms.Button btnInDSKQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}