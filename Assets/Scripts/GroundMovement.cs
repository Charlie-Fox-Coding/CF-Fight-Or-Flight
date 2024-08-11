using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float speed = 50f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the combined movement vector
        Vector3 movement = (transform.forward * speed * -1);

        // Set the Rigidbody's velocity to the combined movement vector
        rb.velocity = movement;
    }
}
