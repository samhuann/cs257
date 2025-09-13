using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotMyFirstScript : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float speed;
    void Start()
    {
        print("test Start");
    }

    // Update is called once per frame
    void Update()
    {
        print(speed);
    }
}
