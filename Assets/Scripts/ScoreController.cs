using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreController {

    private const string SCORE = "score";
    private const string NEW_RECORD = "record";
    private const int FALSE = 0, TRUE = 1;

    public static void SaveScore(int score) {
        if (PlayerPrefs.HasKey(SCORE)) {
            if (score > PlayerPrefs.GetInt(SCORE)) {
                PlayerPrefs.SetInt(SCORE, score);
                PlayerPrefs.SetInt(NEW_RECORD, TRUE);
            }
        } else {
            PlayerPrefs.SetInt(SCORE, score);
            PlayerPrefs.SetInt(NEW_RECORD, TRUE);
        }
    }

    public static int GetScore() {
        if (PlayerPrefs.HasKey(SCORE)) {
            return PlayerPrefs.GetInt(SCORE);
        } else {
            return 0;
        }
    }

    public static bool IsNewRecord() {
        if (PlayerPrefs.HasKey(NEW_RECORD) && PlayerPrefs.GetInt(SCORE) == TRUE) {
            PlayerPrefs.SetInt(NEW_RECORD, FALSE);
            return false;
        } else {
            return true;
        }
    }
}
