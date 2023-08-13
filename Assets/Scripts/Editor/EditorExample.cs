using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EditorExample : EditorWindow
{
    [MenuItem("EditorExample/Menu")]
    static void Init()
    {
         GetWindow<EditorExample>();
        //window.Show();
    }
}
