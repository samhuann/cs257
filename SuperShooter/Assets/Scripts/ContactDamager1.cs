using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    // Start is called before the first frame update

    public float damage;

    void OggerEnter(Collider other)
    {
        Destroy(gameObject);

        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.amount-=damage;
        }     
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
