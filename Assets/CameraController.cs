using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float speed = 10f;
    public Camera hackerCamera;


    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        InputManager.CameraMovementEvent += MoveCamera;
        InputManager.ClickEvent += OnClick;
    }

    // Update is called once per frame
    void Update()
    {
        if (direction != Vector2.zero)
        {
            transform.position += (transform.right * direction.x + transform.up * direction.y) * speed * Time.deltaTime;
            
        }
        
    }

    void OnClick(Vector2 screenPosition)
    {
        return;
        /*
        Ray ray = hackerCamera.ScreenPointToRay(new Vector3(screenPosition.x, screenPosition.y, 0f));

        

        RaycastHit hitInfo;
        if(Physics.Raycast(ray, out hitInfo))
        {
            SelectableFromScreen selectable;
            selectable = hitInfo.collider.gameObject.GetComponent<SelectableFromScreen>();

            if (selectable)
            {
                selectable.Selected();
            }
            else
            {
                Debug.Log("Nothing selected");
            }
        }
        */
        
    }

    void MoveCamera(Vector2 _direction)
    {
        return;
        //direction = _direction;

    }
}
