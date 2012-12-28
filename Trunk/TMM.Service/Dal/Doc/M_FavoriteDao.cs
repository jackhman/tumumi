﻿//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.DaoImpl.cst at 2011-1-10 9:29:13
//				By xincai.wu
//==============================================================================
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMM.Model;
using TMM.Persistence;


namespace TMM.Service.Dal.Doc {

	/// <summary>
    /// 名称：MFavoriteDao 数据层
    /// 开发者：
    /// 创建时间：2011-1-9 11:03:46
    /// 功能描述：
    /// </summary>
    public partial class MFavoriteDal {

		/// <summary>
        /// 取得记录数
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <returns></returns>
		public int GetCount(Hashtable param) {
			if (param == null)
                param = new Hashtable();
				
			String stmtId = "MFavorite.GetCount";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, param);
		}

		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <param name="orderBy">排序方式:默认为“FavId asc”</param>
        /// <param name="first">起始记录：从0开始</param>
        /// <param name="rows">提取的条数</param>
        /// <returns></returns>
		public IList<MFavorite> GetList(Hashtable param,string orderBy,int first,int rows) 
		{
			if (param == null)
                param = new Hashtable();

            param.Add("Top", first+ rows);
            param.Add("StartRecord", first);

            if (string.IsNullOrEmpty(orderBy))
                param.Add("OrderBy", "FavId asc");
			else
                param.Add("OrderBy", orderBy);
				
			String stmtId = "MFavorite.GetList";
			return SqlMapper.Instance().QueryForList<MFavorite>(stmtId, param);
		}
		
		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="favId"></param>
        /// <returns></returns>
		public MFavorite Get(Int32 favId) {
			String stmtId = "MFavorite.Get";
			return SqlMapper.Instance().QueryForObject<MFavorite>(stmtId, favId);
		}

		/// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>返回：该条数据的主键Id</returns>
		public int Insert(MFavorite obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "MFavorite.Insert";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
		}
		
		/// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Update(MFavorite obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "MFavorite.Update";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
			return result > 0 ? true : false;
		}
		
		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="favId"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Delete(Int32 favId) {
			String stmtId = "MFavorite.Delete";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, favId);
			return result > 0 ? true : false;
		}

        public void MoveFolder(int favId, int favCateId) {
            String stmtId = "MFavorite.MoveFolder";
            Hashtable p = new Hashtable();
            p.Add("FavId",favId);
            p.Add("FavCateId",favCateId);
            SqlMapper.Instance().Update(stmtId, p);
        }
	}

}
