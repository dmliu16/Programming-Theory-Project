using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Dolphin : Fish
{
    private float speed = 1.6f;

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
