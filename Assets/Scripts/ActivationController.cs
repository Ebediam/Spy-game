using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationController : MonoBehaviour
{

    public VoidEventChannel activationEvent;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        activationEvent.RaisedEvent += OnActivationEvent;
    }


    void OnActivationEvent()
    {
        gameObject.SetActive(true);
    }

}
