using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stall : MonoBehaviour
{

    private float attractiveness;

    // Start is called before the first frame update
    void Start()
    {
        attractiveness = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
