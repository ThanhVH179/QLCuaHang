namespace GUI_QLBanHang
{
    partial class FrmThongKe
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
            this.menuThongKe = new System.Windows.Forms.MenuStrip();
            this.NhapKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TonKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvThongKeHang = new System.Windows.Forms.DataGridView();
            this.menuThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHang)).BeginInit();
            this.SuspendLayout();
            // 
            // menuThongKe
            // 
            this.menuThongKe.AllowMerge = false;
            this.menuThongKe.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuThongKe.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhapKhoToolStripMenuItem,
            this.TonKhoToolStripMenuItem});
            this.menuThongKe.Location = new System.Drawing.Point(0, 0);
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(782, 31);
            this.menuThongKe.TabIndex = 0;
            this.menuThongKe.Text = "menuThongKe";
            // 
            // NhapKhoToolStripMenuItem
            // 
            this.NhapKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhapKhoToolStripMenuItem.Name = "NhapKhoToolStripMenuItem";
            this.NhapKhoToolStripMenuItem.Size = new System.Drawing.Size(178, 27);
            this.NhapKhoToolStripMenuItem.Text = "Sản phẩm nhập kho";
            this.NhapKhoToolStripMenuItem.Click += new System.EventHandler(this.NhapKhoToolStripMenuItem_Click);
            // 
            // TonKhoToolStripMenuItem
            // 
            this.TonKhoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TonKhoToolStripMenuItem.Name = "TonKhoToolStripMenuItem";
            this.TonKhoToolStripMenuItem.Size = new System.Drawing.Size(86, 27);
            this.TonKhoToolStripMenuItem.Text = "Tồn kho";
            this.TonKhoToolStripMenuItem.Click += new System.EventHandler(this.TonKhoToolStripMenuItem_Click);
            // 
            // dgvThongKeHang
            // 
            this.dgvThongKeHang.AllowUserToAddRows = false;
            this.dgvThongKeHang.AllowUserToDeleteRows = false;
            this.dgvThongKeHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongKeHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKeHang.Location = new System.Drawing.Point(12, 50);
            this.dgvThongKeHang.Name = "dgvThongKeHang";
            this.dgvThongKeHang.RowHeadersVisible = false;
            this.dgvThongKeHang.RowHeadersWidth = 51;
            this.dgvThongKeHang.RowTemplate.Height = 24;
            this.dgvThongKeHang.Size = new System.Drawing.Size(758, 241);
            this.dgvThongKeHang.TabIndex = 1;
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 303);
            this.Controls.Add(this.dgvThongKeHang);
            this.Controls.Add(this.menuThongKe);
            this.MainMenuStrip = this.menuThongKe;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmThongKe";
            this.menuThongKe.ResumeLayout(false);
            this.menuThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKeHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem NhapKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TonKhoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvThongKeHang;
    }
}