using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Playables;

public class OpeningLoadNextScene : MonoBehaviour
{
    // Update is called once per frame
    void Start() {
        gameObject.GetComponent<PlayableDirector>().Stop();
    }
    void Update()
    {
        if(CrossPlatformInputManager.GetButton("Fire")) {
            PrepareToLoadScene();
        }
    }

    void PrepareToLoadScene() {
        gameObject.GetComponent<PlayableDirector>().Play();
        FindObjectOfType<Canvas>().enabled = false;
        Invoke("loadNextScene", 4f);
    }

    void loadNextScene() {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
}
