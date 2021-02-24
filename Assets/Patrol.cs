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

    public PathType pathType;

    public List<Transform> path;

    public float speed;

    public GameObject unit;

    public float reachThreshold;

    private int step;
    private bool reversing = false;

    // Start is called before the first frame update
    void Start()
    {
        unit.transform.position = path[0].position;
        step = 1;
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardsStep();

        if(Vector3.Magnitude(unit.transform.position - path[step].position) < reachThreshold)
        {
            ChangeStep();
        }

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
