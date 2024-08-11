using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    public int lives = 5;
    public GameObject explosionPrefab;
    public GameObject[] hearts;

    public Rigidbody rb;

    public bool gameEnded = false;

    public GameObject explosionPrefab1;
    public GameObject explosionPrefab2;
    public GameObject explosionPrefab3;
    public GameObject explosionPrefab4;
    public GameObject explosionPrefab5;
    public GameObject explosionPrefab6;
    public GameObject explosionPrefab7;
    public GameObject explosionPrefab8;
    public GameObject explosionPrefab9;
    public GameObject explosionPrefab10;

    public Movement movement;

    public AudioSource sound;

    public AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void LoseLife()
    {
        lives -= 1;
        if (lives == 0)
        {
            rb.mass = 10;
            rb.useGravity = true;
            gameEnded = true;
            movement.isFlying = false;
            loseSound.Play();
            hearts[lives].SetActive(false);
        }
        else
        {
            hearts[lives].SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall") && gameEnded != true)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            LoseLife();

            sound.Play();
        }


        

        if (other.CompareTag("Ground"))
        {
            Invoke("Lose", 2f);
            Instantiate(explosionPrefab1, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab2, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab3, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab4, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab5, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab6, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab7, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab8, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab9, transform.position, Quaternion.identity);
            Instantiate(explosionPrefab10, transform.position, Quaternion.identity);
        }
    }

    private void Lose()
    {
        SceneManager.LoadScene(3);
    }
}