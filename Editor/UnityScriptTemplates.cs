using UnityEngine;
using UnityEditor;


[InitializeOnLoad]
public class UnityScriptTemplates
{
    [MenuItem("Assets/Create/C#/POCO", false, 81)]
    private static void CreatePoco()
    {
        UnityScriptFactory.CreateScriptAsset("POCO.txt");
    }

    [MenuItem("Assets/Create/C#/Interface", false, 81)]
    private static void CreateInterface()
    {
        UnityScriptFactory.CreateScriptAsset("Interface.txt");
    }

    [MenuItem("Assets/Create/C#/Enum", false, 81)]
    private static void CreateEnum()
    {
        UnityScriptFactory.CreateScriptAsset("Enum.txt");
    }

    [MenuItem("Assets/Create/C#/StaticSingleton", false, 81)]
    private static void CreateStaticSingleton()
    {
        UnityScriptFactory.CreateScriptAsset("StaticSingleton.txt");
    }

    [MenuItem("Assets/Create/Editor/EditorWindow", false, 82)]
    private static void CreateEditorWindow()
    {
        UnityScriptFactory.CreateScriptAsset("EditorWindow.txt");
    }

    [MenuItem("Assets/Create/Editor/CustomInspector", false, 82)]
    private static void CreateCustomInspector()
    {
        UnityScriptFactory.CreateScriptAsset("CustomInspector.txt");
    }

    [MenuItem("Assets/Create/Editor/CustomPropertyDrawer", false, 82)]
    private static void CreateCustomPropertyDrawer()
    {
        UnityScriptFactory.CreateScriptAsset("CustomPropertyDrawer.txt");
    }

    [MenuItem("Assets/Create/ScriptableObject", false, 83)]
    private static void CreateScriptableObject()
    {
        UnityScriptFactory.CreateScriptAsset("ScriptableObject.txt");
    }
}
