using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDetector : MonoBehaviour
{
    public VoidEventChannel playerDetectedEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerDetectedEvent.RaiseEvent();
        }
    }


}
