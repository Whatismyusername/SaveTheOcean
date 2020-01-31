using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour
{
    ScoreBoard scoreboard;
    int[] highScores = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("Score", 0).ToString();

        GetHighScores();
        ProcessHighScore(0);
        SetHighScores();
        DisplayHighScores();
        // PlayerPrefs.DeleteAll();
    }

    void GetHighScores() {
        for(int i = 0; i < highScores.Length; i++) {
            string restoreStr = "#" + (i + 1).ToString();
            highScores[i] = PlayerPrefs.GetInt(restoreStr, 0); 
        }
    }

    void ProcessHighScore(int idx) {
        if (PlayerPrefs.GetInt("Score", 0) > highScores[idx]) {
            for (int j = highScores.Length - 1; j > idx; j--) {
                highScores[j] = highScores[j - 1];
            }
            highScores[idx] = PlayerPrefs.GetInt("Score");
        } else if(idx < highScores.Length - 1) {
            ProcessHighScore(idx + 1);
        }
    }

    void SetHighScores() {
        for (int i = 0; i < highScores.Length; i++) {
            string restoreStr = "#" + (i + 1).ToString();
            PlayerPrefs.SetInt(restoreStr, highScores[i]);
        }
        PlayerPrefs.DeleteKey("Score");
    }

    void DisplayHighScores() {
        for (int i = 0; i < highScores.Length; i++) {
            string target = "(" + (i + 1).ToString() + ")";
            GameObject.Find(target).GetComponent<Text>().text = target + " " + highScores[i].ToString();
        }
        
    }
}
