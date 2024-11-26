using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Public variable om de cube prefab in de Unity Inspector te slepen
    public GameObject CubePrefab;
    public float timer = 0;

    // List om de ingespawnde cubes bij te houden
    private List<GameObject> spawnedCubes = new List<GameObject>();

    
    void Update()
    {
        timer += Time.deltaTime;

        // Spawn 100 Cubes wanneer W is ingedrukt
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                GameObject newCube = Instantiate(CubePrefab);
                spawnedCubes.Add(newCube); // Track spawned Cubes
            }
        }

        // Spawn 1 cube elke 3 secondes
        if (timer >= 3)
        {
            GameObject newCube = Instantiate(CubePrefab);
            spawnedCubes.Add(newCube); // Track spawned Cubes
            timer = 0; // Reset the timer
        }

        // Vernitieg alle spawned Cubes wanneer Q is ingedrukt
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (GameObject cube in spawnedCubes)
            {
                if (cube != null)
                {
                    Destroy(cube);
                }
            }
            spawnedCubes.Clear(); // Clear the list
        }
    }
}
