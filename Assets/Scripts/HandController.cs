using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public enum Side
    {
        Left,
        Right
    }

    public Side side;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        switch (side)
        {
            case Side.Left:
                InputManager.LeftGripEvent += GripPressed;
                InputManager.LeftIndexEvent += IndexPressed;
                break;


            case Side.Right:
                InputManager.RightGripEvent += GripPressed;
                InputManager.RightIndexEvent += IndexPressed;
                break;

            default:
                Debug.LogError("Hand without side!");
                break;
        }

    }

    private void IndexPressed(bool state)
    {
        animator.SetBool("isPinching", state);
    }

    private void GripPressed(bool state)
    {
        animator.SetBool("isGripping", state);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
