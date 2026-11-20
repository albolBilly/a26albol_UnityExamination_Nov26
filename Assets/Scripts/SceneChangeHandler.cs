using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// This component can be used to access methods for changing the scene, and quitting the game
// It can be used together with UnityEventOnTrigger, or UI-button-events, to decide when a scene should be changed or the game should be closed
public class SceneChangeHandler : MonoBehaviour
{
    public void ChangeSceneToLore()
    {
        // Load the scene named "NewScene"
        SceneManager.LoadSceneAsync("PrologueScene", LoadSceneMode.Single);
    }
    public void ChangeSceneToMain()
    {
        // Load the scene named "NewScene"
        SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Single);
    }
    public void ChangeSceneToSecret()
    {
        // Load the scene named "NewScene"
        SceneManager.LoadSceneAsync("SecretScene", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
