using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBehaviour : MonoBehaviour {

    public float speed;
    public bool rotate = false;

    void Start() {

    }


    void Update() {
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        if (rotate) {
            transform.Rotate(Vector3.forward * speed * 15 * Time.deltaTime, Space.World);
        }
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }
}
