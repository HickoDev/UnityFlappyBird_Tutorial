using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab; // The prefab to spawn
    public float initialSpawnInterval = 2f; // Initial time between each spawn
    public float minY = -2f; // Minimum Y position for spawning
    public float maxY = 2f; // Maximum Y position for spawning
    public float spawnX = 5f; // Constant X position for spawning
    public float spawnZ = 0f; // Constant Z position for spawning


    private float currentSpawnInterval;

    void Start()
    {
        currentSpawnInterval = initialSpawnInterval;
        InvokeRepeating(nameof(SpawnPipe), currentSpawnInterval, currentSpawnInterval);
    }

    void SpawnPipe()
    {
        // Generate a random Y position within the range
        float randomY = Random.Range(minY, maxY);

        // Define the spawn position using the fixed X, Z, and random Y
        Vector3 spawnPosition = new Vector3(spawnX, randomY, spawnZ);

        // Instantiate the pipe prefab at the spawn position with no rotation
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

        // Increase the time scale to speed up the game
      
    }
}
