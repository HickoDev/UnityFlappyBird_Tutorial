using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management
public class RestartController : MonoBehaviour
{
    // This function reloads the current scene
    public void ReloadScene()
    {
        // Get the current scene and reload it
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
