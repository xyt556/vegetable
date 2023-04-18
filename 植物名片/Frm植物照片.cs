using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 植物名片
{
    public partial class Frm植物照片 : Form
    {
        public Frm植物照片()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 按指定的位置显示窗体
        /// </summary>
        /// <param name="left"></param>
        /// <param name="top"></param>
        public void ShowWithLocation(int left, int top)
        {
            this.Show();
            this.Activate();
            this.Left = left;
            this.Top = top;
        }
        /// <summary>
        /// 设定需显示的图片
        /// </summary>
        /// <param name="pic"></param>
        public void SetFormPic(Image pic)
        {
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = pic;
        }

        private void Frm植物照片_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm植物照片_Load(object sender, EventArgs e)
        {

        }
    }
}
