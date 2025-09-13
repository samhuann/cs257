using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public float rotationSpeed;
    private Vector2 movementValue;
    private float lookValue;

    private void Awake()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>() * speed;
    }

    public void onLook(InputValue value)
    {
        lookValue = value.Get<Vector2>().x * rotationSpeed;
    }
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(
            movementValue.x * Time.deltaTime, 0, movementValue.y * Time.deltaTime, 0
        );
        transform.Rotate(0, lookValue * Time.deltaTime, 0);
        

    }
}
