using UnityEngine;
using UnityEngine.SceneManagement;

public class FactoryLoadNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextScene", 4f);
    }

    // Update is called once per frame
    private void LoadNextScene() {
        int currentSceneIdx = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIdx = currentSceneIdx + 1;

        SceneManager.LoadScene(nextSceneIdx);
    }
}
