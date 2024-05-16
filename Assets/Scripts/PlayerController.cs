using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //Controls velocity multiplier
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
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
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
