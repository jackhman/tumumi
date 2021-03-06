//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.Entity.cst at 2010-12-17 22:06:28
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace TMM.Model  {
	
    /// <summary><c>MPayLog</c> Business Object.</summary>
    [Serializable]
    public partial class MPayLog {
        
        #region PayId

        private Int32 m_payId;
		
		/// <summary>Gets or sets PayId</summary>
        public Int32 PayId {
        	get { return m_payId; }
        	set { m_payId = value;}        
        }
		
	    #endregion
		
        #region OrderId

        private Decimal m_orderId;
		
		/// <summary>Gets or sets OrderId</summary>
        public Decimal OrderId {
        	get { return m_orderId; }
        	set { m_orderId = value;}        
        }
		
	    #endregion
		
        #region TransactionId

        private String m_transactionId;
		
		/// <summary>Gets or sets TransactionId</summary>
        public String TransactionId {
        	get { return m_transactionId; }
        	set { m_transactionId = value;}        
        }
		
	    #endregion
		
        #region UserId

        private Int32 m_userId;
		
		/// <summary>Gets or sets UserId</summary>
        public Int32 UserId {
        	get { return m_userId; }
        	set { m_userId = value;}        
        }
		
	    #endregion
		
        #region PayWay

        private Int32 m_payWay;
		
		/// <summary>Gets or sets PayWay</summary>
        public Int32 PayWay {
        	get { return m_payWay; }
        	set { m_payWay = value;}        
        }
		
	    #endregion
		
        #region PayMoney

        private Decimal m_payMoney;
		
		/// <summary>Gets or sets PayMoney</summary>
        public Decimal PayMoney {
        	get { return m_payMoney; }
        	set { m_payMoney = value;}        
        }
		
	    #endregion
		
        #region PayUrl

        private String m_payUrl;
		
		/// <summary>Gets or sets PayUrl</summary>
        public String PayUrl {
        	get { return m_payUrl; }
        	set { m_payUrl = value;}        
        }
		
	    #endregion
		
        #region BackUrl

        private String m_backUrl;
		
		/// <summary>Gets or sets BackUrl</summary>
        public String BackUrl {
        	get { return m_backUrl; }
        	set { m_backUrl = value;}        
        }
		
	    #endregion
		
        #region PayResult

        private String m_payResult;
		
		/// <summary>Gets or sets PayResult</summary>
        public String PayResult {
        	get { return m_payResult; }
        	set { m_payResult = value;}        
        }
		
	    #endregion
		
        #region CreateTime

        private DateTime m_createTime;
		
		/// <summary>Gets or sets CreateTime</summary>
        public DateTime CreateTime {
        	get { return m_createTime; }
        	set { m_createTime = value;}        
        }
		
	    #endregion
		

	}
	
}
