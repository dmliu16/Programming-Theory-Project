using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Dolphin : Fish
{
    private float speed = 1.6f;
    private int direction = -1;
    private float centerDis = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Swim(gameObject, speed);
        Style();
    }

    protected override void Style()
    {
        centerDis += speed * Time.deltaTime;
        if (centerDis > speed)
        {
            direction = -direction;
            centerDis = 0;
        }
        gameObject.transform.Translate(new Vector3(0, 0, direction) * speed * Time.deltaTime);
    }
}
