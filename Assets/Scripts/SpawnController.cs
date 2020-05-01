using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {

    public GameObject asteroid;

    void Start() {
        InvokeRepeating("SpawnAsteroid", 1f, 2f);
    }


    void Update() {

    }

    void SpawnAsteroid() {
        Vector3 position = new Vector3(Random.Range(-7, 7), transform.position.y);
        Instantiate(asteroid, position, Quaternion.identity);
    }
}
