import json
import shutil
import os


def load_data():
    with open('config.txt', 'r', encoding='utf-8') as file:
        data = json.load(file)
    return data


def load_data_key(key):
    with open('config.txt', 'r', encoding='utf-8') as file:
        data = json.load(file)
    return data[key]


##读取日志数据
def read_log():
    with open('log.txt', 'r', encoding='utf-8') as file:
        return file.read()


def add_log(str):
    with open(r'log.txt', 'a', encoding='utf-8') as test:
        test.write(str + "\n")


##清除文件数据
def close_log():
    with open('log.txt', 'a+', encoding='utf-8') as test:
        test.truncate(0)

##删除文件夹
def delete_folder(path):
    if os.path.exists(path) and os.path.isdir(path):
        shutil.rmtree(path)


##删除文件夹下数据
def del_file(path):
    if not os.listdir(path):
        add_log('目录已为空！')
    else:
        for i in os.listdir(path):
            path_file = os.path.join(path, i)  # 取文件绝对路径
            if os.path.isfile(path_file):
                os.remove(path_file)
            else:
                del_file(path_file)
                shutil.rmtree(path_file)


##删除一个文件
def del_file_one(path):
    shutil.rmtree(path)


def copy_dir(src_path, target_path):
    if os.path.isdir(src_path) and os.path.isdir(target_path):
        filelist_src = os.listdir(src_path)
        for file in filelist_src:
            path = os.path.join(os.path.abspath(src_path), file)
            if os.path.isdir(path):
                path1 = os.path.join(os.path.abspath(target_path), file)
                if not os.path.exists(path1):
                    os.mkdir(path1)
                copy_dir(path, path1)
            else:
                with open(path, 'rb') as read_stream:
                    contents = read_stream.read()
                    path1 = os.path.join(target_path, file)
                    with open(path1, 'wb') as write_stream:
                        write_stream.write(contents)
        return True

    else:
        return False


##复制数据到开发路径
def copy_config_develop():
    Config = load_data()
    # 定义源文件夹和目标文件夹的路径
    src_dir_config = Config["工具导出配置的存放路径"]
    src_dir_images = Config["工具导出图片的存放路径"]
    src_file = Config["工具导出配置的索引文件路径"]

    dst_dir_config = Config["配置文件复制到项目开发路径"]
    dst_dir_images = Config["PNG资源复制到项目开发路径"]
    dst_folder = Config["flie_name.json复制到项目开发路径"]
    del_file(Config["复制时删除开发路径"])
    
    # 使用shutil模块中的copytree()方法复制文件夹
    shutil.copytree(src_dir_config, dst_dir_config)
    shutil.copytree(src_dir_images, dst_dir_images)
    shutil.copy2(src_file, dst_folder)


##复制数据到测试路径
def copy_config_test():
    Config = load_data()
    # 定义源文件夹和目标文件夹的路径
    src_dir_config = Config["工具导出配置的存放路径"]
    src_dir_images = Config["工具导出图片的存放路径"]
    src_file = Config["工具导出配置的索引文件路径"]

    dst_dir_config = Config["配置文件复制到项目测试路径"]
    dst_dir_images = Config["PNG资源复制到项目测试路径"]
    dst_folder = Config["flie_name.json复制到项目测试路径"]
    del_file(Config["复制时删除测试路径"])

    # 使用shutil模块中的copytree()方法复制文件夹
    shutil.copytree(src_dir_config, dst_dir_config)
    shutil.copytree(src_dir_images, dst_dir_images)
    shutil.copy2(src_file, dst_folder)
