using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchButton : MonoBehaviour
{
    public VoidEventChannel eventChannel;

    public void RaiseEvent()
    {
        eventChannel.RaiseEvent();
    }

}
