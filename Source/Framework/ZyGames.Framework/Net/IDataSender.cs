﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;
using System.Collections.Generic;
using ZyGames.Framework.Model;

namespace ZyGames.Framework.Net
{
    /// <summary>
    /// 数据处理句柄,跨服战时，可重新设置KEY主键规则
    /// </summary>
    public delegate object EntityPropertyGetFunc(ISqlEntity entity, SchemaColumn column);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="schema"></param>
    /// <param name="isChange"></param>
    /// <returns></returns>
    public delegate IList<string> EnttiyPostColumnFunc(ISqlEntity entity, SchemaTable schema, bool isChange);

    /// <summary>
    /// 数据传送操作接口
    /// </summary>
    public interface IDataSender : IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataList"></param>
        void Send<T>(IEnumerable<T> dataList) where T : AbstractEntity;

    }
}