using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDirection : MonoBehaviour
{
    public Vector3 direction;

    private float xDestroy = 15;
    private float speed = 1.0f;
    private Rigidbody fishRb;
    
    // Start is called before the first frame update
    void Start()
    {
        fishRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.x > xDestroy || transform.position.x < -xDestroy)
        {
            Destroy(gameObject);
        }
    }
}
