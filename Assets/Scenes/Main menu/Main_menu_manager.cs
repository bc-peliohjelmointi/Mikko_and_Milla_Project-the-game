using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_manager : MonoBehaviour
{
    public void LoadScene(string idk)
    {
        SceneManager.LoadScene(idk);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
