using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;

[CustomEditor(typeof(BoolEventChannel))]
public class BoolEventScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        BoolEventChannel myChannel = (BoolEventChannel)target;

        if (GUILayout.Button("Raise True Event"))
        {
            myChannel.RaiseEvent(true);
        }

        if(GUILayout.Button("Raise False Event"))
        {
            myChannel.RaiseEvent(false);
        }

    }


}

