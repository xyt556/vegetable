namespace 植物名片
{
    partial class FrmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn添加植物 = new System.Windows.Forms.Button();
            this.btn更换数据库 = new System.Windows.Forms.Button();
            this.btn查询植物 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn添加植物
            // 
            this.btn添加植物.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn添加植物.Location = new System.Drawing.Point(30, 12);
            this.btn添加植物.Name = "btn添加植物";
            this.btn添加植物.Size = new System.Drawing.Size(127, 30);
            this.btn添加植物.TabIndex = 0;
            this.btn添加植物.Text = "添加植物(&A)";
            this.btn添加植物.UseVisualStyleBackColor = true;
            this.btn添加植物.Click += new System.EventHandler(this.btn添加植物_Click);
            // 
            // btn更换数据库
            // 
            this.btn更换数据库.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn更换数据库.Location = new System.Drawing.Point(30, 156);
            this.btn更换数据库.Name = "btn更换数据库";
            this.btn更换数据库.Size = new System.Drawing.Size(127, 30);
            this.btn更换数据库.TabIndex = 2;
            this.btn更换数据库.Text = "更换数据库(&C)";
            this.btn更换数据库.UseVisualStyleBackColor = true;
            this.btn更换数据库.Click += new System.EventHandler(this.btn更换数据库_Click);
            // 
            // btn查询植物
            // 
            this.btn查询植物.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn查询植物.Location = new System.Drawing.Point(30, 48);
            this.btn查询植物.Name = "btn查询植物";
            this.btn查询植物.Size = new System.Drawing.Size(127, 30);
            this.btn查询植物.TabIndex = 1;
            this.btn查询植物.Text = "查询植物(&Q)";
            this.btn查询植物.UseVisualStyleBackColor = true;
            this.btn查询植物.Click += new System.EventHandler(this.btn查询植物_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 211);
            this.Controls.Add(this.btn更换数据库);
            this.Controls.Add(this.btn查询植物);
            this.Controls.Add(this.btn添加植物);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "植物名片";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn添加植物;
        private System.Windows.Forms.Button btn更换数据库;
        private System.Windows.Forms.Button btn查询植物;

    }
}

