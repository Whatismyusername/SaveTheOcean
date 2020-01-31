using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GarbageLoadNextScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Load", 5f);
    }

    private void Load() {
        int currentSceneIdx = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIdx = currentSceneIdx + 1;
        SceneManager.LoadScene(nextSceneIdx);
    }
}
