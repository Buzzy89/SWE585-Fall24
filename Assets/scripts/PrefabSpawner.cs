using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    // Reference to the prefab to spawn
    public GameObject prefab;

    // Spawn position
    public Vector3 spawnPosition = new Vector3(0, 5, -10);  

    // Update is called once per frame
    void Update()
    {
        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
