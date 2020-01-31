using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

public class LoadNextScene : MonoBehaviour
{
    void Update()
    {
        if(CrossPlatformInputManager.GetButton("Fire")) {
            SceneManager.LoadScene(3); // To Home Screen
        }
    }
}
