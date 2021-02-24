using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : MonoBehaviour
{
    public VoidEventChannel detectEvent;
    

    // Start is called before the first frame update
    void Start()
    {
        detectEvent.RaisedEvent += OnDetection;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDetection()
    {
        Debug.Log("Seeker detected player");
    }
}
