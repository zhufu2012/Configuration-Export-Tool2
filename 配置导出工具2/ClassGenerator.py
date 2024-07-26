class CSharpClassGenerator:
    def __init__(self, data):
        self.data = data

    def generate_class(self,result_dict):
        class_name = self._get_class_name()
        properties = self._generate_properties(result_dict)
        constructor = self._generate_constructor()
        constructor2 = self._generate_constructor2()
        return f'namespace Remnant_Afterglow\n{{\n    public class {class_name}\n    ' + '{\n        #region 参数及初始化\n' + properties + '\n' +\
               constructor+"\n        " +constructor2+ '    }\n}\n'

    def _get_class_name(self):
        return self.data['file_name'][4:5].upper() + self.data['file_name'][5:]

    def _generate_properties(self,result_dict):
        properties = []
        for key, value_type in self.data['key_list'].items():
            if key == 'KEY_INDEX':
                continue  # Skip the index key as it's not a property of the class.
            describe = ""
            for i,key_name in enumerate(result_dict[2]):
                if key_name==key and (len(result_dict[1])>=i+1) and (result_dict[1][i] in [1,2,3] ) :
                    describe = result_dict[0][i]
            describe = describe.replace("\n","\n        ///")
            properties.append(f'        /// <summary>        \n        /// {describe}\n        /// </summary>\n        public {value_type} {key} {{ get; set; }}')

        return '\n'.join(properties)

    def _generate_properties2(self):
        properties = []
        for key, value_type in self.data['key_list'].items():
            if key == 'KEY_INDEX':
                continue  # Skip the index key as it's not a property of the class.
            properties.append(f'			{key} = ({value_type})dict[\"{key}\"];')
        return '\n'.join(properties)


    def _generate_constructor(self):
        class_name = self._get_class_name()
        constructor_args = ', '.join([f'{v} {k}' for k, v in self.data['key_list'].items() if k != 'KEY_INDEX'])
        assignment_statements = self._generate_properties2()
        filename = self.data['file_name']
        return f'\n        public {class_name}(int id)\n        ' +  '{'+\
        f'\n            Dictionary<string, object> dict = ConfigLoadSystem.GetCfgIndex(ConfigConstant.Config_{self._get_class_name()}, id);'+\
                   f'//public const string Config_{self._get_class_name()} = \"'+f'{filename}\"; \n' \
                                                                    '' + assignment_statements + '\n        '+\
               '}\n'
    def _generate_constructor2(self):
        class_name = self._get_class_name()
        constructor_args = ', '.join([f'{v} {k}' for k, v in self.data['key_list'].items() if k != 'KEY_INDEX'])
        assignment_statements = self._generate_properties2()
        filename = self.data['file_name']
        return f'public {class_name}(Dictionary<string, object> dict)\n        ' +  '{\n'+ \
                '' + assignment_statements + '\n        '+ \
               '}\n        #endregion\n'

# Usage example
# data = {
#     'file_name': 'cfg_MapMaterial',
#     'file_path': './data/config/data/cfg_MapMaterial.json',
#     'key_list': {
#         'KEY_INDEX': 'string',
#         'MaterialId': 'int',
#         'MaterialName': 'string',
#         'Probability': 'float',
#         'ImageSetId': 'int',
#         'ImageSetIndex': 'int',
#         'Parame': 'float'
#     }
# }
#
# generator = CSharpClassGenerator(data)
# csharp_code = generator.generate_class()
# print(csharp_code)