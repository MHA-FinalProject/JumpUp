using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    // Reference to the platform prefab that will be instantiated
    public GameObject platformPrefab;

    // Number of platforms to generate
    [SerializeField] public int numberOfPlatforms = 200;

    // Width of the level where platforms can be generated
    [SerializeField] public float levelWidth = 3f;

    // Minimum y-position for platform generation
    [SerializeField] public float minY = .2f;

    // Maximum y-position for platform generation
    [SerializeField] public float maxY = 3f;

    void Start()
    {
        // Initialize the spawn position vector
        Vector3 spawnPosition = new Vector3();

        // Loop to generate the specified number of platforms
        for (int i = 0; i < numberOfPlatforms; i++)
        {
            // Increment the y-position of the spawn position by a random value between minY and maxY
            spawnPosition.y += Random.Range(minY, maxY);

            // Set the x-position of the spawn position to a random value within the level width
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            // Instantiate a platform at the calculated spawn position with no rotation (Quaternion.identity)
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
