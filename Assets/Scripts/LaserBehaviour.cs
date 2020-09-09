using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBehaviour : MonoBehaviour {

    public float speed;
    private static PlayerBehaviour player;

    void Start() {
        if (!player) {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerBehaviour>();
        }
    }

    void Update() {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnBecameInvisible() {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.tag == "asteroid") {
            player.score++;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
