using UnityEngine;
using System.Collections;

public class SpawnPowerUp : MonoBehaviour
{

    public int numberOfPowerUps = 10;       // How many power ups to spawn
    public float minXSpawn = 0f;            // The min x position that power ups can spawn
    public float maxXSpawn = 10f;           // The max x position that power ups can spawn

    public float minYSpawn = 0f;            // The min x position that power ups can spawn
    public float maxYSpawn = 10f;           // The max x position that power ups can spawn

    public GameObject powerUpPrefab;        // The prefab of the power up to be spawned

    void Start()
    {
        // Run code numberOfPowerUps amount of times
        for (int i = 0; i < numberOfPowerUps; i++)
        {
            // Generate a random number between minXSpawn and maxXSpawn
            float randomX = Random.Range(minXSpawn, maxXSpawn);
            float randomY = Random.Range(minYSpawn, maxYSpawn);


            Vector2 spawnPosition = Vector2.zero;       // Create a variable to store the spawn position being generated
            spawnPosition.x = randomX;                  // Assign x to be our random x value
            spawnPosition.y = randomY;                   // Assign y to our desired y position

            // Instantiate our powerup at the spawn position with a default rotation
            Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);
        }
    }
}