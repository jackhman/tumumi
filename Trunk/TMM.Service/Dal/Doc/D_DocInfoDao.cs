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
    /// 名称：DDocInfoDao 数据层
    /// 开发者：
    /// 创建时间：2011-1-9 11:03:46
    /// 功能描述：
    /// </summary>
    public partial class DDocInfoDal {

		/// <summary>
        /// 取得记录数
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <returns></returns>
		public int GetCount(Hashtable param) {
			if (param == null)
                param = new Hashtable();
				
			String stmtId = "DDocInfo.GetCount";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, param);
		}

		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="param">可选参数为：</param>
        /// <param name="orderBy">排序方式:默认为“DocId asc”</param>
        /// <param name="first">起始记录：从0开始</param>
        /// <param name="rows">提取的条数</param>
        /// <returns></returns>
		public IList<DDocInfo> GetList(Hashtable param,string orderBy,int first,int rows) 
		{
			if (param == null)
                param = new Hashtable();

            param.Add("Top", first+ rows);
            param.Add("StartRecord", first);

            if (string.IsNullOrEmpty(orderBy))
                param.Add("OrderBy", "DocId Desc");
			else
                param.Add("OrderBy", orderBy);
				
			String stmtId = "DDocInfo.GetList";
			return SqlMapper.Instance().QueryForList<DDocInfo>(stmtId, param);
		}
		
		/// <summary>
        /// 提取数据
        /// </summary>
        /// <param name="docId"></param>
        /// <returns></returns>
		public DDocInfo Get(Int32 docId) {
			String stmtId = "DDocInfo.Get";
			return SqlMapper.Instance().QueryForObject<DDocInfo>(stmtId, docId);
		}

        public DDocInfo GetByFileId(Guid g) {
            String stmtId = "DDocInfo.GetByFileId";
            Hashtable p = new Hashtable();
            p.Add("FileId",g);
            return SqlMapper.Instance().QueryForObject<DDocInfo>(stmtId,p);
        }

		/// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="obj">对象</param>
        /// <returns>返回：该条数据的主键Id</returns>
		public int Insert(DDocInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "DDocInfo.Insert";
			return SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
		}
		
		/// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Update(DDocInfo obj) {
			if (obj == null) throw new ArgumentNullException("obj");
			String stmtId = "DDocInfo.Update";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, obj);
			return result > 0 ? true : false;
		}
		
		/// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="docId"></param>
        /// <returns>返回：ture 成功，false 失败</returns>
		public bool Delete(Int32 docId) {
			String stmtId = "DDocInfo.Delete";
			int result = SqlMapper.Instance().QueryForObject<int>(stmtId, docId);
			return result > 0 ? true : false;
		}
        public int? GetViewCount(int userId) {
            String stmtId = "DDocInfo.GetViewCount";
            return SqlMapper.Instance().QueryForObject<int?>(stmtId, userId);
        }

        public void UpdateUserCatalog(int userId, int userCateId) {
            String stmtId = "DDocInfo.UpdateUserCatalog";
            Hashtable p = new Hashtable();
            p.Add("UserId",userId);
            p.Add("UserCateId",userCateId);
            SqlMapper.Instance().Update(stmtId, p);
        }

        public void MoveFolder(int docId,int folderId) {
            Hashtable p = new Hashtable();
            p.Add("DocId",docId);
            p.Add("UserCateId",folderId);
            String stmtId = "DDocInfo.MoveFolder";
            SqlMapper.Instance().Update(stmtId, p);
        }
        public void UpdateViewCount(int docId) {
            string stmtId = "DDocInfo.UpdateViewCount";
            SqlMapper.Instance().Update(stmtId, docId);
        }
        public void UpdateCommentCount(int docId)
        {
            string stmtId = "DDocInfo.UpdateCommentCount";
            SqlMapper.Instance().Update(stmtId, docId);
        }
        public void UpdateUpCount(int docId)
        {
            string stmtId = "DDocInfo.UpdateUpCount";
            SqlMapper.Instance().Update(stmtId, docId);
        }
        public void UpdateFavCount(int docId)
        {
            string stmtId = "DDocInfo.UpdateFavCount";
            SqlMapper.Instance().Update(stmtId, docId);
        }

        public IList<int> GetRelativeDocIds(int docId) {
            string stmtId = "DDocInfo.GetRelativeDocIds";
            return SqlMapper.Instance().QueryForList<int>(stmtId, docId);
        }

        public void UpdateConvertFlag(int docId)
        {
            string stmtId = "DDocInfo.UpdateConvertFlag";
            SqlMapper.Instance().QueryForList<int>(stmtId, docId);
        }
	}

}
