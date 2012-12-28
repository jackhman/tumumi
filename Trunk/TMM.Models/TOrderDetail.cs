//==============================================================================
//	CAUTION: This file is generated by IBatisNetGen.Entity.cst at 2010-12-17 22:06:28
//				Any manual editing will be lost in re-generation.
//==============================================================================
using System;
using System.Collections.Generic;
using System.Text;

namespace TMM.Model
{
	
    /// <summary><c>TOrderDetail</c> Business Object.</summary>
    [Serializable]
    public partial class TOrderDetail {
        
        #region OrderDetailId

        private Int32 m_orderDetailId;
		
		/// <summary>Gets or sets OrderDetailId</summary>
        public Int32 OrderDetailId {
        	get { return m_orderDetailId; }
        	set { m_orderDetailId = value;}        
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
		
        #region DocId

        private Int32 m_docId;
		
		/// <summary>Gets or sets DocId</summary>
        public Int32 DocId {
        	get { return m_docId; }
        	set { m_docId = value;}        
        }
		
	    #endregion
		
        #region DocTitle

        private String m_docTitle;
		
		/// <summary>Gets or sets DocTitle</summary>
        public String DocTitle {
        	get { return m_docTitle; }
        	set { m_docTitle = value;}        
        }
		
	    #endregion
		
        #region Price

        private Decimal m_price;
		
		/// <summary>Gets or sets Price</summary>
        public Decimal Price {
        	get { return m_price; }
        	set { m_price = value;}        
        }
		
	    #endregion
		
        #region GoodsCount

        private Int32 m_goodsCount;
		
		/// <summary>Gets or sets GoodsCount</summary>
        public Int32 GoodsCount {
        	get { return m_goodsCount; }
        	set { m_goodsCount = value;}        
        }
		
	    #endregion
		

	}
	
}
