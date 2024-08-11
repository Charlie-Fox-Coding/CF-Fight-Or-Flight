using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float forwardSpeed = 5f; // Forward speed of the plane
    public float horizontalSensitivity = 2f; // Sensitivity for horizontal movement
    public float verticalSensitivity = 2f; // Sensitivity for vertical movement
    public float maxHorizontal = 5f; // Maximum horizontal position
    public float minHorizontal = -5f; // Minimum horizontal position
    public float maxVertical = 5f; // Maximum vertical position
    public float minVertical = -5f; // Minimum vertical position

    public bool isFlying = true;

    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isFlying)
        {
            // Handle directional movement
            float horizontalInput = Input.GetAxis("Horizontal") * horizontalSensitivity;
            float verticalInput = Input.GetAxis("Vertical") * verticalSensitivity;

            // Calculate the movement direction based on input
            Vector3 movement = new Vector2(horizontalInput, verticalInput);

            // Move the plane based on input direction and speed
            transform.Translate(movement * Time.deltaTime * speed);

            // Ensure the plane stays within the boundaries
            Vector3 clampedPosition = transform.position;
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, minHorizontal, maxHorizontal);
            clampedPosition.y = Mathf.Clamp(clampedPosition.y, minVertical, maxVertical);
            transform.position = new Vector3 (clampedPosition.x, clampedPosition.y, 0);
        }
    }
}
