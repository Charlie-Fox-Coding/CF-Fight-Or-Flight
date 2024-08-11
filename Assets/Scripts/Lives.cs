using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public int startingLives = 3;
    public int currentLives;

    private void Start()
    {
        currentLives = startingLives;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            LoseLife();
        }
    }

    private void LoseLife()
    {
        currentLives--;

        if (currentLives <= 0)
        {
            // Game over logic, such as showing a game over screen or resetting the level
            Debug.Log("Game Over");
        }
        else
        {
            // Reset player position or take other actions
            Debug.Log("Lost a life. Remaining lives: " + currentLives);
            // For example, reset player position to a starting position
            transform.position = Vector3.zero;
        }
    }
}

