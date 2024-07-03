import win32api
#win32api.ShellExecute(0, 'open', r"F:\Remnant Afterglow Project\工具\基础配置\全局配置\配置特殊功能表.xlsx", '','',1)
win32api.ShellExecute(0, 'open', r"wps.exe", f"\"F:\Remnant Afterglow Project\工具\基础配置\全局配置\配置特殊功能表.xlsx\"",'cfg_ConfigCall_配置调用关系表',1)
# import win32com.client
# import time
# # 启动WPS应用程序
# wps_app = win32com.client.Dispatch("Excel.Application")
#
# # 打开[excel文件](https://geek.csdn.net/educolumn/058a2f001dec80db1ef2d7bf8bc67c6b?spm=1055.2569.3001.10083)
# workbook = wps_app.Workbooks.Open(r"F:\Remnant Afterglow Project\工具\基础配置\全局配置\配置特殊功能表.xlsx")
# # 显示WPS
#
# workbook.Sheets("cfg_ConfigCall_配置调用关系表").Activate()
#
# time.sleep(1)
# wps_app.Visible = True
# # 释放资源
# workbook.Close(False)
# wps_app.Quit()
