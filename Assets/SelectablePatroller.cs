using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectablePatroller : SelectableFromScreen
{
    [Header("Event Inputs")]
    public BoolEventChannel EnemyPatrolStateChange;


    [Header("Event Outputs")]
    public VoidEventChannel OnSelect;

    [Header("Settings")]
    public MeshRenderer meshRenderer;

    public void Start()
    {
        EnemyPatrolStateChange.RaisedEvent += OnEnemyPatrolStateChange;
    }

    public override void Selected()
    {
        base.Selected();
        OnSelect.RaiseEvent();
    }

    public void OnEnemyPatrolStateChange(bool state)
    {
        if (state)
        {
            meshRenderer.material = ColoredMaterialData.red;
        }
        else
        {
            meshRenderer.material = ColoredMaterialData.grey;
        }
    }

}
