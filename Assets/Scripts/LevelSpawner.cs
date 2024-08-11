using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSpawner : MonoBehaviour
{
    public List<GameObject> gameObjectsList;
    public float spawnHeight = 0f;
    public GameObject player;
    public int spawnInterval = 100;
    public int randomNumber;

    private Queue<GameObject> objectQueue = new Queue<GameObject>();

    void Start()
    {
        StartCoroutine(SpawnPrefabsWithDelay());
    }

    IEnumerator SpawnPrefabsWithDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            // Update the public randomNumber variable
            randomNumber = Random.Range(0, gameObjectsList.Count);

            Vector3 playerPosition = player.transform.position;
            Vector3 spawnPosition = new Vector3(0f, spawnHeight, playerPosition.z + 10f);
            GameObject obj = Instantiate(gameObjectsList[randomNumber], spawnPosition, Quaternion.identity);
            // Enqueue the instantiated object
            objectQueue.Enqueue(obj);
        }
    }

    void Update()
    {
        // Move the player forward in the Update loop
        if (player != null)
        {
            player.transform.Translate(Vector3.forward * Time.deltaTime * 50f);
        }

        // Check and process objects in the queue
        while (objectQueue.Count > 0)
        {
            GameObject obj = objectQueue.Dequeue();
            // Do any processing related to the instantiated objects here
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Check if the spawned object has collided with the player
        if (other.gameObject == player)
        {
            // Handle the collision with the player here
            Debug.Log("Player collided with spawned object!");
        }
    }
}