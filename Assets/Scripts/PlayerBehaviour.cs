using Battlehub.Dispatcher;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour {

    public float speed;
    private float xMax = 9;
    private float yMax = 5;
    public GameObject laser;
    public GameObject laserReference;
    public int lives = 3;
    public Text livesText;
    private bool isSpeed = false;

    void Start() {

    }

    void Update() {
        Moviment();
        Shoot();
        CheckLives();
    }

    void Moviment() {
        if (isSpeed) {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * 2 * Time.deltaTime);
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * 2 * Time.deltaTime);
        } else {
            transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime);
            transform.Translate(Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime);
        }

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
            Instantiate(laser, laserReference.transform.position, Quaternion.identity);
        }
    }

    void CheckLives() {
        Dispatcher.Current.BeginInvoke(() => {
            livesText.text = lives.ToString();
        });
        if (lives <= 0) {
            SceneManager.LoadScene("EndScene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "asteroid") {
            Destroy(collision.gameObject);
            lives--;
        }

        if (collision.tag == "life") {
            Destroy(collision.gameObject);
            lives++;
        }

        if (collision.tag == "pu_speed") {
            Destroy(collision.gameObject);
            StartCoroutine(StartSpeedPU());
        }
    }

    IEnumerator StartSpeedPU() {
        isSpeed = true;
        yield return new WaitForSeconds(5f);
        isSpeed = false;
    }
}
