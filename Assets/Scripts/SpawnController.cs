using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject asteroid;
    public GameObject life;
    public GameObject puSpeed;
    public GameObject puTripleShoot;

    void Start() {
        InvokeRepeating("SpawnAsteroid", 1f, 2f);
        InvokeRepeating("SpawnLife", 10f, 20f);
        InvokeRepeating("SpawnPuSpeed", Random.Range(5, 10), 20f);
        InvokeRepeating("SpawnPuTripleShoot", Random.Range(5, 10), 20f);
    }


    void Update() {

    }

    void SpawnAsteroid() {
        Vector3 position = new Vector3(Random.Range(-7, 7), transform.position.y);
        Instantiate(asteroid, position, Quaternion.identity);
    }

    void SpawnLife() {
        Vector3 position = new Vector3(Random.Range(-7, 7), transform.position.y);
        Instantiate(life, position, Quaternion.identity);
    }

    void SpawnPuSpeed() {
        Vector3 position = new Vector3(Random.Range(-7, 7), transform.position.y);
        Instantiate(puSpeed, position, Quaternion.identity);
    }

    void SpawnPuTripleShoot() {
        Vector3 position = new Vector3(Random.Range(-7, 7), transform.position.y);
        Instantiate(puTripleShoot, position, Quaternion.identity);
    }
}
