using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void CurrentScene()
    {
        SceneManager.LoadScene("CurrentScene");
    }

    public void FutureScene()
    {
        SceneManager.LoadScene("FutureScene");
    }

    public void FreeScene()
    {
        SceneManager.LoadScene("FreeScene");
    }

    public void MenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
}
