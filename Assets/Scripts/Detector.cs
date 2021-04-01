using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    [Header("Output Events")]
    public VoidEventChannel detectionEvent;
    [Header("Input Events")]
    public BoolEventChannel EnemyIconSelectedEvent;

    public int visibleLayer = 6;
    public int invisibleLayer = 9;

    // Start is called before the first frame update
    void Start()
    {
        EnemyIconSelectedEvent.RaisedEvent += OnEnemyIconSelected;
    }

    public void OnEnemyIconSelected(bool state)
    {
        if (state)
        {
            TurnVisible();
        }
        else
        {
            TurnInvisible();
        }
    }

    public void TurnVisible()
    {
        gameObject.layer = visibleLayer;
    }

    public void TurnInvisible()
    {
        gameObject.layer = invisibleLayer;
    }


    private void OnTriggerStay(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            RaycastHit hitInfo;

           if(Physics.Raycast(transform.position, (other.transform.position-transform.position), out hitInfo))
           {
                if(hitInfo.collider.CompareTag("Player"))
                {
                    detectionEvent.RaiseEvent();
                }
           }

        }
    }
}
