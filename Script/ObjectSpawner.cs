using UnityEngine;

// This script spawns objects at random positions within a defined area at regular intervals.
// Attach this script to an empty GameObject in your Unity scene.
[AddComponentMenu("Custom/Object Spawner")]
[DisallowMultipleComponent]
public class ObjectSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [Tooltip("The prefab to be spawned. Assign in the Inspector.")]
    public GameObject objectToSpawn; // The prefab to be spawned. Assign in the Inspector.

    [Tooltip("Time interval (in seconds) between spawns.")]
    public float spawnRate = 1f;     // Time interval (in seconds) between spawns.
    
    [Header("Spawn Area")]
    [Tooltip("Minimum X coordinate for the spawn area.")]
    public float minX = -5f;

    [Tooltip("Maximum X coordinate for the spawn area.")]
    public float maxX = 5f;

    [Tooltip("Minimum Y coordinate for the spawn area.")]
    public float minY = 0f;

    [Tooltip("Maximum Y coordinate for the spawn area.")]
    public float maxY = 5f;

    [Tooltip("Minimum Z coordinate for the spawn area.")]
    public float minZ = -5f;

    [Tooltip("Maximum Z coordinate for the spawn area.")]
    public float maxZ = 5f;
    
    [Header("Object Settings")]
    [Tooltip("How long (in seconds) the spawned object exists before being destroyed.")]
    public float lifetime = 3f;      // How long (in seconds) the spawned object exists before being destroyed.
    
    private float nextSpawnTime;     // Tracks the next time an object should be spawned.

    void Start()
    {
        // Initialize the next spawn time to the current time when the game starts.
        nextSpawnTime = Time.time;
    }

    void Update()
    {
        // Check if it's time to spawn a new object.
        if (Time.time >= nextSpawnTime)
        {
            SpawnObject(); // Spawn the object

            // Schedule the next spawn time based on the current time and spawn rate.
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    // Handles the spawning of objects.
    void SpawnObject()
    {
        // Generate a random position within the defined spawn area.
        Vector3 randomPosition = new Vector3(
            Random.Range(minX, maxX),
            Random.Range(minY, maxY),
            Random.Range(minZ, maxZ)
        );

        // Instantiate (spawn) the object at the random position with no rotation (Quaternion.identity).
        GameObject spawnedObject = Instantiate(objectToSpawn, randomPosition, Quaternion.identity);

        // Automatically destroy the spawned object after the specified lifetime to prevent clutter.
        Destroy(spawnedObject, lifetime);
    }
}
