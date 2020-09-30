using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {

    [SerializeField]
    private Text highScoreText;
    [SerializeField]
    private Text newRecordText;

    public void CallScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    void Start() {
        if (highScoreText && newRecordText) {
            highScoreText.text = ScoreController.GetScore().ToString();
            newRecordText.gameObject.SetActive(ScoreController.IsNewRecord());
        }
    }

}
