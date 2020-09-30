using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour {

    void Start() {
        GameObject[] musicControllers = GameObject.FindGameObjectsWithTag("music_controller");

        if (musicControllers.Length > 1) {
            Destroy(this.gameObject);
        } else {
            DontDestroyOnLoad(this.gameObject);
        }

    }
}
