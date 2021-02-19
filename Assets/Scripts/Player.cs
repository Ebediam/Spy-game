using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public CapsuleCollider playerCollider;
    public Camera playerCamera;

    public VRInput controls;


    public Rigidbody rb;

    public PlayerData playerData;
    private void Awake()
    {
        controls = new VRInput();

        controls.Player.Movement.performed += Move;
        controls.Player.Use.performed += Use;
        controls.Player.Rotate.performed += Rotate;
        controls.Player.Jump.performed += Jump;
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerCollider.height = playerCamera.transform.position.y - transform.position.y;
        playerCollider.center = new Vector3(playerCollider.center.x, playerCollider.height / 2f, playerCollider.center.z);

    }


    private void Move(InputAction.CallbackContext ctxt)
    {
        
        Vector2 movement = ctxt.ReadValue<Vector2>();

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

    private void Rotate(InputAction.CallbackContext ctxt)
    {
        Vector2 rotate = ctxt.ReadValue<Vector2>();

        transform.Rotate(transform.up, rotate.x * playerData.angularSpeed * Time.deltaTime);

    }

    public void Use(InputAction.CallbackContext ctxt)
    {
        Debug.Log("Use pressed");
    }

    public void Jump(InputAction.CallbackContext ctxt)
    {
        rb.AddForce(transform.up*playerData.jumpForce, ForceMode.VelocityChange);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

}
