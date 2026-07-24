using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public void StartFallingClocks() {
        Debug.Log("Entered StartFallingClocks()");
        string currentSceneName = SceneManager.GetActiveScene().name;

        if (currentSceneName != "Falling clocks game") {
            Debug.Log("Unloading current scene");
            SceneManager.UnloadSceneAsync(currentSceneName);
            Debug.Log("Loading falling clocks");
            SceneManager.LoadSceneAsync("Falling clocks game");
        }
    }
}

