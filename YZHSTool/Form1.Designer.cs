namespace SesTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExcelImport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnToDB = new System.Windows.Forms.Button();
            this.btnjmsadd = new System.Windows.Forms.Button();
            this.btnImportJms = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImportJmsGenzong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcelImport
            // 
            this.btnExcelImport.Location = new System.Drawing.Point(57, 18);
            this.btnExcelImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcelImport.Name = "btnExcelImport";
            this.btnExcelImport.Size = new System.Drawing.Size(177, 34);
            this.btnExcelImport.TabIndex = 0;
            this.btnExcelImport.Text = "加载员工数据";
            this.btnExcelImport.UseVisualStyleBackColor = true;
            this.btnExcelImport.Click += new System.EventHandler(this.btnExcelImport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 146);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 444);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(885, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "msg";
            // 
            // btnToDB
            // 
            this.btnToDB.Enabled = false;
            this.btnToDB.Location = new System.Drawing.Point(284, 18);
            this.btnToDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnToDB.Name = "btnToDB";
            this.btnToDB.Size = new System.Drawing.Size(136, 34);
            this.btnToDB.TabIndex = 4;
            this.btnToDB.Text = "导入员工数据";
            this.btnToDB.UseVisualStyleBackColor = true;
            this.btnToDB.Click += new System.EventHandler(this.btnToDB_Click);
            // 
            // btnjmsadd
            // 
            this.btnjmsadd.Location = new System.Drawing.Point(56, 76);
            this.btnjmsadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnjmsadd.Name = "btnjmsadd";
            this.btnjmsadd.Size = new System.Drawing.Size(178, 34);
            this.btnjmsadd.TabIndex = 5;
            this.btnjmsadd.Text = "加载加盟商";
            this.btnjmsadd.UseVisualStyleBackColor = true;
            this.btnjmsadd.Click += new System.EventHandler(this.btnjmsadd_Click);
            // 
            // btnImportJms
            // 
            this.btnImportJms.Enabled = false;
            this.btnImportJms.Location = new System.Drawing.Point(284, 76);
            this.btnImportJms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportJms.Name = "btnImportJms";
            this.btnImportJms.Size = new System.Drawing.Size(136, 34);
            this.btnImportJms.TabIndex = 6;
            this.btnImportJms.Text = "导入加盟商";
            this.btnImportJms.UseVisualStyleBackColor = true;
            this.btnImportJms.Click += new System.EventHandler(this.btnImportJms_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xls";
            // 
            // btnImportJmsGenzong
            // 
            this.btnImportJmsGenzong.Enabled = false;
            this.btnImportJmsGenzong.Location = new System.Drawing.Point(502, 76);
            this.btnImportJmsGenzong.Margin = new System.Windows.Forms.Padding(4);
            this.btnImportJmsGenzong.Name = "btnImportJmsGenzong";
            this.btnImportJmsGenzong.Size = new System.Drawing.Size(136, 34);
            this.btnImportJmsGenzong.TabIndex = 7;
            this.btnImportJmsGenzong.Text = "导入加盟跟踪数据";
            this.btnImportJmsGenzong.UseVisualStyleBackColor = true;
            this.btnImportJmsGenzong.Click += new System.EventHandler(this.btnImportJmsGenzong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 590);
            this.Controls.Add(this.btnImportJmsGenzong);
            this.Controls.Add(this.btnImportJms);
            this.Controls.Add(this.btnjmsadd);
            this.Controls.Add(this.btnToDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcelImport);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcelImport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnToDB;
        private System.Windows.Forms.Button btnjmsadd;
        private System.Windows.Forms.Button btnImportJms;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImportJmsGenzong;
    }
}

