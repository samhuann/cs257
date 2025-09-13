using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prefab;
    public GameObject shootPoint;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

        }
    }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;

        }
    }
}
