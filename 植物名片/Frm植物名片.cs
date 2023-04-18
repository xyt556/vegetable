using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Mahoroshi.Database;

namespace 植物名片
{
    public partial class Frm植物名片 : Form
    {
        /// <summary>
        /// OLE DB适配器
        /// </summary>
        private MiaoOleDbAdapter _adapter;
        /// <summary>
        /// 窗体创建状态
        /// </summary>
        private FormCrtState _frmSt= FormCrtState.View;
        /// <summary>
        /// 植物照片显示窗体
        /// </summary>
        private Frm植物照片 _frmPic;
        /// <summary>
        /// 当前植物ID
        /// </summary>
        private int _plantId = 0;
        /// <summary>
        /// 当前植物名片数据表
        /// </summary>
        private DataTable _dt;
        /// <summary>
        /// 当前植物照片
        /// </summary>
        private Image _plantPic;
        /// <summary>
        /// 当前上传植物照片路径
        /// </summary>
        private string _picPath = "";
        /// <summary>
        /// 当前植物照片数据是否已更新
        /// </summary>
        private bool _picUpdate = false;

        #region 公共方法
        public Frm植物名片(MiaoOleDbAdapter adapter, int plantId, FormCrtState state)
        {
            _frmSt = state;         // 设置 窗体创建状态
            _adapter = adapter;     // 设置 OLE DB 适配器
            _plantId = plantId;     // 设置 当前植物ID
            InitializeComponent();
        }
        /// <summary>
        /// 以给定位置显示窗体
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void ShowWithLocation(int left, int top)
        {
            this.Left = left;
            this.Top = top;
            this.ShowDialog();
        }
        #endregion

        #region 窗体事件处理
        /// <summary>
        /// 窗体加载事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm植物名片_Load(object sender, EventArgs e)
        {
            InitialUI();            // 初始化UI
        }
        /// <summary>
        /// 窗体退出事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm植物名片_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_frmPic != null && !_frmPic.IsDisposed) // 植物照片窗体未释放？
            {
                _frmPic.Close();    // 关闭 植物照片窗体
                _frmPic.Dispose();  // 释放 植物照片窗体
            }
        }
        #endregion

        #region 按钮事件处理
        /// <summary>
        /// 上传照片按钮 点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn上传照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();                  // 新建 文件打开对话框
            fd1.Filter = "图片文件(*.bmp;*.png;*.jpg;*.jpeg;*.tiff)|*.bmp;*.png;*.jpg;*.jpeg;*.tiff"; // 文件筛选器：图片文件
            fd1.Multiselect = false;                                    // 设置 文件多选：否
            fd1.CheckFileExists = true;                                 // 设置 检查输入文件名存在：是
            fd1.CheckPathExists = true;                                 // 设置 检查输入文件路径存在：是

            if (fd1.ShowDialog() == DialogResult.OK)                    // 文件打开对话框返回结果为 OK？
            {
                _picPath = fd1.FileName;
                _picUpdate = true;
                _plantPic = Image.FromFile(_picPath);
            }
        }

        private void btn查看照片_Click(object sender, EventArgs e)
        {
            if (_frmPic == null
                || _frmPic.IsDisposed)
            {
                _frmPic = new Frm植物照片();
            }
            _frmPic.SetFormPic(_plantPic);
            _frmPic.ShowWithLocation(Right + 10, Top);
        }
        /// <summary>
        /// 返回按钮 点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn返回_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 保存按钮 点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn保存_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_frmSt)                         // 判断当前窗体状态
                {
                    case FormCrtState.Add:              // 添加状态？
                        if (IfPlantExist(txt中文学名.Text, txt拉丁学名.Text)) // 输入有误？
                        {
                            string message = "该植物中文学名或拉丁学名已在数据库中存在！";
                            message += "\n建议您将中文学名和拉丁学名以“临时”重命名后保存并检查现有数据是否有误。";
                            MessageBox.Show(message);
                        }
                        else                            // 输入无误？
                        {
                            AddPlantInfo();             // 新增 植物名片信息
                            GetPlantId();               // 重新获取 植物名片ID
                            if (_picUpdate)             // 植物照片已重新上传？
                            { UpdatePlantPicture(); }   // 更新 植物照片
                            _frmSt = FormCrtState.View; // 录入成功后转为 浏览模式
                            InitialUI();                // 初始化UI
                        }
                        break;
                    case FormCrtState.Mod:              // 修改状态？
                        UpdatePlantInfo();              // 更新 植物名片信息
                        if (_picUpdate)                 // 植物照片已重新上传？
                        { UpdatePlantPicture(); }       // 更新 植物照片
                        break;
                    default:
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        /// <summary>
        /// 切换模式按钮 点击事件处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn模式切换_Click(object sender, EventArgs e)
        {
            if (_frmSt == FormCrtState.View)
            {
                _frmSt = FormCrtState.Mod;
            }
            else if (_frmSt == FormCrtState.Mod)
            {
                _frmSt = FormCrtState.View;
            }
            InitialUI();
        }
        /// <summary>
        /// 上一个 按钮点击事件处理【保留】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn上一个_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 下一个 按钮点击事件处理【保留】
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn下一个_Click(object sender, EventArgs e)
        {

        }
        #endregion

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void InitialUI()
        {
            switch (_frmSt)
            {
                case FormCrtState.Add:      // A1.添加信息状态？
                    ShowAddModeUI();        // 按浏览模式显示UI
                    break;
                case FormCrtState.View:     // A2. 浏览信息状态？
                    ShowBrowseModeUI();     // 按浏览模式显示UI
                    ShowCurrentPlant();     // 显示 当前植物名片信息
                    ReadPlantPic();         // 获取 当前植物的外观图片
                    break;
                case FormCrtState.Mod:      // A3. 修改信息状态？
                    ShowModifyModeUI();     // 按修改模式显示UI
                    ShowCurrentPlant();     // 显示 当前植物名片信息
                    ReadPlantPic();         // 获取 当前植物的外观图片
                    break;
                default:                    // A4. 其他情况？[异常情况]
                    this.Close();           // 关闭本窗体
                    break;
            }
        }

        #region 界面显示
        /// <summary>
        /// 显示添加模式界面
        /// </summary>
        private void ShowAddModeUI()
        {
            this.Text = "添加植物名片";           // 设置 标题栏文字：添加
            btn上传照片.Visible = true;           // 显示 上传植物照片按钮
            btn保存.Visible = true;               // 显示 保存按钮
            btn模式切换.Visible = false;          // 隐藏 模式切换按钮
            btn下一个.Visible = false;            // 隐藏 下一条按钮 
            btn上一个.Visible = false;            // 隐藏 上一条按钮 
            // 所有输入框可输入
            txt中文学名.ReadOnly = false;
            txt拉丁学名.ReadOnly = false;
            txt别称.ReadOnly = false;
            txt门.ReadOnly = false;
            txt纲.ReadOnly = false;
            txt目.ReadOnly = false;
            txt科.ReadOnly = false;
            txt属.ReadOnly = false;
            txt种.ReadOnly = false;
            txt形态特征.ReadOnly = false;
            txt生长环境.ReadOnly = false;
            txt分布范围.ReadOnly = false;
            txt用途.ReadOnly = false;
            txt其他.ReadOnly = false;
        }
        /// <summary>
        /// 显示浏览模式界面
        /// </summary>
        private void ShowBrowseModeUI()
        {
            this.Text = "浏览植物名片";           // 设置 标题栏文字：浏览
            btn上传照片.Visible = false;          // 隐藏 上传植物照片按钮
            btn保存.Visible = false;              // 隐藏 保存按钮
            btn模式切换.Text = "修改模式";        // 设置 模式切换按钮文本
            btn模式切换.Visible = true;           // 显示 模式切换按钮
            btn下一个.Visible = false;            // 隐藏 下一条按钮 
            btn上一个.Visible = false;            // 隐藏 上一条按钮 
            // 所有输入框只读
            txt中文学名.ReadOnly = true;
            txt拉丁学名.ReadOnly = true;
            txt别称.ReadOnly = true;
            txt门.ReadOnly = true;
            txt纲.ReadOnly = true;
            txt目.ReadOnly = true;
            txt科.ReadOnly = true;
            txt属.ReadOnly = true;
            txt种.ReadOnly = true;
            txt形态特征.ReadOnly = true;
            txt生长环境.ReadOnly = true;
            txt分布范围.ReadOnly = true;
            txt用途.ReadOnly = true;
            txt其他.ReadOnly = true;
        }
        /// <summary>
        /// 显示修改模式界面
        /// </summary>
        private void ShowModifyModeUI()
        {
            this.Text = "修改植物名片";           // 设置 标题栏文字：修改
            btn上传照片.Visible = true;           // 显示 上传植物照片按钮
            btn保存.Visible = true;               // 显示 保存按钮
            btn模式切换.Text = "浏览模式";        // 设置 模式切换按钮文本
            btn模式切换.Visible = true;           // 显示 模式切换按钮
            btn下一个.Visible = false;            // 隐藏 下一条按钮 
            btn上一个.Visible = false;            // 隐藏 上一条按钮 
            // 所有输入框可输入
            txt中文学名.ReadOnly = false;
            txt拉丁学名.ReadOnly = false;
            txt别称.ReadOnly = false;
            txt门.ReadOnly = false;
            txt纲.ReadOnly = false;
            txt目.ReadOnly = false;
            txt科.ReadOnly = false;
            txt属.ReadOnly = false;
            txt种.ReadOnly = false;
            txt形态特征.ReadOnly = false;
            txt生长环境.ReadOnly = false;
            txt分布范围.ReadOnly = false;
            txt用途.ReadOnly = false;
            txt其他.ReadOnly = false;
        }
        #endregion

        #region 数据库相关
        /// <summary>
        /// 查询并显示 当前植物名片信息
        /// </summary>
        private void ShowCurrentPlant()
        {
            try
            {
                string sqlStr = "SELECT 中文学名,拉丁学名,别称,"  // 拼接 查询字段名1
                + "编号,门,纲,目,科,属,种,"                       // 拼接 查询字段名2
                + "形态特征,生长环境,分布范围,用途,其他"          // 拼接 查询字段名3
                + " FROM 植物"                                     // 拼接 来源：植物表
                + " WHERE 编号=" + _plantId + ";";                 // 拼接 条件：ID符合
                _dt = _adapter.GetDataTable(sqlStr);              // 查询数据库：当前植物
                // 显示当前植物名片（除照片）
                txt中文学名.Text = (string)_dt.Rows[0]["中文学名"];
                txt拉丁学名.Text = (string)_dt.Rows[0]["拉丁学名"];
                txt别称.Text = (string)_dt.Rows[0]["别称"];
                txt门.Text = (string)_dt.Rows[0]["门"];
                txt纲.Text = (string)_dt.Rows[0]["纲"];
                txt目.Text = (string)_dt.Rows[0]["目"];
                txt科.Text = (string)_dt.Rows[0]["科"];
                txt属.Text = (string)_dt.Rows[0]["属"];
                txt种.Text = (string)_dt.Rows[0]["种"];
                txt形态特征.Text = (string)_dt.Rows[0]["形态特征"];
                txt生长环境.Text = (string)_dt.Rows[0]["生长环境"];
                txt分布范围.Text = (string)_dt.Rows[0]["分布范围"];
                txt用途.Text = (string)_dt.Rows[0]["用途"];
                txt其他.Text = (string)_dt.Rows[0]["其他"];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// 新增 植物名片信息
        /// </summary>
        private void AddPlantInfo()
        {
            try
            {
                string sqlStr = "INSERT INTO 植物("             // 拼接 插入表名：植物表
                + "中文学名,拉丁学名,别称,门,纲,目,科,属,种,"   // 拼接 插入字段名
                + "形态特征,生长环境,分布范围,用途,其他)"       // 拼接 插入字段名
                + "VALUES ("                                    // 拼接 数据开始标识
                + "\'" + txt中文学名.Text + "\', "              // 拼接 插入字段数据：中文学名
                + "\'" + txt拉丁学名.Text + "\', "              // 拼接 插入字段数据：拉丁学名
                + "\'" + txt别称.Text + "\', "                  // 拼接 插入字段数据：别称
                + "\'" + txt门.Text + "\', "                    // 拼接 插入字段数据：门
                + "\'" + txt纲.Text + "\', "                    // 拼接 插入字段数据：纲
                + "\'" + txt目.Text + "\', "                    // 拼接 插入字段数据：目
                + "\'" + txt科.Text + "\', "                    // 拼接 插入字段数据：科
                + "\'" + txt属.Text + "\', "                    // 拼接 插入字段数据：属
                + "\'" + txt种.Text + "\', "                    // 拼接 插入字段数据：种
                + "\'" + txt形态特征.Text + "\', "              // 拼接 插入字段数据：形态特征
                + "\'" + txt生长环境.Text + "\', "              // 拼接 插入字段数据：生长环境
                + "\'" + txt分布范围.Text + "\', "              // 拼接 插入字段数据：分布范围
                + "\'" + txt用途.Text + "\', "                  // 拼接 插入字段数据：用途
                + "\'" + txt其他.Text + "\');";                 // 拼接 插入字段数据：其他
                _adapter.SetDataLines(sqlStr);      // 执行 SQL语句
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 根据学名获取植物名片ID
        /// </summary>
        private void GetPlantId()
        {
            string sqlStr = "SELECT 编号 FROM 植物"
                + " WHERE 中文学名=\'" + txt中文学名.Text + "\'";
            DataTable dt = _adapter.GetDataTable(sqlStr);
            if (dt.Rows.Count > 0)
            { _plantId = (int)dt.Rows[0][0]; }
        }
        /// <summary>
        /// 更新 植物名片信息
        /// </summary>
        private void UpdatePlantInfo()
        {
            try
            {
                string sqlStr = "UPDATE 植物 SET"                   // 拼接 更新表名：植物表
                    + " 中文学名=\'" + txt中文学名.Text + "\',"     // 拼接 更新字段数据：中文学名
                    + " 拉丁学名=\'" + txt拉丁学名.Text + "\',"     // 拼接 更新字段数据：拉丁学名
                    + " 别称=\'" + txt别称.Text + "\',"             // 拼接 更新字段数据：别称
                    + " 门=\'" + txt门.Text + "\',"                 // 拼接 更新字段数据：门
                    + " 纲=\'" + txt纲.Text + "\',"                 // 拼接 更新字段数据：纲
                    + " 目=\'" + txt目.Text + "\',"                 // 拼接 更新字段数据：目
                    + " 科=\'" + txt科.Text + "\',"                 // 拼接 更新字段数据：科
                    + " 属=\'" + txt属.Text + "\',"                 // 拼接 更新字段数据：属
                    + " 种=\'" + txt种.Text + "\',"                 // 拼接 更新字段数据：种
                    + " 形态特征=\'" + txt形态特征.Text + "\',"     // 拼接 更新字段数据：形态特征
                    + " 生长环境=\'" + txt生长环境.Text + "\',"     // 拼接 更新字段数据：生长环境
                    + " 分布范围=\'" + txt分布范围.Text + "\',"     // 拼接 更新字段数据：分布范围
                    + " 用途=\'" + txt用途.Text + "\',"             // 拼接 更新字段数据：用途
                    + " 其他=\'" + txt其他.Text + "\'"              // 拼接 更新字段数据：其他
                    + " WHERE 编号=" + _plantId + ";";              // 拼接 更新条件：编号对应
                _adapter.SetDataLines(sqlStr);              // 执行 SQL语句
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 向数据库中更新 植物的外观图片
        /// </summary>
        private void UpdatePlantPicture()
        {
            try
            {
                MemoryStream ms1 = new MemoryStream();
                _plantPic.Save(ms1, ImageFormat.Jpeg);
                byte[] picData = new Byte[ms1.Length];
                ms1.Position = 0;
                ms1.Read(picData, 0, picData.Length);

                string sqlPara = "@pic";
                string sqlStr = "UPDATE 植物 SET 外观图片=" + sqlPara
                    + " WHERE 编号=" + _plantId + ";";
                _adapter.SetOleObject(sqlStr, sqlPara, picData);
                ms1.Close();
                ms1.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 从数据库中读取当前植物的外观图片
        /// </summary>
        private void ReadPlantPic()
        {
            try
            {
                string sqlStr = "SELECT 外观图片 FROM 植物"
                    + " WHERE 编号=" + _plantId + ";";
                DataTable dt = _adapter.GetDataTable(sqlStr);
                byte[] picData = (byte[])dt.Rows[0][0];
                MemoryStream ms1 = new MemoryStream(picData);
                _plantPic = Image.FromStream(ms1);
                ms1.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 判断植物是否在数据库中已存在
        /// </summary>
        /// <returns></returns>
        private bool IfPlantExist(string chnName, string latinName)
        {
            bool rslt = true;
            try
            {
                string sqlStr = "SELECT count(编号) FROM 植物";
                sqlStr += " WHERE 中文学名=\'" + chnName + "\'";
                sqlStr += " OR 拉丁学名=\'" + latinName + "\';";

                DataTable dt = _adapter.GetDataTable(sqlStr);
                if ((int)dt.Rows[0][0] > 0) { rslt = true; }
                else { rslt = false; }
                return rslt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);
                return rslt;
            }
        }
        #endregion
    }
}
