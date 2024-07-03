import tkinter as tk
from tkinter import ttk
import Config
import read_xlsx  ##文件读取
import DataHandle  ##数据读取操作
import open_view  ##打开excel表
import sys, os
import platform

class FileBrowserApp:
    def __init__(self, root):
        ##self.image_path_list = []  ##需要导出图片数据的列表

        self.select_path = ""  ##当前选中的文件或者文件夹路径
        self.error_table_path = ""  ##当前报错表路径

        self.root = root
        self.root.title("配置导出工具")
        self.root.geometry("700x450")  # 设置窗口大小
        self.root.resizable(False, False)
        self.create_menu()
        self.create_frames()
        self.bind_events()

    def create_menu(self):
        # 创建菜单栏
        menu_bar = tk.Menu(self.root)
        file_menu = tk.Menu(menu_bar, tearoff=0)
        file_menu.add_command(label="打开")
        file_menu.add_command(label="保存")
        menu_bar.add_cascade(label="文件", menu=file_menu)
        self.root.config(menu=menu_bar)

    def create_frames(self):
        # 创建左右两个Frame
        self.left_frame = tk.Frame(self.root, width=300, height=600, bg='lightgrey')
        self.left_frame.pack(side='left', fill='both', expand=True)

        self.right_frame = tk.Frame(self.root, width=300, height=400, bg='lightblue')
        self.right_frame.pack(side='top', fill='both', expand=True)

        self.right_frame2 = tk.Frame(self.root, width=300, height=400, bg='lightblue')
        self.right_frame2.pack(side='bottom', fill='both', expand=True)

        self.create_treeview()
        self.create_labels_and_buttons()
        self.create_listbox()

    def bind_events(self):
        # 绑定事件
        self.tree.bind("<Button-3>", self.on_right_click)
        self.tree.bind("<Button-1>", self.on_left_click)

    def create_treeview(self):
        # 创建TreeView用于显示文件夹结构
        self.tree = ttk.Treeview(self.left_frame, show="tree", displaycolumns="#all", selectmode="browse")
        self.tree.pack(padx=10, pady=10, fill='both', expand=True)
        stu_root = self.tree.insert("", 'end', text="基础配置")
        self.insert_node(ConfigData["工具读取的xlsx文件夹路径"], stu_root)

    def insert_node(self, path, parent):
        # 递归插入节点到TreeView中
        for item in os.listdir(path):
            item_path = os.path.join(path, item)
            if os.path.isdir(item_path):
                folder_node = self.tree.insert(parent, 'end', text=item)
                self.insert_node(item_path, folder_node)
            elif item.endswith('.xlsx') and not item.startswith('~$'):
                self.tree.insert(parent, 'end', text=item)

    def create_labels_and_buttons(self):
        # 创建标签用于显示文件名
        self.file_label = tk.Label(self.right_frame, text="", font=('Arial', 12))
        self.file_label.pack(pady=5)

        # 创建标签用于显示文件名
        self.err_label = tk.Label(self.right_frame2, text="", wraplength=400)
        self.err_label.pack(pady=5)

        # 创建一个 Frame 用于包裹按钮，然后将按钮放置在该 Frame 中
        button_frame = tk.Frame(self.right_frame)
        button_frame.pack(pady=5)

        # 创建按钮用于操作，并指定它们所在的 Frame 为 button_frame
        self.export_all_btn = tk.Button(button_frame, text="导出配置", command=self.export_all)
        self.export_all_btn.pack(side=tk.LEFT, padx=5)

        self.copy_config_develop_btn = tk.Button(button_frame, text="复制开发路径", command=self.copy_config_develop)
        self.copy_config_develop_btn.pack(side=tk.LEFT, padx=5)

        self.copy_config_test_btn = tk.Button(button_frame, text="复制到测试路径", command=self.copy_config_test)
        self.copy_config_test_btn.pack(side=tk.LEFT, padx=5)

        self.open_subtable_btn = tk.Button(button_frame, text="打开表格", command=self.open_table)
        self.open_subtable_btn.pack(side=tk.LEFT, padx=5)

        self.open_error_btn = tk.Button(button_frame, text="打开报错", command=self.open_error_table)
        self.open_error_btn.pack(side=tk.LEFT, padx=5)

        self.button_state("disabled")

    def button_state(self, states):
        self.open_subtable_btn.config(state=states)

    def create_listbox(self):
        # 创建Listbox用于显示数据
        self.listbox = tk.Listbox(self.right_frame)
        self.listbox.pack(padx=10, pady=10, fill='both', expand=True)
        # 在 create_listbox 方法中绑定双击事件处理函数
        self.listbox.bind("<Double-Button-1>", self.on_double_click)

    def clear_listbox(self):
        # 清空Listbox内容
        self.listbox.delete(0, tk.END)

    def add_data_to_listbox(self, data):
        # 向Listbox中添加数据
        for item in data:
            self.listbox.insert(tk.END, item)

    ##双击列表框的一项数据
    def on_double_click(self, event):
        selected_indices = app.listbox.curselection()  # 获取选中的项的索引
        if len(selected_indices) == 1:  # 只有当选中一项时才触发操作
            selected_item = app.listbox.get(selected_indices[0])  # 获取选中的项的文本
            print("双击项的文字：", self.select_path + "   子表：" + selected_item)

            sub_table_name = selected_item  ##一个子表的名称
            if selected_item.find("_") != selected_item.rfind("_"):
                sub_table_name = selected_item[:selected_item.rfind("_")]

            os.startfile(os.path.abspath(ConfigData["工具导出配置的存放路径"] + sub_table_name + ConfigData["导出的数据后缀"]))

    def on_left_click(self, event):
        # 处理鼠标左键点击事件
        item = self.tree.identify_row(event.y)
        node_text = self.tree.item(item, "text")
        if not node_text.endswith('.xlsx'):
            self.clear_listbox()
            self.file_label.config(text="")
            self.button_state("disabled")
            print("导出文件夹下全部配置")
            self.select_path = self.get_node_path(item)
        else:
            self.file_label.config(text=node_text)
            self.clear_listbox()  ##清空表
            self.button_state("normal")

            self.select_path = self.get_node_path(item)  # 获取节点路径
            table_name_list, image_path = DataHandle.OneXlsxDataHandle(self.select_path)
            print(image_path)
            self.add_data_to_listbox(table_name_list)

    def on_right_click(self, event):
        # 处理鼠标右键点击事件
        item = self.tree.identify_row(event.y)
        node_text = self.tree.item(item, "text")
        # 设置右键点击的节点为选中项
        self.tree.selection_set(item)
        # 创建右键菜单
        # popup_menu = tk.Menu(self.root, tearoff=0)
        if not node_text.endswith('.xlsx'):
            self.clear_listbox()
            self.file_label.config(text="")
            self.button_state("disabled")
            self.select_path = self.get_node_path(item)
            # popup_menu.add_command(label="导出文件夹下全部配置")
        else:
            self.file_label.config(text=node_text)
            self.clear_listbox()  ##清空表
            self.button_state("normal")
            self.select_path = self.get_node_path(item)
            # popup_menu.add_command(label="导出该xlsx文件下配置")
        # 在当前鼠标位置显示菜单
        # popup_menu.post(event.x_root, event.y_root)

    # 获取节点路径
    def get_node_path(self, item):
        # 从根节点到指定节点的路径
        path = [self.tree.item(item, "text")]
        parent = self.tree.parent(item)
        while parent:
            path.insert(0, self.tree.item(parent, "text"))
            parent = self.tree.parent(parent)
        path = path[1:]
        return ConfigData["工具读取的xlsx文件夹路径"] + '/'.join(path)

    def export_all(self):
        DataHandle.AllXlsxDataHandle(ConfigData["工具读取的xlsx文件夹路径"])
        error_text = Config.read_log()
        #print(error_text)
        if error_text.find("导出失败") != -1:
            p1 = error_text.find("配置文件:[")
            if p1 != -1:
                self.error_table_path = error_text[p1 + 6:error_text.find("]")]
            self.err_label.config(text=error_text)
        else:
            if error_text.find("导出异常！") != -1:
                self.err_label.config(text="导出成功！\n但是存在异常！"+error_text)
            else:
                self.err_label.config(text="导出成功！")
            self.error_table_path = ""

    def copy_config_develop(self):
        Config.copy_config_develop()
        self.err_label.config(text="复制配置到开发项目成功！")

    def copy_config_test(self):
        Config.copy_config_test()
        self.err_label.config(text="复制配置到测试项目成功！")

    def open_table(self):
        open_view.openexcel(os.path.abspath(self.select_path))

    def open_error_table(self):
        if self.error_table_path != "":
            open_view.openexcel(os.path.abspath(self.error_table_path))


if __name__ == '__main__':
    if sys.executable.endswith("pythonw.exe"):
        sys.stdout = open(os.devnull, "w")
        sys.stderr = open(os.path.join(os.getenv("TEMP"), "stderr-" + os.path.basename(sys.argv[0])), "w")
    ConfigData = Config.load_data()
    root = tk.Tk()
    app = FileBrowserApp(root)
    root.mainloop()
