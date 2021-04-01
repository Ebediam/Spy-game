using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconMover : MonoBehaviour
{
    public Transform followTarget;
    public Camera hackerCamera;
    public bool isStatic;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = hackerCamera.WorldToScreenPoint(followTarget.position);        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStatic)
        {
            return;
        }

        transform.position = hackerCamera.WorldToScreenPoint(followTarget.position);
        
    }
}
