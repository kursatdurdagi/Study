using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalSpawner : MonoBehaviour
{
    public GameObject crystalPrefab;

    public Transform[] spawnPos;

    public int currentCrystalInMap;

    [Header("Timer")]
    public float getSpawn;

    void Start()
    {
        SpawnCrystal();
    }

    void Update()
    {
        
    }

    public void SpawnCrystal()
    {
        for(int i = 0;i < 5; i++)
        {
            Instantiate(crystalPrefab, spawnPos[Random.Range(0, spawnPos.Length)].position, transform.rotation);
            currentCrystalInMap++;
        }
    }

    public void SpawnNewCrystal()
    {
        Invoke("InvokaSpawnCrystal", getSpawn);
    }

    void InvokaSpawnCrystal()
    {
        getSpawn = Random.Range(1, 2f);
        currentCrystalInMap++;
        Instantiate(crystalPrefab, spawnPos[Random.Range(0, spawnPos.Length)].position, transform.rotation);
    }
}
