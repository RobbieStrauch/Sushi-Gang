using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModelManager : MonoBehaviour
{
    public List<GameObject> prefabs;
    public Transform spawnPosition;
    public List<RenderTexture> renderTextures;
    public RawImage rawImage;
    public TMP_Text modelText;

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rawImage.texture = renderTextures[currentIndex];
        modelText.text = renderTextures[currentIndex].name;
    }

    public void MoveLeft()
    {
        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = renderTextures.Count - 1;
        }
    }

    public void MoveRight()
    {
        currentIndex++;
        if (currentIndex > renderTextures.Count - 1)
        {
            currentIndex = 0;
        }
    }

    public void Confirm()
    {
        GameObject temp = Instantiate(prefabs[currentIndex]);
        temp.transform.position = spawnPosition.position;
    }
}
