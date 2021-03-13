using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectablePatroller : SelectableFromScreen
{
    [Header("Event Inputs")]
    public BoolEventChannel EnemyPatrolStateChange;


    [Header("Event Outputs")]
    public VoidEventChannel onSelect;

    [Header("Settings")]
    public MeshRenderer iconRenderer;

    public void Start()
    {
        EnemyPatrolStateChange.RaisedEvent += OnEnemyPatrolStateChange;
    }

    public override void Selected()
    {
        base.Selected();
        onSelect.RaiseEvent();
    }

    public void OnEnemyPatrolStateChange(bool state)
    {
        if (state)
        {
            iconRenderer.material = ColoredMaterialData.red;
        }
        else
        {
            iconRenderer.material = ColoredMaterialData.grey;
        }
    }

}
