using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_manager : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
