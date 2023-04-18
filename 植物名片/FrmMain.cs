using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mahoroshi.Database;

namespace 植物名片
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// OLEDB数据库适配器
        /// </summary>
        private MiaoOleDbAdapter _adapter;
        /// <summary>
        /// 当前数据文件路径
        /// </summary>
        private string _dataFile;
        /// <summary>
        ///  查询植物窗体
        /// </summary>
        private Frm查询植物 _frmQuery;
        /// <summary>
        ///  植物名片窗体
        /// </summary>
        private Frm植物名片 _frmPlant;

        public FrmMain()
        {
            InitializeComponent();
            _adapter = new MiaoOleDbAdapter();  // 以默认数据库建立OLEDB数据连接
            _adapter.Test();
        }

        private void btn添加植物_Click(object sender, EventArgs e)
        {
            if (_frmPlant != null
                && !_frmPlant.IsDisposed)
            {
                _frmPlant.Close();
                _frmPlant.Dispose();
            }
            _frmPlant = new Frm植物名片(_adapter, 0, FormCrtState.Add);
            _frmPlant.ShowDialog();
        }

        private void btn查询植物_Click(object sender, EventArgs e)
        {
            if (_frmQuery == null
                || _frmQuery.IsDisposed)
            {
                _frmQuery = new Frm查询植物(_adapter);
            }

            _frmQuery.ShowWithLocation(Right + 10, Top);
        }

        private void btn阅览模式_Click(object sender, EventArgs e)
        {

        }

        private void btn数字统计_Click(object sender, EventArgs e)
        {

        }

        private void btn更换数据库_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();                  // 新建 文件打开对话框
            fd1.Filter = "Access数据文件(*.mdb;*.accdb)|*.mdb;*.accdb"; // 文件筛选器：Access数据文件
            fd1.Multiselect = false;                                    // 设置 文件多选：否
            fd1.CheckFileExists = true;                                 // 设置 检查输入文件名存在：是
            fd1.CheckPathExists = true;                                 // 设置 检查输入文件路径存在：是

            if (fd1.ShowDialog() == DialogResult.OK)                    // 文件打开对话框返回结果为 OK？
            {
                _dataFile = fd1.FileName;                               // 获取 当前数据文件路径
                _adapter.DbPath = _dataFile;                            // 设置 当前数据文件路径
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
