using UnityEngine;

public class GameMusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake() {
        if(FindObjectsOfType<GameMusicPlayer>().Length > 1) {
            Destroy(gameObject);
        } else {
            DontDestroyOnLoad(gameObject);
        } 
    }
}
