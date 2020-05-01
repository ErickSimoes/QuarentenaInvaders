using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    private float xMax = 9;
    private float yMax = 5;
    public GameObject laser;

    void Start() {

    }

    void Update() {
        Moviment();
        Shoot();
    }

    void Moviment() {
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
        transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (transform.position.x > xMax) {
            transform.position = new Vector3(-xMax, transform.position.y);
        } else if (transform.position.x < -xMax) {
            transform.position = new Vector3(xMax, transform.position.y);
        } else if (transform.position.y > yMax) {
            transform.position = new Vector3(transform.position.x, -yMax);
        } else if (transform.position.y < -yMax) {
            transform.position = new Vector3(transform.position.x, yMax);
        }
    }

    void Shoot() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
}
