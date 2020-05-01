using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour {

    public float speed;

    void Start() {

    }

    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "asteroid") {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
