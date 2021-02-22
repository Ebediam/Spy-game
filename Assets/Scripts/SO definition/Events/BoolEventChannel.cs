using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolEventChannel : ScriptableObject
{

    public delegate void BoolEventDelegate(bool b);
    public BoolEventDelegate RaisedBoolEvent;


    public void Raise(bool state)
    {
        RaisedBoolEvent?.Invoke(state);
    }

}
