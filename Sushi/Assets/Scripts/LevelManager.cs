using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public List<string> scenes;
    //public List<RenderTexture> renderTextures;
    public List<string> names;
    //public RawImage rawImage;
    public TMP_Text mapText;

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rawImage.texture = renderTextures[currentIndex];
        mapText.text = names[currentIndex];
    }

    public void MoveLeft()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = names.Count - 1;
        }
    }

    public void MoveRight()
    {
        currentIndex++;
        if (currentIndex > names.Count - 1)
        {
            currentIndex = 0;
        }
    }

    public void Confirm()
    {
        SceneManager.LoadScene(scenes[currentIndex]);
    }
}
