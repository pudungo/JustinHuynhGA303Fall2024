using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningLogic : MonoBehaviour
{
    public GameObject vergil;
    public float spawnAreaMinX;
    public float spawnAreaMinY;
    public float spawnAreaMaxY;
    public float spawnAreaMaxX;

    public int spawnNumber = 3;

    void Start()
    {
        Spawn();
      
    }

    void Spawn()
    {
        for (int i = 0; i < spawnNumber; i++)
        {
            float randomX = Random.Range(spawnAreaMinX, spawnAreaMaxX);
            float randomY = Random.Range(spawnAreaMinY, spawnAreaMaxY);
            Vector2 randomPosition = new Vector2(randomX, randomY);

            Instantiate(vergil, randomPosition, Quaternion.identity);
        }



    }       
}
