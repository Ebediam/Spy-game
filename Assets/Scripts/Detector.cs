using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{

    public VoidEventChannel detectionEvent;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
