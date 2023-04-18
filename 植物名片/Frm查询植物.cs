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
    public partial class Frm查询植物 : Form
    {

        /// <summary>
        /// OLE DB适配器
        /// </summary>
        private MiaoOleDbAdapter _adapter;
        
        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="adapter">数据库适配器</param>
        public Frm查询植物(MiaoOleDbAdapter adapter)
        {
            _adapter = adapter;         // 设置 OLE DB 适配器
            InitializeComponent();      // 初始化 全部窗体组件
        }

        private Frm查询植物()
        {        }
        /// <summary>
        /// 以给定位置显示窗体
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void ShowWithLocation(int left, int top)
        {
            this.Show();
            this.Left = left;
            this.Top = top;
        }

        private void btn清除条件_Click(object sender, EventArgs e)
        {
            txt中文学名.Text = "";
            txt拉丁学名.Text = "";
            txt别称.Text = "";
            txt门.Text = "";
            txt纲.Text = "";
            txt目.Text = "";
            txt科.Text = "";
            txt属.Text = "";
            txt种.Text = "";
            txt形态特征.Text = "";
            txt生长环境.Text = "";
            txt分布范围.Text = "";
            txt用途.Text = "";
            txt其他.Text = "";
        }

        private void btn开始查询_Click(object sender, EventArgs e)
        {
            string sqlStr = "SELECT 编号,中文学名,拉丁学名 FROM 植物 WHERE 1=1";
            // 添加查询条件
            if (!string.IsNullOrEmpty(txt中文学名.Text))
            {
                sqlStr += " AND 中文学名 LIKE \'%" + txt中文学名.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt拉丁学名.Text))
            {
                sqlStr += " AND 拉丁学名 LIKE \'%" + txt拉丁学名.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt门.Text))
            {
                sqlStr += " AND 门 LIKE \'%" + txt门.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt纲.Text))
            {
                sqlStr += " AND 纲 LIKE \'%" + txt纲.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt目.Text))
            {
                sqlStr += " AND 目 LIKE \'%" + txt目.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt科.Text))
            {
                sqlStr += " AND 科 LIKE \'%" + txt科.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt属.Text))
            {
                sqlStr += " AND 属 LIKE \'%" + txt属.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt种.Text))
            {
                sqlStr += " AND 种 LIKE \'%" + txt种.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt形态特征.Text))
            {
                sqlStr += " AND 形态特征 LIKE \'%" + txt形态特征.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt生长环境.Text))
            {
                sqlStr += " AND 生长环境 LIKE \'%" + txt生长环境.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt分布范围.Text))
            {
                sqlStr += " AND 分布范围 LIKE \'%" + txt分布范围.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt用途.Text))
            {
                sqlStr += " AND 用途 LIKE \'%" + txt用途.Text + "%\'";
            }
            if (!string.IsNullOrEmpty(txt其他.Text))
            {
                sqlStr += " AND 其他 LIKE \'%" + txt其他.Text + "%\'";
            }
            sqlStr += ";";

            DataTable dt = _adapter.GetDataTable(sqlStr);       // 获取 查询结果表
            lbl数字统计.Text = "共" + dt.Rows.Count + "条记录";

            dgvResult.DataSource = dt;                          // 设置 结果显示DGV         
            dgvResult.Columns["编号"].Visible = false;          // 隐藏 [编号]列
            dgvResult.Columns["中文学名"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;        // 设置 [中文学名]列宽：自动适应全部单元格
            dgvResult.Columns["拉丁学名"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;        // 设置 [拉丁学名]列宽：自动适应全部单元格
        }

        private void dgvResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)                                    // 被双击的不是表头？
            {
                DataGridViewRow myRow = dgvResult.Rows[e.RowIndex]; // 获取 被选中的显示行
                int plantId = (int)myRow.Cells["编号"].Value;       // 获取 被选中的植物编号
                Frm植物名片 myFrm = new Frm植物名片(_adapter,
                    plantId, FormCrtState.View);                    // 新建 植物名片窗体
                myFrm.ShowWithLocation(Left, Top);                  // 模态显示 植物名片窗体
            }
        }

        private void Frm查询植物_Load(object sender, EventArgs e)
        {

        }
    }
}
