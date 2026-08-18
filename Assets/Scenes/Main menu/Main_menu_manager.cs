using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu_manager : MonoBehaviour
{
    public void OnStartClick()
    {
        SceneManager.LoadScene("idk");
    }
    public void Fuu()
    {
        Debug.Log("message");
    }
    public void OnExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
