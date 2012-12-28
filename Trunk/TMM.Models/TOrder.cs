//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.Entity.cst at 2010-12-17 22:06:28
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace TMM.Model
{
	
    /// <summary><c>TOrder</c> Business Object.</summary>
    [Serializable]
    public partial class TOrder {
        
        #region OrderId

        private Decimal m_orderId;
		
		/// <summary>Gets or sets OrderId</summary>
        public Decimal OrderId {
        	get { return m_orderId; }
        	set { m_orderId = value;}        
        }
		
	    #endregion
		
        #region OrderType

        private Int32 m_orderType;
		
		/// <summary>详见OrderType枚举</summary>
        public Int32 OrderType {
        	get { return m_orderType; }
        	set { m_orderType = value;}        
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
		
        #region Email

        private String m_email;
		
		/// <summary>Gets or sets Email</summary>
        public String Email {
        	get { return m_email; }
        	set { m_email = value;}        
        }
		
	    #endregion
		
        #region Total

        private Decimal m_total;
		
		/// <summary>Gets or sets Total</summary>
        public Decimal Total {
        	get { return m_total; }
        	set { m_total = value;}        
        }
		
	    #endregion
		
        #region PayWay

        private Int32 m_payWay;

        /// <summary>
        /// 支付方式：0账号支付，1支付宝是，2财付通是，3网银在线是，10手工支付,20货到付款
        /// </summary>
        public Int32 PayWay {
        	get { return m_payWay; }
        	set { m_payWay = value;}        
        }
		
	    #endregion
		
        #region Ip

        private String m_ip;
		
		/// <summary>Gets or sets Ip</summary>
        public String Ip {
        	get { return m_ip; }
        	set { m_ip = value;}        
        }
		
	    #endregion
		
        #region Status

        private Int32 m_status;
		
		/// <summary>
        /// -20=交易失败
        /// -10=已取消
        /// 0=新订单
        /// 3=支付失败，支付接口返回错误
        /// 10=已付款
        /// 20=已完成
        /// </summary>
        public Int32 Status {
        	get { return m_status; }
        	set { m_status = value;}        
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
		
        #region PayTime

        private DateTime? m_payTime;
		
		/// <summary>Gets or sets PayTime</summary>
        public DateTime? PayTime {
        	get { return m_payTime; }
        	set { m_payTime = value;}        
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
		
        #region AdminRemark

        private String m_adminRemark;
		
		/// <summary>Gets or sets AdminRemark</summary>
        public String AdminRemark {
        	get { return m_adminRemark; }
        	set { m_adminRemark = value;}        
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

        /// <summary>
        /// 订单明细
        /// </summary>
        public List<TOrderDetail> OrderDetails { get; set; }
        /// <summary>
        /// 兑换账户ID
        /// </summary>
        public int? ExchangeAccId { get; set; }
        /// <summary>
        /// 订单用户
        /// </summary>
        public U_UserInfo User { get; set; }
        /// <summary>
        /// 用户账户
        /// </summary>
        public MAccount Account { get; set; }

        public TOrderDetail SingleDetail {
            get {
                if (OrderDetails.Count > 0)
                    return OrderDetails[0];
                else
                    return null;
            }
        }
	}

    public enum OrderStatus
    {
        Failure = -20,
        Cancel = -10,
        NewOrder = 0,
        /// <summary>
        /// 支付失败，支付接口返回错误
        /// </summary>
        PayError = 3,
        IsPaied = 10,
        /// <summary>
        /// 已冻结部分账户余额（用户兑换）
        /// </summary>
        FrozenSomeAmount = 13,
        /// <summary>
        /// 确认提交的兑换申请
        /// </summary>
        ConfirmExchange = 15,
        /// <summary>
        /// 管理员已经线下处理兑换
        /// </summary>
        AdminDoExchange = 16,
        /// <summary>
        /// 用户确认兑换成功
        /// </summary>
        UserConfirmExchange = 17,
        Finish = 20
    }

    public enum OrderType
    {
        /// <summary>
        /// 下载文档产生的订单
        /// </summary>
        DownDocOrder = 1,
        /// <summary>
        /// 直接充值
        /// </summary>
        DirectCharge,
        /// <summary>
        /// 兑换产生的订单
        /// </summary>
        Exchange
    }
}
