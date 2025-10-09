using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    // Start is called before the first frame update

    public int amount;
    void Start()
    {
        
    }

    void OnDestroy()
    {
        ScoreManager.instance.amount += amount;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
