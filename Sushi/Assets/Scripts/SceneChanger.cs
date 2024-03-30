using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void CurrentScene()
    {
        //SceneManager.LoadScene("MenuDemo");
    }

    public void FutureScene()
    {
        //SceneManager.LoadScene("MenuDemo");
    }

    public void FreeScene()
    {
        //SceneManager.LoadScene("MenuDemo");
    }

    public void MenuScene()
    {
        //SceneManager.LoadScene("MenuDemo");
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
