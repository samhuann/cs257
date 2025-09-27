using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update

    public float amount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (amount <= 0)
        {
            Destroy(gameObject);
        }
    }
}
