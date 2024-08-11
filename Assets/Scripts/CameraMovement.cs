using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    public Movement movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(0f, 6.9f, -10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (movement.isFlying)
        {
            Vector3 direction = new Vector3(0, 0, speed);
            Vector3 forwardMovement = transform.forward * speed;
            rb.velocity = direction;
        }
        else
        {
            rb.velocity = new Vector3 (0, 0, 30);
        }
    }
}