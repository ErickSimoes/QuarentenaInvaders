using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    public void CallScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

}
