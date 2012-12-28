<!--#include file="../util/md5.asp"-->
<!--#include file="../util/tenpay_util.asp"-->
<%
'
'即时到帐支付请求类
'============================================================================
'api说明：
'init(),初始化函数，默认给一些参数赋值，如cmdno,date等。
'getGateURL()/setGateURL(),获取/设置入口地址,不包含参数值
'getKey()/setKey(),获取/设置密钥
'getParameter()/setParameter(),获取/设置参数值
'getAllParameters(),获取所有参数
'getRequestURL(),获取带参数的请求URL
'doSend(),重定向到财付通支付
'getDebugInfo(),获取debug信息
'
'============================================================================
'

Class PayRequestHandler
	
	'网关url地址
	Private gateUrl
	
	'密钥
	Private key
	
	'请求的参数
	Private parameters
	
	'debug信息
	Private debugInfo
	
	'初始构造函数
	Private Sub class_initialize()
		gateUrl = "http://service.tenpay.com/cgi-bin/v3.0/payservice.cgi"
		key = ""
		Set parameters = Server.CreateObject("Scripting.Dictionary")
		debugInfo = ""
	End Sub
	
	'初始化函数，默认给一些参数赋值，如cmdno,date等。
	Public Function init()
		parameters.RemoveAll

		'任务代码
		parameters.Add "cmdno", "1"

		'日期
		parameters.Add "date", getServerDate()

		'商户号
		parameters.Add "bargainor_id", ""

		'财付通交易单号
		parameters.Add "transaction_id", ""

		'商家订单号
		parameters.Add "sp_billno", ""

		'商品价格，以分为单位
		parameters.Add "total_fee", ""

		'货币类型
		parameters.Add "fee_type", "1"

		'返回url
		parameters.Add "return_url", ""

		'自定义参数
		parameters.Add "attach", ""

		'用户ip
		parameters.Add "spbill_create_ip", ""

		'商品名称
		parameters.Add "desc", ""

		'银行编码
		parameters.Add "bank_type", "0"

		'字符集编码
		parameters.Add "cs", "gbk"

		'摘要
		parameters.Add "sign", ""

	End Function
	
	'获取入口地址,不包含参数值
	Public Function getGateURL()
		getGateURL = gateUrl
	End Function
	
	'设置入口地址,不包含参数值
	Public Function setGateURL(gateUrl_)
		gateUrl = gateUrl_
	End Function
	
	'获取密钥
	Public Function getKey()
		getKey = key
	End Function
	
	'设置密钥
	Public Function setKey(key_)
		key = key_
	End Function
	
	'获取参数值
	Public Function getParameter(parameter)
		getParameter = parameters.Item(parameter)
	End Function
	
	'设置参数值
	Public Sub setParameter(parameter, parameterValue)
		If parameters.Exists(parameter) = True Then
			parameters.Remove(parameter)
		End If
		parameters.Add parameter, parameterValue	
	End Sub

	'获取所有请求的参数,返回Scripting.Dictionary
	Public Function getAllParameters()
		getAllParameters = parameters
	End Function
	
	'获取带参数的请求URL
	Public Function getRequestURL()

		Call createSign()
		
		Dim reqPars
		Dim k
		For Each k In parameters
			reqPars = reqPars & k & "=" & Server.URLEncode(parameters(k)) & "&" 
		Next
		
		'去掉最后一个&
		reqPars = Left(reqPars, Len(reqPars)-1)

		getRequestURL = getGateURL & "?" & reqPars

	End Function
	
	'重定向到财付通支付
	Public Function doSend()
		Response.Redirect(getRequestURL())
		Response.End
	End Function	
	
	'获取debug信息
	Public Function getDebugInfo()
		getDebugInfo = debugInfo
	End Function
	
	'创建签名
	Private Sub createSign()
		Dim cmdno
		Dim date
		Dim bargainor_id
		Dim transaction_id
		Dim sp_billno

		Dim total_fee
		Dim fee_type
		Dim return_url
		Dim attach
		Dim spbill_create_ip

		cmdno = getParameter("cmdno")
		date = getParameter("date")
		bargainor_id = getParameter("bargainor_id")
		transaction_id = getParameter("transaction_id")
		sp_billno = getParameter("sp_billno")

		total_fee = getParameter("total_fee")
		fee_type = getParameter("fee_type")
		return_url = getParameter("return_url")
		attach = getParameter("attach")
		spbill_create_ip = getParameter("spbill_create_ip")

		Dim signPars
		signPars = "cmdno=" & cmdno & "&" &_
				"date=" & date & "&" &_
				"bargainor_id=" & bargainor_id & "&" &_
				"transaction_id=" & transaction_id & "&" &_
				"sp_billno=" & sp_billno & "&" &_
				"total_fee=" & total_fee & "&" &_
				"fee_type=" & fee_type & "&" &_
				"return_url=" & return_url & "&" &_
				"attach=" & attach & "&"

		If spbill_create_ip <> "" Then
			signPars = signPars & "spbill_create_ip=" & spbill_create_ip & "&"
		End If

		signPars = signPars & "key=" & key

		Dim sign
		sign= LCase(ASP_MD5(signPars))

		setParameter "sign", sign

		'debuginfo
		debugInfo = signPars & " => sign:" & sign
		
	End Sub

End Class

%>