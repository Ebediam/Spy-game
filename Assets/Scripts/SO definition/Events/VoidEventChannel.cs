using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Events/VoidEvent")]
public class VoidEventChannel : ScriptableObject
{

    public delegate void RaisedDelegate();
    public RaisedDelegate RaisedEvent;


    public void RaiseEvent()
    {
        RaisedEvent?.Invoke();
    }



}
