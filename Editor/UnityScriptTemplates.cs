using UnityEngine;
using UnityEditor;

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
