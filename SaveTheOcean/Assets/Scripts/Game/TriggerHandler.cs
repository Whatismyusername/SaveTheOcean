using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerHandler : MonoBehaviour
{
    [SerializeField] GameObject deathFX;
    private void OnTriggerEnter(Collider other) {
        SendMessage("StartDeathSequence");
    }
    private void StartDeathSequence() {
        deathFX.SetActive(true);
        Invoke("LoadScores", 2f); 
    }

    private void LoadScores() {
        SceneManager.LoadScene(5); // Load Score Screen
        PlayerPrefs.SetInt("Score", (int)ScoreBoard.score);
    }

}
