using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMover : MonoBehaviour
{

    public RectTransform transf;
    public Transform followTarget;
    public Camera hackerCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transf.position = hackerCamera.WorldToScreenPoint(followTarget.position);
        //Debug.Log(transf.position);
    }
}
