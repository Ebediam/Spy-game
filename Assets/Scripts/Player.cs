using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public CapsuleCollider playerCollider;
    public Camera playerCamera;

    public VRInput controls;

    public float speed = 1f;


    private void Awake()
    {
        controls = new VRInput();

        controls.Player.Movement.performed += Move;
        controls.Player.Use.performed += Use;
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

        transform.position += new Vector3(-movement.y, 0, movement.x) * Time.deltaTime;
    }

    public void Use(InputAction.CallbackContext ctxt)
    {
        Debug.Log("Use pressed");
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
