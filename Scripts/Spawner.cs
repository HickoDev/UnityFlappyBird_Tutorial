using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PrefabToSpawn ; // The prefab to spawn
    public float initialSpawnInterval ; // Initial time between each spawn
    public float minY; // Minimum Y position for spawning
    public float maxY ; // Maximum Y position for spawning
    public float spawnX ; // Constant X position for spawning
    public float spawnZ;// Constant Z position for spawning


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
        Instantiate(PrefabToSpawn, spawnPosition, Quaternion.identity);

       
      
    }
}
