using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{

    public LayerMask collisionLayer;
    public Player player;
    public float checkDistance;
    public PhysicMaterial playerMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, checkDistance, collisionLayer))
        {
            player.onGround = true;
            playerMaterial.staticFriction = 1f;
            playerMaterial.dynamicFriction = 1f;
        }
        else
        {
            player.onGround = false;
            playerMaterial.staticFriction = 0f;
            playerMaterial.dynamicFriction = 0f;
        }
        
    }
}
