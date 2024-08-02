使用这个配置工具，可以通过使用wps的xlsx表格，
很方便的配置游戏数据，在一定格式下，使用这个工具可以很方便的导出为json文件，和参考用的配置类！
可以导出30多种数据类型，其中还包括了图片（单元格图片）滴！
并且新增字段理论上不会影响到游戏，除非你加的是主键
通过看 工具帮助文档 应该能让你大致了解这个工具
（2.0版本的配置工具代码更新了，但是工具帮助文档还没更新,但是配置的方式基本没变
（现在最后一行第一个格子不需要一定是2了））

运行方式：
双击 配置导出工具2\导出基础配置2.0.bat 运行完成，会弹出黑窗口，可删除


配置这个工具的方式：
1.得下载安装python
2.安装python的包
pip install numpy
pip install pandas
pip install openpyxl
pip install pywin32

注意事项：
1.配置是可以瘦身滴! 
只需要修改DataHandle.py这个文件中的isCompact变量，改成True就是瘦身，大概能降低50%左右的体积。


之后还想优化的功能：
1.让拓展类型变得更简单些
2.xlsx图片导出据说可能存在id重复的问题，这个得康康（问的AI，它说xlsx在某些特殊操作后可以出现图片id重复情况）

其他事项：
1.基础配置文件夹中有大量文档，可以康康大致是咋配的。
2.ConfigLoadSystem.cs是一个在godot的c#项目中使用的，估计是没法直接使用，你得小改下，建议配成自动加载项，
并且可以将配置加载改成异步带进度条（目前游戏还在开发中，用异步麻烦）
（你也可以改成Unity的，看你），用于读取json数据的类（你也可以改成Unity的，看你），用于读取json数据的类
使用了Newtonsoft.Json，所以你的项目还得下载它。

基本流程：
读取首先读取的是基础配置工具目录下的file_name.json文件，
file_name的json中每个表都有三个字段file_name,file_path,key_list
其中file_path应该是在你的项目中使用的路径，因此这个路径需要你修改！
修改基础配置工具路径下的path.txt文件即可

当前导出类型等介绍：
导出类型目前有30来种，都是可以拓展的，当然,需要你有一点点python知识和c#知识。
仿照TypeConversion.py这个文件中的BaseType字典，加上自己想要加上的类型，
写上转换的函数即可，记得这边拓展了，读取的地方(ConfigLoadSystem.cs)也得拓展哈！
另外，想方便的通过xlsx的下拉框来选择新拓展的类型，也得在 xlsx表格\数据类型.accdb 中新增你拓展的类型，
双击这个文件就行，然后你可以看到有个数据类型的表，再次双击它就可以添加了哈！！

目前可以导出的类型有30来种：
BOOL、SHORT、INT、LONG、FLOAT、STR
<BOOL>、<SHORT>、<INT>、<LONG>
<FLOAT>、<STR>、(BOOL)、(SHORT)
(INT)、(LONG)、(FLOAT)、(STR)、<(BOOL)>
<(SHORT)>、<(INT)>、<(LONG)>、<(FLOAT)> 
<(STR)>、LANG、POINT、<LANG>、<POINT>
PNG、Vector2I、ULONG

特殊类型：
POINT   一个坐标(小数坐标)  转换为godot中的Vector2
LANG   语言id   看你如何使用，可以作为语言配置的id，这个我这边就不给使用方式了（我自己还有个语言导出工具，还不太通用）
PNG   新增的导出数据类型（在数据中表现是一个单元格图片(不懂就搜索下吧！)），必须是wps的xlsx文件中的单元格图片（浮动图片读取简单但是没法和格子匹配）
图片导出时，会将wps的xlsx文件中的单元格图片导出，放置在 配置导出工具2\config\images文件夹下
Vector2I 一个坐标(整数坐标)  转换为godot中的Vector2I