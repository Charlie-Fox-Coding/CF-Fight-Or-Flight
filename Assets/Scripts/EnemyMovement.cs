using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public LevelSpawner levelSpawner;
    public Vector2[] movePoints;
    public float speed = 0f;
    public float horizontalSpeed = 50f;
    public float hitSpeedReductionFactor = 0.9999f;

    public Vector2 targetMovePoint;
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

    public AudioSource sound;

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(0, 0, speed);
        rb.velocity = movement;
    }

    void Update()
    {
        if (levelSpawner != null && levelSpawner.gameObjectsList.Count > 0 && !gameEnded)
        {
            int randomNumber = levelSpawner.randomNumber;
            targetMovePoint = movePoints[randomNumber];
            Vector2 direction = (targetMovePoint - (Vector2)transform.position).normalized;
            transform.Translate(direction * horizontalSpeed * Time.deltaTime / 10f);
            Vector3 movement = new Vector3(0, 0, speed);
            rb.velocity = movement;
        }
    }

    // Handle collision with projectiles
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // Reduce the enemy's speed
            speed -= (-50f + (50f * 0.999f)) * -1;
            // Destroy the projectile
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            gameEnded = true;
            sound.Play();
            Vector3 movement = new Vector3(0, 0, 20f);
            rb.velocity = movement;
            rb.mass = 10;
            rb.useGravity = true;
        }

        if (other.CompareTag("Ground"))
        {
            Invoke("Win", 2f);
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

    private void Win()
    {
        SceneManager.LoadScene(1);
    }
}
