using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroMusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake() {
        if(FindObjectsOfType<IntroMusicPlayer>().Length > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        } 
    }
    private void Update() {
        if(SceneManager.GetActiveScene().buildIndex == 3) {
            Destroy(gameObject);
        }
    }
}
