using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 6f;
    private float xbound = 14;
    private float zbound = 6;

    private float size = 1;

    private Rigidbody playerRb;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ResetPlayerPostion();
    }

    // Detect collisions
    private void OnTriggerEnter(Collider other)
    {
        // If we collide with an enemy
        if (other.gameObject.tag == "Enemy")
        {
            // If the player is bigger than the enemy
            if (size > other.gameObject.transform.localScale.x)
            {
                Destroy(other.gameObject);
                Debug.Log("Fish gets bigger");
                Debug.Log("Generates sound effect");
            } 
            // If not
            else
            {
                Destroy(gameObject);
                Debug.Log("Generates particle effect and game over");
            }

        }
    }


    // Move the player by arrow keys
    void MovePlayer()
    {
        var horizontalInput = Input.GetAxis("Horizontal");
        var verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
    }

    // Reset player postion if player move out of bound
    void ResetPlayerPostion()
    {
        // Constrain the player to within the screen
        if (transform.position.x < -xbound)
        {
            transform.position = new Vector3(-xbound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xbound)
        {
            transform.position = new Vector3(xbound, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zbound);
        }
        if (transform.position.z > zbound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zbound);
        }
    }
}
