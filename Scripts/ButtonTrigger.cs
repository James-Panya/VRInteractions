using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public GameObject cubePrefab; // Reference to the cube prefab
    public float spawnRadius = 5.0f; // Radius within which to spawn the cubes
    public float minimumHeight = 1.0f; // Minimum height above the ground to spawn the cubes
    public AudioSource AS;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Button"))
        {
            AS.Play();
            SpawnCube();
            Debug.Log("Button Triggered - Cube Spawned");
        }
    }

    private void SpawnCube()
    {
        Vector3 playerPosition = GameObject.Find("Main Camera").transform.position;

        Vector3 randomOffset;
        Vector3 spawnPosition;

        // Keep generating a new random position until it's above the minimum height
        do
        {
            // Generate a random position around the player within the specified radius
            randomOffset = new Vector3(
                Random.Range(-spawnRadius, spawnRadius),
                0,
                Random.Range(-spawnRadius, spawnRadius)
            );
            spawnPosition = playerPosition + randomOffset;
            spawnPosition.y = minimumHeight;
        } while (spawnPosition.y < minimumHeight);

        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}
