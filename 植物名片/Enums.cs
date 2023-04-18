using System;
using System.Collections.Generic;
using System.Text;

namespace 植物名片
{
    /// <summary>
    /// 窗体创建状态枚举
    /// </summary>
    public enum FormCrtState
    {
        /// <summary>
        /// 添加信息。此状态下可新建数据，并INSERT至数据库
        /// </summary>
        Add = 1,
        /// <summary>
        /// 浏览信息。此状态显示的数据为只读，不能写入数据库
        /// </summary>
        View = 2,
        /// <summary>
        /// 修改信息。此状态显示的数据为可修改状态，并能够UPDATE至数据库
        /// </summary>
        Mod = 3,
    };
}