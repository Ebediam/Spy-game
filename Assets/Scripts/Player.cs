using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public CapsuleCollider playerCollider;
    public Camera playerCamera;

    public Rigidbody rb;

    public PlayerData playerData;



    // Start is called before the first frame update
    void Start()
    {
        InputManager.LeftThumbstickEvent += Move;
        InputManager.RightThumbstickEvent += Rotate;
        InputManager.RightThumbstickPressEvent += Jump;
    }

    // Update is called once per frame
    void Update()
    {
        playerCollider.height = playerCamera.transform.position.y - transform.position.y;
        playerCollider.center = new Vector3(playerCollider.center.x, playerCollider.height / 2f, playerCollider.center.z);

    }


    private void Move(Vector2 movement)
    {        
        rb.AddRelativeForce(new Vector3(movement.x, 0, movement.y) *playerData.acceleration* Time.deltaTime, ForceMode.Acceleration);

        if(Mathf.Abs(rb.velocity.x) > playerData.maxSpeed)
        {
            rb.velocity = Utils.SwapFromVector(rb.velocity, playerData.maxSpeed * Mathf.Sign(rb.velocity.x), VectorPosition.x);
        }

        if(Mathf.Abs(rb.velocity.z) > playerData.maxSpeed)
        {
            rb.velocity = Utils.SwapFromVector(rb.velocity, playerData.maxSpeed * Mathf.Sign(rb.velocity.z), VectorPosition.z);
        }

    }

    private void Rotate(Vector2 rotation)
    {
        transform.Rotate(transform.up, rotation.x * playerData.angularSpeed * Time.deltaTime);
    }

    private void Jump(bool value)
    {
        if (value)
        {
            Jump();
        }
    }

    public void Jump()
    {
        rb.AddForce(transform.up*playerData.jumpForce, ForceMode.VelocityChange);
    }


}
