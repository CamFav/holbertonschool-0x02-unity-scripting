using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // Controls velocity multiplier
    private Rigidbody rb;

    private int score =  0;   // Set the initial value of score to 0.

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate
    void FixedUpdate()
    {
        // Get input from ZQSD or arrow keys
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a Vector3 for movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Move the player
        rb.AddForce(movement * speed);
    }

    // Increment the value of score when the Player touches an object tagged Pickup
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup")) // Check if player collides with a object tagged Pickup (coin)
        {
            score++;

            Debug.Log("Score: " + score);

            other.gameObject.SetActive(false); // Disable the coin (Destroy(other.gameObject) to destroy it)
        }
    }
}
