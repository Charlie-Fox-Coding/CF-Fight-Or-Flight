using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMovement : MonoBehaviour
{
    public float speed;
    public float moveSpeed = 50f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = (PlayerPrefs.GetFloat("Level") - 1) / 10;
        speed += 1;
        rb.velocity = new Vector3(0, 0, moveSpeed * -1f * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
