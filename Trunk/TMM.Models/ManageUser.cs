//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.Entity.cst at 2010-12-17 15:46:13
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace TMM.Model
{
	
    /// <summary><c>ManageUser</c> Business Object.</summary>
    [Serializable]
    public partial class ManageUser {
        
        #region UserName

        private String m_userName;
		
		/// <summary>Gets or sets UserName</summary>
        public String UserName {
        	get { return m_userName; }
        	set { m_userName = value;}        
        }
		
	    #endregion
		
        #region Password

        private String m_password;
		
		/// <summary>Gets or sets Password</summary>
        public String Password {
        	get { return m_password; }
        	set { m_password = value;}        
        }
		
	    #endregion
		
        #region TrueName

        private String m_trueName;
		
		/// <summary>Gets or sets TrueName</summary>
        public String TrueName {
        	get { return m_trueName; }
        	set { m_trueName = value;}        
        }
		
	    #endregion
		
        #region Mobile

        private String m_mobile;
		
		/// <summary>Gets or sets Mobile</summary>
        public String Mobile {
        	get { return m_mobile; }
        	set { m_mobile = value;}        
        }
		
	    #endregion
		
        #region Level

        private Int32? m_level;
		
		/// <summary>Gets or sets Level</summary>
        public Int32? Level {
        	get { return m_level; }
        	set { m_level = value;}        
        }
		
	    #endregion
		
        #region CreateTime

        private DateTime? m_createTime;
		
		/// <summary>Gets or sets CreateTime</summary>
        public DateTime? CreateTime {
        	get { return m_createTime; }
        	set { m_createTime = value;}        
        }
		
	    #endregion
		
        #region UpdateTime

        private DateTime? m_updateTime;
		
		/// <summary>Gets or sets UpdateTime</summary>
        public DateTime? UpdateTime {
        	get { return m_updateTime; }
        	set { m_updateTime = value;}        
        }
		
	    #endregion
		
        #region Remark

        private String m_remark;
		
		/// <summary>Gets or sets Remark</summary>
        public String Remark {
        	get { return m_remark; }
        	set { m_remark = value;}        
        }
		
	    #endregion
		

	}
	
}
