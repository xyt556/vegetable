namespace 植物名片
{
    partial class Frm查询植物
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn开始查询 = new System.Windows.Forms.Button();
            this.txt中文学名 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt拉丁学名 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt别称 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt形态特征 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt生长环境 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt门 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt纲 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt目 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt科 = new System.Windows.Forms.TextBox();
            this.txt属 = new System.Windows.Forms.TextBox();
            this.txt种 = new System.Windows.Forms.TextBox();
            this.txt分布范围 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt用途 = new System.Windows.Forms.TextBox();
            this.txt其他 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn清除条件 = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl数字统计 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "（模糊查询模式）请输入查询条件，无要求的项目不填：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "中文学名";
            // 
            // btn开始查询
            // 
            this.btn开始查询.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn开始查询.Location = new System.Drawing.Point(165, 290);
            this.btn开始查询.Name = "btn开始查询";
            this.btn开始查询.Size = new System.Drawing.Size(127, 30);
            this.btn开始查询.TabIndex = 15;
            this.btn开始查询.Text = "开始查询(&Q)";
            this.btn开始查询.UseVisualStyleBackColor = true;
            this.btn开始查询.Click += new System.EventHandler(this.btn开始查询_Click);
            // 
            // txt中文学名
            // 
            this.txt中文学名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt中文学名.Location = new System.Drawing.Point(90, 50);
            this.txt中文学名.Name = "txt中文学名";
            this.txt中文学名.Size = new System.Drawing.Size(149, 26);
            this.txt中文学名.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "拉丁学名";
            // 
            // txt拉丁学名
            // 
            this.txt拉丁学名.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt拉丁学名.Location = new System.Drawing.Point(90, 82);
            this.txt拉丁学名.Name = "txt拉丁学名";
            this.txt拉丁学名.Size = new System.Drawing.Size(149, 26);
            this.txt拉丁学名.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "别称";
            // 
            // txt别称
            // 
            this.txt别称.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt别称.Location = new System.Drawing.Point(90, 114);
            this.txt别称.Name = "txt别称";
            this.txt别称.Size = new System.Drawing.Size(149, 26);
            this.txt别称.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(268, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "门";
            // 
            // txt形态特征
            // 
            this.txt形态特征.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt形态特征.Location = new System.Drawing.Point(90, 146);
            this.txt形态特征.Name = "txt形态特征";
            this.txt形态特征.Size = new System.Drawing.Size(149, 26);
            this.txt形态特征.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(268, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "纲";
            // 
            // txt生长环境
            // 
            this.txt生长环境.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt生长环境.Location = new System.Drawing.Point(90, 178);
            this.txt生长环境.Name = "txt生长环境";
            this.txt生长环境.Size = new System.Drawing.Size(149, 26);
            this.txt生长环境.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(268, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "目";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(268, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "科";
            // 
            // txt门
            // 
            this.txt门.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt门.Location = new System.Drawing.Point(298, 50);
            this.txt门.Name = "txt门";
            this.txt门.Size = new System.Drawing.Size(100, 26);
            this.txt门.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(268, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "属";
            // 
            // txt纲
            // 
            this.txt纲.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt纲.Location = new System.Drawing.Point(298, 82);
            this.txt纲.Name = "txt纲";
            this.txt纲.Size = new System.Drawing.Size(100, 26);
            this.txt纲.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(268, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "种";
            // 
            // txt目
            // 
            this.txt目.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt目.Location = new System.Drawing.Point(298, 114);
            this.txt目.Name = "txt目";
            this.txt目.Size = new System.Drawing.Size(100, 26);
            this.txt目.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "形态特征";
            // 
            // txt科
            // 
            this.txt科.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt科.Location = new System.Drawing.Point(298, 146);
            this.txt科.Name = "txt科";
            this.txt科.Size = new System.Drawing.Size(100, 26);
            this.txt科.TabIndex = 10;
            // 
            // txt属
            // 
            this.txt属.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt属.Location = new System.Drawing.Point(298, 178);
            this.txt属.Name = "txt属";
            this.txt属.Size = new System.Drawing.Size(100, 26);
            this.txt属.TabIndex = 11;
            // 
            // txt种
            // 
            this.txt种.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt种.Location = new System.Drawing.Point(298, 210);
            this.txt种.Name = "txt种";
            this.txt种.Size = new System.Drawing.Size(100, 26);
            this.txt种.TabIndex = 12;
            // 
            // txt分布范围
            // 
            this.txt分布范围.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt分布范围.Location = new System.Drawing.Point(90, 210);
            this.txt分布范围.Name = "txt分布范围";
            this.txt分布范围.Size = new System.Drawing.Size(149, 26);
            this.txt分布范围.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(12, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "生长环境";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(12, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "分布范围";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(252, 245);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "其他";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(12, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "用途";
            // 
            // txt用途
            // 
            this.txt用途.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt用途.Location = new System.Drawing.Point(90, 242);
            this.txt用途.Name = "txt用途";
            this.txt用途.Size = new System.Drawing.Size(149, 26);
            this.txt用途.TabIndex = 6;
            // 
            // txt其他
            // 
            this.txt其他.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt其他.Location = new System.Drawing.Point(298, 242);
            this.txt其他.Name = "txt其他";
            this.txt其他.Size = new System.Drawing.Size(100, 26);
            this.txt其他.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(435, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "查询结果：";
            // 
            // btn清除条件
            // 
            this.btn清除条件.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn清除条件.Location = new System.Drawing.Point(15, 290);
            this.btn清除条件.Name = "btn清除条件";
            this.btn清除条件.Size = new System.Drawing.Size(127, 30);
            this.btn清除条件.TabIndex = 14;
            this.btn清除条件.Text = "清除条件(&C)";
            this.btn清除条件.UseVisualStyleBackColor = true;
            this.btn清除条件.Click += new System.EventHandler(this.btn清除条件_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.AllowUserToAddRows = false;
            this.dgvResult.AllowUserToDeleteRows = false;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(427, 50);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.ReadOnly = true;
            this.dgvResult.RowTemplate.Height = 23;
            this.dgvResult.Size = new System.Drawing.Size(316, 218);
            this.dgvResult.TabIndex = 3;
            this.dgvResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResult_CellDoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(435, 280);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(232, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "双击目标，可查看详细名片信息";
            // 
            // lbl数字统计
            // 
            this.lbl数字统计.AutoSize = true;
            this.lbl数字统计.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl数字统计.Location = new System.Drawing.Point(655, 18);
            this.lbl数字统计.Name = "lbl数字统计";
            this.lbl数字统计.Size = new System.Drawing.Size(80, 16);
            this.lbl数字统计.TabIndex = 0;
            this.lbl数字统计.Text = "共0条记录";
            // 
            // Frm查询植物
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 332);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.txt其他);
            this.Controls.Add(this.txt种);
            this.Controls.Add(this.txt用途);
            this.Controls.Add(this.txt属);
            this.Controls.Add(this.txt分布范围);
            this.Controls.Add(this.txt生长环境);
            this.Controls.Add(this.txt科);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt形态特征);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt目);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt别称);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl数字统计);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt纲);
            this.Controls.Add(this.txt拉丁学名);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt门);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt中文学名);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn清除条件);
            this.Controls.Add(this.btn开始查询);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm查询植物";
            this.Text = "查询植物";
            this.Load += new System.EventHandler(this.Frm查询植物_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn开始查询;
        private System.Windows.Forms.TextBox txt中文学名;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt拉丁学名;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt别称;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt形态特征;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt生长环境;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt门;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt纲;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt目;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt科;
        private System.Windows.Forms.TextBox txt属;
        private System.Windows.Forms.TextBox txt种;
        private System.Windows.Forms.TextBox txt分布范围;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt用途;
        private System.Windows.Forms.TextBox txt其他;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn清除条件;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl数字统计;
    }
}