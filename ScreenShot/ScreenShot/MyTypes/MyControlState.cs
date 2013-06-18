﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScreenShot
{

    /****************************************************************
    * 
    *             Dcrp：自定义控件的状态枚举
    *           Author：曹江波
    *             Blog: http://www.cnblogs.com/Keep-Silence-/
    *           Update: 2013-5-31
    *
    *****************************************************************/

    public enum MyControlState
    {
        /// <summary>
        /// 正常状态
        /// </summary>
        Normal = 0,
        /// <summary>
        ///  /鼠标进入
        /// </summary>
        Highlight = 1,
        /// <summary>
        /// 鼠标按下
        /// </summary>
        Down = 2
    }
}