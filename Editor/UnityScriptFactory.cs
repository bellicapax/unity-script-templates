using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

// Adapted from https://github.com/gd2020/EntitasTemplates

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
