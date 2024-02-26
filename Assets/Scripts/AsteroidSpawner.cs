using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    Transform player;

    public GameObject staticAsteroid;

    //czas od ostatnio
    float timeSinceSpawn;
    void Start()
    {
        //znajduje gracza i przypisuje do zmiennej
        player = GameObject.FindWithTag("Player").transform;
        timeSinceSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceSpawn += Time.deltaTime;

        if(timeSinceSpawn > 1 ) {
            GameObject asteroid = SpawnAsteroid(staticAsteroid);
            timeSinceSpawn = 0;

        }
        
    }

    GameObject SpawnAsteroid(GameObject prefab) {
        Vector3 randomPosition = Random.onUnitSphere * 10;

        //na³ó¿ pozycje gracza
        randomPosition += player.position;

        GameObject asteroid = Instantiate(staticAsteroid, randomPosition, Quaternion.identity);

        //zwróæ asteroidê jako wynik dzia³ania
        return asteroid;
    }
}
