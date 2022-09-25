using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Shark : Fish
{
    private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Swim(gameObject, speed);
    }
}
