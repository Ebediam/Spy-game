using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public VoidEventChannel buttonEvent;
    float speed = 3f;

    public enum State
    {
        Open,
        Closed
    }

    public State startingState;
    State currentState;
    public Transform openPosition;
    public Transform closedPosition;
    public GameObject doorObject;


    // Start is called before the first frame update
    void Start()
    {
        if(startingState == State.Closed)
        {
            CloseDoor();
        }
        else
        {
            OpenDoor();
        }

        
    }


    private void OnEnable()
    {
        buttonEvent.RaisedEvent += SwitchState;
    }

    private void OnDisable()
    {
        buttonEvent.RaisedEvent -= SwitchState;
    }

    public void SwitchState()
    {
        if(currentState == State.Closed)
        {
            OpenDoor();
        }
        else
        {
            CloseDoor();
        }
    }

    
    public void OpenDoor()
    {
        //doorObject.transform.position = openPosition.position;
        StopCoroutine("MoveDoor");
        StartCoroutine("MoveDoor", openPosition.position);
        currentState = State.Open;
    }

    public void CloseDoor()
    {
        //doorObject.transform.position = closedPosition.position;

        StopCoroutine("MoveDoor");
        StartCoroutine("MoveDoor", closedPosition.position);

        currentState = State.Closed;
    }



    public IEnumerator MoveDoor(Vector3 finalPosition)
    {

        while(Vector3.Distance(doorObject.transform.position, finalPosition) > 0.02f)
        {
            doorObject.transform.position = Vector3.Lerp(doorObject.transform.position, finalPosition, speed * Time.deltaTime);
            yield return null;
        }

        doorObject.transform.position = finalPosition;

    }




}
