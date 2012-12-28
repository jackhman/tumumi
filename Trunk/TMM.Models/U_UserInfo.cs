//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.Entity.cst at 2010-12-17 15:46:13
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace TMM.Model   {
	
    /// <summary><c>UUserInfo</c> Business Object.</summary>
    [Serializable]
    public partial class U_UserInfo {
        
        #region UserId

        private Int32 m_userId;
		
		/// <summary>Gets or sets UserId</summary>
        public Int32 UserId {
        	get { return m_userId; }
        	set { m_userId = value;}        
        }
		
	    #endregion
		
        #region NickName

        private String m_nickName;
		
		/// <summary>Gets or sets NickName</summary>
        public String NickName {
        	get { return m_nickName; }
        	set { m_nickName = value;}        
        }
		
	    #endregion
		
        #region Email

        private String m_email;
		
		/// <summary>Gets or sets Email</summary>
        public String Email {
        	get { return m_email; }
        	set { m_email = value;}        
        }
		
	    #endregion

        public string TmmDispName
        {
            get {
                if (!string.IsNullOrEmpty(m_nickName))
                    return m_nickName;
                else
                    return m_email;
            }
        }
		
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
		
        #region Sex

        private Boolean? m_sex;
		
		/// <summary>Gets or sets Sex</summary>
        public Boolean? Sex {
        	get { return m_sex; }
        	set { m_sex = value;}        
        }
		
	    #endregion
		
        #region Birthday

        private DateTime? m_birthday;
		
		/// <summary>Gets or sets Birthday</summary>
        public DateTime? Birthday {
        	get { return m_birthday; }
        	set { m_birthday = value;}        
        }
		
	    #endregion
		
        #region JobTitle

        private String m_jobTitle;
		
		/// <summary>Gets or sets JobTitle</summary>
        public String JobTitle {
        	get { return m_jobTitle; }
        	set { m_jobTitle = value;}        
        }
		
	    #endregion
		
        #region CompanyType

        private Int32? m_companyType;
		
		/// <summary>Gets or sets CompanyType</summary>
        public Int32? CompanyType {
        	get { return m_companyType; }
        	set { m_companyType = value;}        
        }
		
	    #endregion
		
        #region Major

        private Int32? m_major;
		
		/// <summary>Gets or sets Major</summary>
        public Int32? Major {
        	get { return m_major; }
        	set { m_major = value;}        
        }
		
	    #endregion
		
        #region RegTime

        private DateTime m_regTime;
		
		/// <summary>Gets or sets RegTime</summary>
        public DateTime RegTime {
        	get { return m_regTime; }
        	set { m_regTime = value;}        
        }
		
	    #endregion
		
        #region RegIp

        private String m_regIp;
		
		/// <summary>Gets or sets RegIp</summary>
        public String RegIp {
        	get { return m_regIp; }
        	set { m_regIp = value;}        
        }
		
	    #endregion
		
        #region HeadIcon

        private String m_headIcon;
		
		/// <summary>Gets or sets HeadIcon</summary>
        public String HeadIcon {
        	get {
                if (!string.IsNullOrEmpty(m_headIcon))
                    return m_headIcon;
                else
                    return "/contents/images/nohead.gif";
            }
        	set { m_headIcon = value;}        
        }
		
	    #endregion
		
        #region IsStop

        private Boolean m_isStop;
		
		/// <summary>Gets or sets IsStop</summary>
        public Boolean IsStop {
        	get { return m_isStop; }
        	set { m_isStop = value;}        
        }
		
	    #endregion
        /// <summary>
        /// 上传的文档总数
        /// </summary>
        public int UploadCount { get; set; }

        public bool IsMajia { get; set; }

        public int RegFrom { get; set; }
        public string OpenId { get; set; }
	}
	
}
