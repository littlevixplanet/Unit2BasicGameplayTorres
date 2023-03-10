using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2 : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public float sideSpawnMinZ; 
    public float sideSpawnMaxZ;
    public float sideSpawnX;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
    }
    void SpawnLeftAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); 
        Vector3 rotation = new Vector3(0, 90, 0); 
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation)); 
    }
}
