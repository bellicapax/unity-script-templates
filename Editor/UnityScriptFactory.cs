using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

// Adapted from https://github.com/gd2020/EntitasTemplates

//MIT License

//Copyright(c) 2018 HDy_cu

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

[InitializeOnLoad]
public class UnityScriptFactory
{
#if ASSETS
    private const string PREFIX = "Assets/";
#else
    private const string PREFIX = "Packages/";
#endif
    private const string PATH = PREFIX + "/com.bellicapax.unity-script-templates/Editor/ScriptTemplates/";

    public class DoCreateScriptAsset : EndNameEditAction
    {
        public override void Action(int instanceId, string pathName, string resourceFile)
        {
            var text = File.ReadAllText(resourceFile);
            var className = Path.GetFileNameWithoutExtension(pathName);
            className = className.Replace(" ", "");
            text = text.Replace("#SCRIPTNAME#", className);

            var encoding = new UTF8Encoding(true, false);
            File.WriteAllText(pathName, text, encoding);

            AssetDatabase.ImportAsset(pathName);
            var asset = AssetDatabase.LoadAssetAtPath<MonoScript>(pathName);
            ProjectWindowUtil.ShowCreatedAsset(asset);
        }
    }

    public static void CreateScriptAsset(string fileName)
    {
        string filePath = PATH + fileName;
        Texture2D icon = EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D;
        string newFileName = "New" + fileName.Replace(".txt", ".cs");
        var endNameAction = ScriptableObject.CreateInstance<DoCreateScriptAsset>();
        ProjectWindowUtil.StartNameEditingIfProjectWindowExists(0, endNameAction, newFileName, icon, filePath);
    }
}
