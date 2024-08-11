using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float projectileSpeed = 100f;

    
    // Update is called once per frame
    void Update()
    {
        // Check for player input to shoot
        if (Input.GetButtonDown("Fire1")) // Change "Fire1" to match your input configuration
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate a projectile at the fire point position and rotation
        GameObject newProjectile = Instantiate(projectilePrefab, firePoint.position, Quaternion.identity);

        // Get the Rigidbody component of the projectile
        Rigidbody rb = newProjectile.GetComponent<Rigidbody>();

        // If the Rigidbody component does not exist, add it
        if (rb == null)
        {
            rb = newProjectile.AddComponent<Rigidbody>();
        }

        // Calculate the direction the projectile will move
        Vector3 shootDirection = firePoint.forward;

        // Set the velocity of the projectile to move in the forward direction of the fire point
        rb.velocity = shootDirection * projectileSpeed;

        // Rotate the projectile to have a specific orientation (e.g., facing forward along the Z-axis)
        newProjectile.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
    }
}
