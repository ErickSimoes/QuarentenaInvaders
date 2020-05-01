using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidBehaviour : MonoBehaviour {

    public float speed;

    void Start() {

    }


    void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
        transform.Rotate(Vector3.forward * speed * 15 * Time.deltaTime, Space.World);
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
