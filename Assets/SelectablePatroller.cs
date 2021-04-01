using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectablePatroller : SelectableFromScreen
{
    [Header("Event Inputs")]
    public BoolEventChannel EnemyPatrolStateChange;


    [Header("Event Outputs")]
    public VoidEventChannel OnLockButtonEvent;
    public BoolEventChannel EnemyReactivationEvent;
    public BoolEventChannel EnemySelectedEvent;


    
    public override void OnStart()
    {
        base.OnStart();
    }

    public void LockbuttonEvent()
    {
        OnLockButtonEvent.RaiseEvent();
    }

    public override void OnClick()
    {
        base.OnClick();

    }

    public override void Selected()
    {
        base.Selected();
        EnemySelectedEvent.RaiseEvent(true);
    }

    public override void OnDeselect()
    {
        base.OnDeselect();
        EnemyReactivationEvent.RaiseEvent(true);
        EnemySelectedEvent.RaiseEvent(false);

    }
    


    public void OnEnemyPatrolStateChange(bool state)
    {
                

    }

}
