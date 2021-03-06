using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public enum PathType
    {
        Loop,
        Reverse
    }

    [Header("Event Inputs")]
    public VoidEventChannel stopPatrolEvent;
    public BoolEventChannel boolPatrolEvent;
    public VoidEventChannel switchPatrolEvent;

    [Header("Event Outputs")]
    public BoolEventChannel patrolResponse;

    public PathType pathType;

    [Header("Settings")]

    public List<Transform> path;

    public float speed;

    public GameObject unit;

    public float reachThreshold;

    private int step;
    private bool reversing = false;

    private bool isPatrolling = true;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        unit.transform.position = path[0].position;
        step = 1;

        stopPatrolEvent.RaisedEvent += StopPatrolling;
        boolPatrolEvent.RaisedEvent += ChangePatrolState;
        switchPatrolEvent.RaisedEvent += SwitchPatrolState;
        animator.SetBool("isMoving", isPatrolling);

    }

    // Update is called once per frame
    void Update()
    {
        if (isPatrolling)
        {
            MoveTowardsStep();

            if (Vector3.Magnitude(unit.transform.position - path[step].position) < reachThreshold)
            {
                ChangeStep();
            }

        }
        


    }

    public void StopPatrolling()
    {
        isPatrolling = false;
        animator.SetBool("isMoving", false);
        patrolResponse.RaiseEvent(false);
    }

    public void SwitchPatrolState()
    {
        isPatrolling = !isPatrolling;
        patrolResponse.RaiseEvent(isPatrolling);
        animator.SetBool("isMoving", isPatrolling);
    }

    public void ChangePatrolState(bool patrol)
    {
        isPatrolling = patrol;
        patrolResponse.RaiseEvent(isPatrolling);
        animator.SetBool("isMoving", isPatrolling);
    }

    void MoveTowardsStep()
    {
        unit.transform.position += (path[step].position - unit.transform.position).normalized * speed * Time.deltaTime;
        unit.transform.LookAt(path[step]);

    }

    void ChangeStep()
    {

        if (!reversing)
        {
            if (step + 1 >= path.Count)
            {
                switch (pathType)
                {
                    case PathType.Loop:
                        step = 0;
                        break;

                    case PathType.Reverse:
                        reversing = true;
                        step--;
                        break;
                }
            }
            else
            {
                step++;
            }
        }
        else
        {
            if(step == 0)
            {
                reversing = false;
                step = 1;
            }
            else
            {
                step--;
            }
        }

    }
}
