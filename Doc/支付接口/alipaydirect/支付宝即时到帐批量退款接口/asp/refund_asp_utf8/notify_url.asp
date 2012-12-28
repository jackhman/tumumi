<%@LANGUAGE="VBSCRIPT" CODEPAGE="65001"%>
<%
	'功能：支付宝主动通知调用的页面（服务器异步通知页面）
	'版本：3.1
	'日期：2010-12-02
	'说明：
	'以下代码只是为了方便商户测试而提供的样例代码，商户可以根据自己网站的需要，按照技术文档编写,并非一定要使用该代码。
	'该代码仅供学习和研究支付宝接口使用，只是提供一个参考。
	
''''''''''''页面功能说明'''''''''''''''''''
'创建该页面文件时，请留心该页面文件中无任何HTML代码及空格。
'该页面不能在本机电脑测试，请到服务器上做测试。请确保外部可以访问该页面。
'该页面调试工具请使用写文本函数log_result，该函数已被默认开启，见alipay_notify.asp中的函数notify_verify
'该通知页面主要功能是：根据支付宝的处理结果，来做商家的业务逻辑处理。
'如果没有收到该页面返回的 success 信息，支付宝会在24小时内按一定的时间策略重发通知
'''''''''''''''''''''''''''''''''''''''''''
%>

<!--#include file="alipay_config.asp"-->
<!--#include file="class/alipay_notify.asp"-->

<%
'计算得出通知验证结果
verify_result = notify_verify()

if verify_result then	'验证成功
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	'请在这里加上商户的业务逻辑程序代码
	
	'——请根据您的业务逻辑来编写程序（以下代码仅作参考）——
    '获取支付宝的通知返回参数，可参考技术文档中服务器异步通知参数列表
	'获取批次号
    batch_no		= request.Form("batch_no")

	'获取批量退款数据中转账成功的笔数
	success_num		= request.Form("success_num")
	
	'获取批量退款数据中的详细信息
	result_details	= request.Form("result_details")
	'格式：第一笔交易#第二笔交易#第三笔交易
	'第N笔交易格式：交易退款信息
	'交易退款信息格式：原付款支付宝交易号^退款总金额^处理结果码^结果描述
	'——请根据您的业务逻辑来编写程序（以上代码仅作参考）——
	
	'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
	
	response.Write "success"	'向支付宝反馈的成功标志，请不要修改或删除
else '验证失败
    response.Write "fail"
	'调试用，写文本函数记录程序运行情况是否正常
	'log_result ("这里写入想要调试的代码变量值，或其他运行的结果记录")
end if
%>