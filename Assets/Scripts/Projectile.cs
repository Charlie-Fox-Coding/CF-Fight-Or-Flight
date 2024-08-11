using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject explosionPrefab;
    public Rigidbody rb;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            rb.velocity = new Vector3(0, 0, rb.velocity.z * -1);
        }
        else if (!other.CompareTag("Player"))
        {
            // If the projectile hits anything other than the player or enemy, destroy the projectile
            Destroy(gameObject);
        }
    }
}