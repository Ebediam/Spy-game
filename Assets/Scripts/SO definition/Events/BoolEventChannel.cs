using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Events/BoolEvent")]
public class BoolEventChannel : ScriptableObject
{

    public delegate void BoolEventDelegate(bool b);
    public BoolEventDelegate RaisedEvent;


    public void RaiseEvent(bool state)
    {
        RaisedEvent?.Invoke(state);
    }

    

}
