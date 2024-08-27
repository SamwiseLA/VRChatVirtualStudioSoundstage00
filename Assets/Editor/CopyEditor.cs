using UnityEngine;
using UnityEditor;
using System.IO;
[InitializeOnLoadAttribute]
public static class CopyEditor
{
    static CopyEditor()
    {
        EditorApplication.playModeStateChanged += LogPlayModeState;
    }
 
    private static void LogPlayModeState(PlayModeStateChange state)
    {
        if (File.Exists("QualitySettings.asset"))
        {
            Debug.Log("QualitySettings.asset Exists");
            //File.Delete("ProjectSettings/QualitySettings.asset");
            //Debug.Log("After Delete");
            //File.Copy("QualitySettings.asset", "ProjectSettings/QualitySettings.asset");
            //Debug.Log("After Copy");
        } else {
            Debug.Log("QualitySettings.asset DOES NOT Exists");
        }
    }
 
}
