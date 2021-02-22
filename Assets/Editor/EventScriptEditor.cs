using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VoidEventChannel))]
public class EventScriptEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if(GUILayout.Button("Raise Event"))
        {
            VoidEventChannel myChannel = (VoidEventChannel)target;

            myChannel.RaiseEvent();
        }
    }


}
