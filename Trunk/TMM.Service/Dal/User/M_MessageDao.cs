﻿//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.DaoImpl.cst at 2010-12-17 15:46:12
//				By xincai.wu
//==============================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMM.Model;
using TMM.Persistence;


namespace TMM.Service.Dal.User
{

	/// <summary>
    /// 名称：MMessageDao 数据层
    /// 开发者：
    /// 创建时间：2010-11-29 19:03:15
    /// 功能描述：
    /// </summary>
    public partial class M_MessageDal {

		/// <summary>
        /// 取得记录数
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <returns></returns>
		public int GetCount(Hashtable param) {
			if (param == null)
                param = new Hashtable();
				
			String stmtId = "M_Message.GetCount";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, param);
		}

		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <param name="orderBy">排序方式:默认为“Mid asc”</param>
        /// <param name="first">起始记录：从0开始</param>
        /// <param name="rows">提取的条数</param>
        /// <returns></returns>
		public IList<M_Message> GetList(Hashtable param,string orderBy,int first,int rows) 
		{
			if (param == null)
                param = new Hashtable();

            param.Add("Top", first+ rows);
            param.Add("StartRecord", first);

            if (string.IsNullOrEmpty(orderBy))
                param.Add("OrderBy", "Mid asc");
			else
                param.Add("OrderBy", orderBy);
				
			String stmtId = "M_Message.GetList";
			return SqlMapper.Instance().QueryForList<M_Message>(stmtId, param);
		}
		
		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
		public M_Message Get(Int64 mid) {
			String stmtId = "M_Message.Get";
			return SqlMapper.Instance().QueryForObject<M_Message>(stmtId, mid);
		}

		/// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>返回：该条数据的主键Id</returns>
		public int Insert(M_Message obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "M_Message.Insert";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
		}
		
		/// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Update(M_Message obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "M_Message.Update";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
			return result > 0 ? true : false;
		}
		
		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="mid"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Delete(Int64 mid) {
			String stmtId = "M_Message.Delete";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, mid);
			return result > 0 ? true : false;
		}
        /// <summary>
        /// 接收人打删除标记
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public bool SetDeleteFlagByReciever(Int64 mid)
        {
            String stmtId = "M_Message.SetDeleteFlagByReciever";
            int result = SqlMapper.Instance().Update(stmtId, mid);
            return result > 0 ? true : false;
        }
        /// <summary>
        /// 设置为已读
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public bool SetRead(Int64 mid)
        {
            String stmtId = "M_Message.SetRead";
            int result = SqlMapper.Instance().Update(stmtId, mid);
            return result > 0 ? true : false;
        }

        public bool SetDeleteFlagBySender(Int64 mid)
        {
            String stmtId = "M_Message.SetDeleteFlagBySender";
            int result = SqlMapper.Instance().Update(stmtId, mid);
            return result > 0 ? true : false;
        }
	}

}
