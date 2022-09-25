using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Fish : MonoBehaviour
{
    protected float xDestroy = 15;
    private float speed = 1.0f;
    protected Vector3 direction = new Vector3(0, 1, 0);

    protected virtual void Swim(GameObject gameObject, float speed)
    {
        gameObject.transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > xDestroy || transform.position.x < -xDestroy)
        {
            Destroy(gameObject);
        }
    }
}
